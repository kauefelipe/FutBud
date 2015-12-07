namespace FutBud
{
    partial class FormSupport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupport));
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.lblRelog = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblBlaBla = new MetroFramework.Controls.MetroLabel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnThanks = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseSelectable = true;
            // 
            // lblRelog
            // 
            this.lblRelog.Location = new System.Drawing.Point(0, 0);
            this.lblRelog.Name = "lblRelog";
            this.lblRelog.Size = new System.Drawing.Size(100, 23);
            this.lblRelog.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 23);
            this.lblTimer.TabIndex = 0;
            // 
            // lblBlaBla
            // 
            this.lblBlaBla.Location = new System.Drawing.Point(23, 76);
            this.lblBlaBla.Name = "lblBlaBla";
            this.lblBlaBla.Size = new System.Drawing.Size(367, 66);
            this.lblBlaBla.TabIndex = 8;
            this.lblBlaBla.Text = "If you enjoy FutBuddy please consider to make a donation \r\nor using my G2A link t" +
    "o support the development of FutBud";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.White;
            this.btnDonate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDonate.Image = ((System.Drawing.Image)(resources.GetObject("btnDonate.Image")));
            this.btnDonate.Location = new System.Drawing.Point(23, 145);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(133, 29);
            this.btnDonate.TabIndex = 7;
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(257, 145);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(133, 29);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnThanks
            // 
            this.btnThanks.Highlight = true;
            this.btnThanks.Location = new System.Drawing.Point(162, 145);
            this.btnThanks.Name = "btnThanks";
            this.btnThanks.Size = new System.Drawing.Size(89, 29);
            this.btnThanks.TabIndex = 10;
            this.btnThanks.Text = "Thank you";
            this.btnThanks.UseSelectable = true;
            this.btnThanks.Click += new System.EventHandler(this.btnThanks_Click);
            // 
            // FormSupport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnThanks);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lblBlaBla);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRelog);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormSupport";
            this.Resizable = false;
            this.Text = "Hello :)";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel lblRelog;
        private MetroFramework.Controls.MetroLabel lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private MetroFramework.Controls.MetroLabel lblBlaBla;
        private System.Windows.Forms.Button btnDonate;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton btnThanks;
    }
}