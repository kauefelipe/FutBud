namespace FutBud
{
    partial class FormRelog
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.lblRelog = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close FutBud";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRelog
            // 
            this.lblRelog.AutoSize = true;
            this.lblRelog.Location = new System.Drawing.Point(23, 60);
            this.lblRelog.Name = "lblRelog";
            this.lblRelog.Size = new System.Drawing.Size(110, 19);
            this.lblRelog.TabIndex = 1;
            this.lblRelog.Text = "Performing relog";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(23, 92);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(70, 19);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Next try in";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 500;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // FormRelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 168);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRelog);
            this.Controls.Add(this.btnClose);
            this.Name = "FormRelog";
            this.Resizable = false;
            this.Text = "FormRelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel lblRelog;
        private MetroFramework.Controls.MetroLabel lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}