using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using FutBud.Services;
using MetroFramework.Forms;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Exceptions;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Services;

namespace FutBud
{
    public partial class FormEaLogin : MetroForm
    {
        public FormEaLogin()
        {
            InitializeComponent();
            BringToFront();
            lblVersion.Text = @"Version " + ProductVersion;
            if (!Directory.Exists("cookies"))
                Directory.CreateDirectory("cookies");
            DoLoadAccount();
        }

        private FutClient _client;
        List<string[]> _accounts;


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbSecret.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Platform platform = Platform.Pc;
            var user = tbUsername.Text;
            var password = tbPassword.Text;
            var sAnswer = tbSecret.Text;

            if (File.Exists("cookies\\"+user+"_cookie.dat"))
            {
                CookieContainer cookie = CookieUtil.ReadCookiesFromDisk("cookies\\" + user + "_cookie.dat");
                _client = new FutClient(cookie);
            }
            else
            {
                _client = new FutClient();
            }
            
            this.Enabled = false;

            switch (cbPlatform.SelectedIndex)
            {
                case 0:
                    platform = Platform.Pc;
                    break;
                case 1:
                    platform = Platform.Ps3;
                    break;
                case 2:
                    platform = Platform.Ps4;
                    break;
                case 3:
                    platform = Platform.Xbox360;
                    break;
                case 4:
                    platform = Platform.XboxOne;
                    break;
            }

            var loginDetails = new LoginDetails(user, password, sAnswer, platform);
            ITwoFactorCodeProvider provider = new ImapTwoFactorCodeProvider();
            try
            {

                await _client.LoginAsync(loginDetails, provider);
                if (!File.Exists("cookies\\" + user + "_cookie.dat"))
                {
                    var cookiecontainer = _client.RequestFactories.CookieContainer;
                    CookieUtil.WriteCookiesToDisk("cookies\\" + user + "_cookie.dat", cookiecontainer);
                }
                var frm = new FormMain(_client, new[] {user,password, sAnswer, cbPlatform.SelectedIndex.ToString()});
                frm.Show();
                Hide();
            }
            catch (FutException ex)
            {
                MessageBox.Show("Login Failed");
                WriteLog.DoWrite("Login Failed: " + ex.InnerException.Message);
                _client = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
                WriteLog.DoWrite("Login Error: " + ex.InnerException.Message);
                _client = null;

            }
            finally
            {
                this.Enabled = true;
            }

        }

        public class ImapTwoFactorCodeProvider : ITwoFactorCodeProvider
        {
            public Task<string> GetTwoFactorCodeAsync()
            {
                return Task.Run(() =>
                {
                    TwoFactor x = new TwoFactor();
                    x.ShowDialog();
                    var code = x.Code;
                    return code;
                });
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckUpdateStartup)
            {
                string str = "";
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
                    MessageBox.Show("A new version is available (" + str +
                                    "). Please visit 'www.futbud.com' to download the newest version");
                }
            }
        }

        //press enter to login
        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://futbud.com");
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount x = new FormAddAccount();
            x.ShowDialog();
            x.Dispose();
            DoLoadAccount();
        }

        
        private void DoLoadAccount()
        {
            _accounts = null;
            _accounts = new List<string[]>();
            lbAccounts.Items.Clear();

            int i = 0;
            try
            {
                StreamReader sr = new StreamReader("accounts.txt");
                while (!sr.EndOfStream)
                {
                    var readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        _accounts.Add(readLine.Split(';')); 
                        lbAccounts.Items.Add(_accounts[i][0]);
                        i++;
                    }
                    
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                WriteLog.DoWrite("Login Error: " + ex.Message);
            }
        }

        private void lbAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            var i = lbAccounts.SelectedIndex;
            if(i==-1)
                return;
            tbUsername.Text = _accounts[i][0].ToString();
            tbPassword.Text = Encryption.Decrypt(_accounts[i][1].ToString());
            tbSecret.Text = Encryption.Decrypt(_accounts[i][2].ToString());
            cbPlatform.SelectedIndex = Int32.Parse(_accounts[i][3]);
        }
    }
}

