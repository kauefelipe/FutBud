using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace FutBud
{
    public partial class FormAddPlayer : MetroForm
    {
        public FormAddPlayer(MetroStyleManager styleManager)
        {
            InitializeComponent();
            StyleManager = metroStyleManager;
            metroStyleManager.Style = styleManager.Style;
            metroStyleManager.Theme = styleManager.Theme;
            mgTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        public string ImgUrl { get; set; }
        public string PlayerName { get; set; }
        public string Rarity { get; set; }
        public string Rating { get; set; }
        public string Position { get; set; }
        public string PurchasePrice { get; set; }
        public string SellPrice { get; set; }
        public string Id { get; set; }

        private void FormAddPlayer_Load(object sender, EventArgs e){
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbPurchasePrice.Text == "" || tbSellPrice.Text == "")
            {
                MessageBox.Show("Please remember to enter prices!");
            }

            try
            {
                int x = mgTable.CurrentCell.RowIndex;
                PlayerName = mgTable[1, x].Value.ToString();
                Rarity = mgTable[2, x].Value.ToString();
                Rating = mgTable[3, x].Value.ToString();
                Position = mgTable[4, x].Value.ToString();
                Id = mgTable[5, x].Value.ToString();
                ImgUrl = mgTable[6, x].Value.ToString();
                PurchasePrice = tbPurchasePrice.Text;
                SellPrice = tbSellPrice.Text;
                DialogResult = DialogResult.OK;
            }
            catch (NullReferenceException)
            {
                DialogResult = DialogResult.Cancel;
            }
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (tbPlayerName.Text == "")
            {
                MessageBox.Show("Search parameter can not be empty!");
                return;
            }
            btnSearch.Enabled = false;
            mgTable.Rows.Clear();
            string name = tbPlayerName.Text;
            var req = (HttpWebRequest)WebRequest.Create("http://www.easports.com/uk/fifa/ultimate-team/api/fut/item?jsonParamObject=%7B%22name%22:%22" + name + "%22%7D");
            req.Method = "GET";
            req.Headers.Add("Accept-Language", "de-DE,de;q=0.8,en-US;q=0.6,en;q=0.4");
            req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla / 5.0(Windows NT 10.0; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 46.0.2490.80 Safari / 537.36";
            
            var resp = await req.GetResponseAsync();
            if (resp != null)
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                var html = new StreamReader(stream: resp.GetResponseStream(), encoding: Encoding.UTF8).ReadToEnd();
                resp.Close();
                SearchResultJson deserializedProduct = JsonConvert.DeserializeObject<SearchResultJson>(html);
                lblResults.Text = @"Results: " + deserializedProduct.count;
                int i = 0;
                foreach (SearchResultJson.Item item in deserializedProduct.items)
                {
                    mgTable.Rows.Add();
                    //get image
                    var reqImg = (HttpWebRequest)WebRequest.Create(item.headshot.medImgUrl);
                    reqImg.Method = "GET";
                    var respImg = await reqImg.GetResponseAsync();
                    if (respImg != null)
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        Bitmap bmp = new Bitmap(stream: respImg.GetResponseStream());
                        respImg.Close();
                        mgTable[0, i].Value = bmp;
                    }
                    //add name
                    mgTable[1, i].Value = item.firstName + " " + item.lastName;
                    //Rarity
                    mgTable[2, i].Value = item.color;
                    //Rating
                    mgTable[3, i].Value = item.rating;
                    //position
                    mgTable[4, i].Value = item.position;
                    //Id
                    mgTable[5, i].Value = item.id;
                    //ImageUrl
                    mgTable[6, i].Value = item.headshot.medImgUrl;
                    i++;
                }
            }
            btnSearch.Enabled = true;
        }

        private void tbPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
