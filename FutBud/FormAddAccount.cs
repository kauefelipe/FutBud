using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
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
    public partial class FormAddAccount : MetroForm
    {
        public FormAddAccount()
        {
            InitializeComponent();
            BringToFront();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbSecret.Text == ""|| cbPlatform.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string[] dataset = new string[4];
            dataset[0] = tbUsername.Text;
            dataset[1] = Encryption.Encrypt(tbPassword.Text);
            dataset[2] = Encryption.Encrypt(tbSecret.Text);
            dataset[3] = cbPlatform.SelectedIndex.ToString();

            var sb = new StringBuilder();
            sb.Append(string.Join(";", dataset));
            var accounts = !File.Exists("accounts.txt") ? new StreamWriter("accounts.txt") : File.AppendText("accounts.txt");
            accounts.WriteLine(sb.ToString());
            accounts.Close();
            sb.Clear();
            Close();
        }
    }
    }
    

