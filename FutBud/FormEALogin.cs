using System;
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
            cbSafe.Checked = Properties.Settings.Default.Safelogin;
            if (Properties.Settings.Default.Safelogin)
            {
                if (Properties.Settings.Default.EAUser != "" && Properties.Settings.Default.EAPW != "" &&Properties.Settings.Default.EAAnswer != "")
                {
                    tbUsername.Text = Encryption.Decrypt(Properties.Settings.Default.EAUser);
                    tbPassword.Text = Encryption.Decrypt(Properties.Settings.Default.EAPW);
                    tbSecret.Text = Encryption.Decrypt(Properties.Settings.Default.EAAnswer);
                    cbPlatform.SelectedIndex = Properties.Settings.Default.platform;
                }
            }
            else
            {
                cbPlatform.SelectedIndex = 0;
            }
        }

        private FutClient _client;
        
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbSecret.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (File.Exists("cookie.dat"))
            {
                CookieContainer cookie = CookieUtil.ReadCookiesFromDisk("cookie.dat");
                _client = new FutClient(cookie);
            }
            else
            {
                _client = new FutClient();
            }
            
            Platform platform = Platform.Pc;
            var user = tbUsername.Text;
            var password = tbPassword.Text;
            var sAnswer = tbSecret.Text;
            tbPassword.Hide();
            tbSecret.Hide();
            tbUsername.Hide();
            lblPassword.Hide();
            lblSecret.Hide();
            lblUsername.Hide();
            lblPlatform.Hide();
            cbPlatform.Hide();
            btnLogin.Hide();
            cbSafe.Hide();
            ProgressSpinner.Show();

            switch (cbPlatform.SelectedIndex)
            {
                case 0:
                    platform = Platform.Pc ;
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

            var loginDetails = new LoginDetails(user, password, sAnswer, platform );
            ITwoFactorCodeProvider provider = new ImapTwoFactorCodeProvider();
            try
            {
                if (cbSafe.Checked)
                {
                    Properties.Settings.Default.EAUser = Encryption.Encrypt(tbUsername.Text);
                    Properties.Settings.Default.EAPW = Encryption.Encrypt(tbPassword.Text);
                    Properties.Settings.Default.EAAnswer = Encryption.Encrypt(tbSecret.Text);
                    Properties.Settings.Default.platform = cbPlatform.SelectedIndex;
                    Properties.Settings.Default.Safelogin = cbSafe.Checked;
                    Properties.Settings.Default.Save();
                }

                await _client.LoginAsync(loginDetails, provider);
                var frm = new FormMain(_client);
                if (!File.Exists("cookie.dat")&& cbSafe.Checked)
                {
                    var cookiecontainer = _client.RequestFactories.CookieContainer;
                    CookieUtil.WriteCookiesToDisk("cookie.dat", cookiecontainer);
                }
                frm.Show();
                Hide();
                
            }
            catch (FutException)
            {
                MessageBox.Show("Login Failed");
                _client = null;
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
                _client = null;
                
            }
            finally
            {
                tbPassword.Show();
                tbSecret.Show();
                tbUsername.Show();
                lblPassword.Show();
                lblSecret.Show();
                lblUsername.Show();
                lblPlatform.Show();
                cbPlatform.Show();
                btnLogin.Show();
                cbSafe.Show();
                ProgressSpinner.Hide();
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
                    MessageBox.Show("A new version is available ("+str+"). Please visit 'www.futbud.com' to download the newest version");
                }
            }
        }
        private void cbSafe_CheckedChanged(object sender, EventArgs e)
        {
            //clear saved stuff
            if (cbSafe.Checked == false)
            {
                tbPassword.Text = "";
                tbUsername.Text = "";
                tbSecret.Text = "";
                Properties.Settings.Default.EAUser = "";
                Properties.Settings.Default.EAPW = "";
                Properties.Settings.Default.EAAnswer = "";
                Properties.Settings.Default.Safelogin = cbSafe.Checked;
                Properties.Settings.Default.Save();
                if(File.Exists("cookie.dat"))
                    File.Delete("cookie.dat");
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
    }
    }

