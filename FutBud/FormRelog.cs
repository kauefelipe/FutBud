using System;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;
using FutBud.Services;
using MetroFramework.Forms;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Models;

namespace FutBud
{
    public partial class FormRelog : MetroForm
    {
        public FormRelog(string[] account)
        {
            InitializeComponent();
            this._account = account;
            DoRelog();
        }

        public FutClient Client { get; set; }
        private readonly string[] _account;
        private DateTime _endTime;
        private int _i = 0;

        public async void DoRelog()
        {
            
            lblTimer.Text = @"";
            lblRelog.Text = @"Performing relog";
            WriteLog.DoWrite("Performing relog");
            Platform platform = Platform.Pc;
            switch (int.Parse(_account[3]))
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

            
            try
            {
                CookieContainer cookie = CookieUtil.ReadCookiesFromDisk("cookies\\" + _account[0] + "_cookie.dat");
                Client = new FutClient(cookie);
                var loginDetails = new LoginDetails(_account[0], _account[1], _account[2], platform);
                await Client.LoginAsync(loginDetails, null);
                this.Close();
            }
            catch (Exception)
            {
                if (_i >= 5)
                {
                    WriteLog.DoWrite("Relog failed 5 times, exiting FutBud");
                    Application.Exit();
                }
                WriteLog.DoWrite("Relog failed");
                lblRelog.Text = (@"Relog failed");
                var start = DateTime.UtcNow;
                _endTime = start.AddMinutes(5);
                tmrCountdown.Enabled = true;
                _i++;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = _endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                lblTimer.Text = "";
                tmrCountdown.Enabled = false;
                DoRelog();
            }
            else
            {
                lblTimer.Text = @"Next try in: "+ remainingTime.Minutes+@":"+remainingTime.Seconds;
            }
        }
    }
}
