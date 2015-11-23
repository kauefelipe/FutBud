using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FutBud.Properties;
using FutBud.Services;
using MetroFramework;
using MetroFramework.Forms;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Exceptions;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Parameters;

namespace FutBud
{
    public partial class FormMain : MetroForm
    {
        private FutClient _client;

        //Timerstuff
        private short _runtimeseconds;
        private short _runtimeminutes;
        private short _runtimehours;
        private short _runtimedays;

        #region settings

        private bool _debug;
        private int _searchMs = Properties.Settings.Default.SearchRPM;
        private int _tradepileMs = Properties.Settings.Default.TradepileRPM;
        private int _maxplayersonrequest = Properties.Settings.Default.MaxPlayersFound;
        private bool _checkforupdates = Properties.Settings.Default.CheckUpdateStartup;
        private readonly string[] _account;

        #endregion

        public FormMain(FutClient client, string[] account)
        {
            InitializeComponent();
            _client = client;
            this._account = account;
            StyleManager = metroStyleManager;
            metroStyleManager.Style = Properties.Settings.Default.MetroColor;
            metroStyleManager.Theme = Properties.Settings.Default.MetroTheme;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            tbSearch.Text = (Math.Round((double)_searchMs / 1000, 1)).ToString(CultureInfo.InvariantCulture);
            tbChecktradepile.Text = (_tradepileMs/1000).ToString();

            numericUpDownPricefix.Value = _maxplayersonrequest;
            tmrChecktradepile.Interval = _tradepileMs;
            tmrSearchRequest.Interval = _searchMs;
            cbCheckforUpdates.Checked = _checkforupdates;

            lblAccount.Text = account[0];
            lblVersion.Text = @"Version " + ProductVersion;
            if(_client!=null)
                GetCredits();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_CheckedChanged(object sender, EventArgs e)
        {
            GetCredits();
            if (btnStart.Checked)
            {
                Startbot();
            }
            else
            {
                Stopbot();
            }
        }

        private void Startbot()
        {
            lblStatus.Text = Resources.FormMain_Startbot_Status__Running;
            tbLog.SelectionColor = Color.Black;
            tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Started" + Environment.NewLine;
            tmrSearchRequest.Enabled = true;
            tmrChecktradepile.Enabled = true;
            psStatus.Spinning = true;
            btnStart.Checked = true;
        }

        private void Stopbot()
        {
            lblStatus.Text = Resources.FormMain_Stopbot_Status__Paused;
            tbLog.SelectionColor = Color.Black;
            tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Stoped" + Environment.NewLine;
            tmrSearchRequest.Enabled = false;
            tmrChecktradepile.Enabled = false;
            psStatus.Spinning = false;
            btnStart.Checked = false;
        }

        private int _i;
        private async void SearchMarket()
        {
            try
            {
                if (_i < mgTable.Rows.Count - 1) //check if i needs a reset
                {
                    var searchParameters = new PlayerSearchParameters
                    {
                        Page = 1,
                        MaxBuy = uint.Parse(mgTable[2, _i].Value.ToString()),
                        ResourceId = uint.Parse(mgTable[8, _i].Value.ToString())
                    };

                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    uint.Parse(mgTable[3, _i].Value.ToString()); //check sell for null

                    var searchResponse = await _client.SearchAsync(searchParameters);
                    if (_debug)
                    {
                        tbLog.SelectionColor = Color.Blue;
                        tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Search for Player " +
                                             mgTable[1, _i].Value + Environment.NewLine;
                        tbLog.SelectionColor = Color.Blue;
                        tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " " +
                                             searchResponse.AuctionInfo.Count + " Auctions found" +
                                             Environment.NewLine;
                    }
                    foreach (var auctionInfo in searchResponse.AuctionInfo)
                    {
                        // Handle auction data
                        if (searchResponse.AuctionInfo.Count < _maxplayersonrequest) //check for pricefix
                        {
                            await _client.PlaceBidAsync(auctionInfo, auctionInfo.BuyNowPrice);
                            //Buyout Item
                            await _client.SendItemToTradePileAsync(auctionInfo.ItemData);

                            //send Item to Tradepile
                            int counter = int.Parse(mgTable[4, _i].Value.ToString());
                            counter++;
                            mgTable[4, _i].Value = counter.ToString();
                            tbLog.SelectionColor = Color.Black;
                            tbLog.SelectedText = DateTime.Now.ToLongTimeString() +
                                                 " Buyout for Player " +
                                                 mgTable[1, _i].Value + Environment.NewLine;
                            GetCredits();
                        }
                    }
                    _i++;
                }
                else
                {
                    _i = 0;
                }
            }
            catch (NotEnoughCreditException)
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Not enough credits " +
                                     Environment.NewLine;
            }
            catch (CaptchaTriggeredException) //Captcha Triggered!
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Captcha triggered " +
                                     Environment.NewLine;
                Stopbot();
            }
            catch (ExpiredSessionException) //Session Expired
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Session Expired " +
                                     Environment.NewLine;
                Stopbot();
                using (var x = new FormRelog(_account))
                {
                    x.ShowDialog();
                    this._client = x.Client;
                }
                Startbot();
            }
            catch (FormatException)
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Entry " + _i + " has an invalid Format or is null" +
                                     Environment.NewLine;
                Stopbot();
            }
            catch (NullReferenceException)
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Entry " + _i + " has an invalid Format or is null" +
                                     Environment.NewLine;
                Stopbot();
            }
            catch (Exception)
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Error 100 - Please be sure that your transfermarket is not locked" +
                                     Environment.NewLine;
                Stopbot();
            }
        }

        private async void Checktradepile()
        {
            try
            {
                var tradePileResponse = await _client.GetTradePileAsync();
                foreach (var response in tradePileResponse.AuctionInfo)
                {
                    for (var i = 0; i < mgTable.Rows.Count - 1; i++)

                        if (response.ItemData != null &&
                            mgTable[8, i].Value.ToString().Contains(response.ItemData.AssetId.ToString()))
                        {

                            if ((response.TradeState == null || response.TradeState.Contains("expired")) &&
                                response.ItemData != null) //Player to list
                            {
                                var sellprice = uint.Parse(mgTable[3, i].Value.ToString());
                                if (sellprice == 0) //if price = 0 do not sell
                                    break;

                                if (sellprice > 100000)
                                {
                                    var auctionDetails = new AuctionDetails(response.ItemData.Id,
                                        AuctionDuration.OneHour,
                                        RoundPrices.RoundToFinal(sellprice - 1000), sellprice); //bidprice, buynow price
                                    await _client.ListAuctionAsync(auctionDetails);
                                }
                                else
                                {
                                    var auctionDetails = new AuctionDetails(response.ItemData.Id,
                                        AuctionDuration.OneHour,
                                        RoundPrices.RoundToFinal(sellprice - 250), sellprice); //bidprice, buynow price
                                    await _client.ListAuctionAsync(auctionDetails);
                                }
                                continue;
                            }
                            if (response.TradeState != null && response.ItemData != null &&
                                (response.TradeState.Contains("closed"))) //Player sold
                            {
                                await _client.RemoveFromTradePileAsync(response);
                                tbLog.SelectionColor = Color.Black;
                                tbLog.SelectedText =
                                    (DateTime.Now.ToLongTimeString() + " " + mgTable[1, i].Value +
                                     " sold for " +
                                     response.BuyNowPrice) +
                                    Environment.NewLine;
                                GetCredits();
                            }

                            //TODO ITEMS ON TRADEPILE
                            /*if (response.TradeState != null && response.ItemData != null) //Player on tradepile
                                {
                                    tbTradepile.Text = "" + tbTradepile.Text + dgList[0, i].Value + " - " +
                                                       response.BuyNowPrice + " Coins - " + response.Expires / 60 +
                                                       " Minutes left " +
                                                 Environment.NewLine;
                                    tbTradepile.Text = "" + tbTradepile.Text + "***********************************************" +
                                                 Environment.NewLine;

                                }
                                */
                        }
                }
            }
            catch
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = "Tradepile Error" + Environment.NewLine;
            }
        }

        private async void GetCredits()
        {
            try
            {
                var creditsResponse = await _client.GetCreditsAsync();
                lblCredits.Text = creditsResponse.Credits + Resources.FormMain_GetCredits__Credits;
            }
            catch
            {
                // ignored
            }
        }

        //Add player to list
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var x = new FormAddPlayer(StyleManager);
            if (x.ShowDialog() == DialogResult.OK)
            {
                mgTable.Rows.Add();
                int rows = mgTable.Rows.Count;
                mgTable[1, rows - 2].Value = x.PlayerName;
                mgTable[2, rows - 2].Value = x.PurchasePrice;
                mgTable[3, rows - 2].Value = x.SellPrice;
                mgTable[4, rows - 2].Value = 0; //Counter
                mgTable[5, rows - 2].Value = x.Rarity;
                mgTable[6, rows - 2].Value = x.Rating;
                mgTable[7, rows - 2].Value = x.Position;
                mgTable[8, rows - 2].Value = x.Id;
                mgTable[9, rows - 2].Value = x.ImgUrl;

                try
                {
                    var reqImg = (HttpWebRequest)WebRequest.Create(x.ImgUrl);
                    reqImg.Method = "GET";
                    var respImg = await reqImg.GetResponseAsync();
                    if (respImg != null)
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        Bitmap bmp = new Bitmap(stream: respImg.GetResponseStream());
                        respImg.Close();
                        mgTable[0, rows - 2].Value = bmp;
                    }
                }
                catch (Exception)
                {
                    tbLog.SelectionColor = Color.Red;
                    tbLog.SelectedText = "Error getting Image" + Environment.NewLine;
                }
                
                
            }
            x.Dispose();
        }
        
        //Runtime timer
        private void tmrRuntime_Tick(object sender, EventArgs e)
        {
            _runtimeseconds++;
            if (_runtimeseconds == 60)
            {
                _runtimeminutes++;
                _runtimeseconds = 00;
            }
            else if (_runtimeminutes == 60)
            {
                _runtimehours++;
                _runtimeminutes = 00;
            }
            else if (_runtimehours == 24)
            {
                _runtimedays++;
                _runtimehours = 00;
            }

            lblRuntime.Text = @"Runtime: " +_runtimedays.ToString("00") + @":" + _runtimehours.ToString("00") + @":" + _runtimeminutes.ToString("00") + @":" +
                              _runtimeseconds.ToString("00");
        }

        //Toggle Debug Button
        private void toggleDebug_CheckedChanged(object sender, EventArgs e)
        {
            _debug = !_debug;
            tbLog.SelectionColor = Color.Black;
            tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Debug = " + _debug + Environment.NewLine;
        }

        //Search request timer
        private void tmrRequest_Tick(object sender, EventArgs e)
        {
                SearchMarket();
        }

        //Save player list
        private void btnSave_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            
            foreach (DataGridViewRow row in mgTable.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Skip(1).Select(cell => "" + cell.Value).ToArray()));
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }

            sb.Clear();
        }

        //Load player list
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mgTable.Rows.Clear();
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    while (!sr.EndOfStream)
                    {
                        //read line per line
                        var readLine = sr.ReadLine();
                        if (readLine != null)
                        {
                            var str = readLine.Split(';');
                            if(str[0] == "")
                                break; //Check for end of file to avoid adding rows
                            mgTable.Rows.Add();
                            mgTable[1, i].Value = str[0];
                            mgTable[2, i].Value = str[1];
                            mgTable[3, i].Value = str[2];
                            mgTable[4, i].Value = str[3]; //Counter
                            mgTable[5, i].Value = str[4];
                            mgTable[6, i].Value = str[5];
                            mgTable[7, i].Value = str[6];
                            mgTable[8, i].Value = str[7];
                            mgTable[9, i].Value = str[8];
                            //get image
                            try
                            {
                                var reqImg = (HttpWebRequest)WebRequest.Create(str[8]);
                                reqImg.Method = "GET";
                                var respImg = await reqImg.GetResponseAsync();
                                if (respImg != null)
                                {
                                    // ReSharper disable once AssignNullToNotNullAttribute
                                    Bitmap bmp = new Bitmap(stream: respImg.GetResponseStream());
                                    respImg.Close();
                                    mgTable[0, i].Value = bmp;
                                }
                            }
                            catch (Exception)
                            {
                                tbLog.SelectionColor = Color.Red;
                                tbLog.SelectedText = "Error getting Image" + Environment.NewLine;
                            }
                        }
                        i++;
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
                tbLog.SelectionColor = Color.Red;
                tbLog.SelectedText = "Error opening List" + Environment.NewLine;
            }
            
        }

        
        //Clear the log
        private void btnClear_Click(object sender, EventArgs e) 
        {
            tbLog.Text = null;
        }

        private void trackbarSearch_Scroll(object sender, ScrollEventArgs e)
        {
            tmrSearchRequest.Interval = _searchMs;
            _searchMs = trackbarSearch.Value;
            tbSearch.Text = (Math.Round((double)_searchMs / 1000, 1)).ToString(CultureInfo.InvariantCulture);
            
        }

        private void trackbarChecktradepile_Scroll(object sender, ScrollEventArgs e)
        {
            tmrChecktradepile.Interval = _tradepileMs;
            _tradepileMs = trackbarChecktradepile.Value;
            tbChecktradepile.Text = (_tradepileMs/1000).ToString();
        }

        private void tmrChecktradepile_Tick(object sender, EventArgs e)
        {
            if(_debug)
            {
                tbLog.SelectionColor = Color.Blue;
                tbLog.SelectedText = DateTime.Now.ToLongTimeString() + " Checking Tradepile + Credits " +
                                     Environment.NewLine;
            }
                
            Checktradepile();
            GetCredits();
        }

        

        //Option how many players can be found on a auction to fix potential pricefix
        private void numericUpDownPricefix_ValueChanged(object sender, EventArgs e)
        {
            _maxplayersonrequest = (int)numericUpDownPricefix.Value;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=C3LEHJLSTX326");
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://futbud.com");
        }

        #region appearance

        private void mtSilver_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Silver;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtBlue_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtGreen_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Green;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtLime_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Lime;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtTeal_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Teal;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtOrange_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Orange;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtBrown_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Brown;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtPink_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Pink;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtMagenta_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Magenta;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtPurple_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Purple;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtRed_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Red;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtYellow_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Yellow;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtLight_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Light;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void mtDark_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        #endregion

        //Safe the settings
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SearchRPM = _searchMs;
            Properties.Settings.Default.TradepileRPM = _tradepileMs;
            Properties.Settings.Default.MaxPlayersFound = _maxplayersonrequest;
            Properties.Settings.Default.CheckUpdateStartup = _checkforupdates;
            Properties.Settings.Default.Save();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Properties.Settings.Default.MetroColor = metroStyleManager.Style;
            Properties.Settings.Default.MetroTheme = metroStyleManager.Theme;
            Properties.Settings.Default.Save();
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = VersionCheck.Check(ProductVersion);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not check version :(");
                return;
            }

            if (!str.Equals("ok"))
            {
                MessageBox.Show("A new version is available (" + str + "). Please visit 'www.futbud.com' to download the newest version");
            }
            else
            {
                MessageBox.Show("No update available");
            }
        }

        private void cbCheckforUpdates_CheckedChanged(object sender, EventArgs e)
        {
            _checkforupdates = cbCheckforUpdates.Checked;
        }
    }
}
