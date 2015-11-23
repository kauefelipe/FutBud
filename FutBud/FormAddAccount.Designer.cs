using System.ComponentModel;
using MetroFramework.Controls;

namespace FutBud
{
    partial class FormAddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAccount));
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbSecret = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblSecret = new MetroFramework.Controls.MetroLabel();
            this.cbPlatform = new MetroFramework.Controls.MetroComboBox();
            this.lblPlatform = new MetroFramework.Controls.MetroLabel();
            this.btnAddAccount = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(23, 63);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.Size = new System.Drawing.Size(155, 23);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(23, 92);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(155, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSecret
            // 
            // 
            // 
            // 
            this.tbSecret.CustomButton.Image = null;
            this.tbSecret.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbSecret.CustomButton.Name = "";
            this.tbSecret.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSecret.CustomButton.TabIndex = 1;
            this.tbSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSecret.CustomButton.UseSelectable = true;
            this.tbSecret.CustomButton.Visible = false;
            this.tbSecret.Lines = new string[0];
            this.tbSecret.Location = new System.Drawing.Point(23, 121);
            this.tbSecret.MaxLength = 32767;
            this.tbSecret.Name = "tbSecret";
            this.tbSecret.PasswordChar = '*';
            this.tbSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSecret.SelectedText = "";
            this.tbSecret.SelectionLength = 0;
            this.tbSecret.SelectionStart = 0;
            this.tbSecret.Size = new System.Drawing.Size(155, 23);
            this.tbSecret.TabIndex = 2;
            this.tbSecret.UseSelectable = true;
            this.tbSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(185, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(185, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(185, 121);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(87, 19);
            this.lblSecret.TabIndex = 5;
            this.lblSecret.Text = "SecretAnswer";
            // 
            // cbPlatform
            // 
            this.cbPlatform.FormattingEnabled = true;
            this.cbPlatform.ItemHeight = 23;
            this.cbPlatform.Items.AddRange(new object[] {
            "PC",
            "PS3",
            "PS4",
            "XBox360",
            "XBoxOne"});
            this.cbPlatform.Location = new System.Drawing.Point(23, 150);
            this.cbPlatform.Name = "cbPlatform";
            this.cbPlatform.Size = new System.Drawing.Size(155, 29);
            this.cbPlatform.TabIndex = 8;
            this.cbPlatform.UseSelectable = true;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(185, 150);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(60, 19);
            this.lblPlatform.TabIndex = 9;
            this.lblPlatform.Text = "Platform";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(23, 198);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(155, 23);
            this.btnAddAccount.TabIndex = 15;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseSelectable = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 248);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.cbPlatform);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbSecret);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddAccount";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Add Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroTextBox tbUsername;
        private MetroTextBox tbPassword;
        private MetroTextBox tbSecret;
        private MetroLabel lblUsername;
        private MetroLabel lblPassword;
        private MetroLabel lblSecret;
        private MetroComboBox cbPlatform;
        private MetroLabel lblPlatform;
        private MetroButton btnAddAccount;
    }
}

