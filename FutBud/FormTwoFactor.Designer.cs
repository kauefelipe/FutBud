using System.ComponentModel;
using MetroFramework.Controls;

namespace FutBud
{
    partial class TwoFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoFactor));
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.tbCode = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(233, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Check your Email for the security code";
            // 
            // tbCode
            // 
            // 
            // 
            // 
            this.tbCode.CustomButton.Image = null;
            this.tbCode.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.tbCode.CustomButton.Name = "";
            this.tbCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCode.CustomButton.TabIndex = 1;
            this.tbCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCode.CustomButton.UseSelectable = true;
            this.tbCode.CustomButton.Visible = false;
            this.tbCode.Lines = new string[0];
            this.tbCode.Location = new System.Drawing.Point(24, 83);
            this.tbCode.MaxLength = 32767;
            this.tbCode.Name = "tbCode";
            this.tbCode.PasswordChar = '\0';
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCode.SelectedText = "";
            this.tbCode.SelectionLength = 0;
            this.tbCode.SelectionStart = 0;
            this.tbCode.Size = new System.Drawing.Size(269, 23);
            this.tbCode.TabIndex = 1;
            this.tbCode.UseSelectable = true;
            this.tbCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(23, 112);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TwoFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 163);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwoFactor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "TwoFactor";
            this.Load += new System.EventHandler(this.FormTwoFactor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel lblDescription;
        private MetroTextBox tbCode;
        private MetroButton btnSubmit;
    }
}