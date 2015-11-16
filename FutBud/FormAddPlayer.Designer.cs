using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace FutBud
{
    partial class FormAddPlayer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPlayer));
            this.lblPlayerName = new MetroFramework.Controls.MetroLabel();
            this.tbPlayerName = new MetroFramework.Controls.MetroTextBox();
            this.lblBuyPrice = new MetroFramework.Controls.MetroLabel();
            this.tbPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.lblSellPrice = new MetroFramework.Controls.MetroLabel();
            this.tbSellPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.mgTable = new MetroFramework.Controls.MetroGrid();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(185, 64);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(45, 19);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Name";
            // 
            // tbPlayerName
            // 
            // 
            // 
            // 
            this.tbPlayerName.CustomButton.Image = null;
            this.tbPlayerName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbPlayerName.CustomButton.Name = "";
            this.tbPlayerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPlayerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlayerName.CustomButton.TabIndex = 1;
            this.tbPlayerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlayerName.CustomButton.UseSelectable = true;
            this.tbPlayerName.CustomButton.Visible = false;
            this.tbPlayerName.Lines = new string[0];
            this.tbPlayerName.Location = new System.Drawing.Point(23, 64);
            this.tbPlayerName.MaxLength = 32767;
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.PasswordChar = '\0';
            this.tbPlayerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlayerName.SelectedText = "";
            this.tbPlayerName.SelectionLength = 0;
            this.tbPlayerName.SelectionStart = 0;
            this.tbPlayerName.Size = new System.Drawing.Size(155, 23);
            this.tbPlayerName.TabIndex = 4;
            this.tbPlayerName.UseSelectable = true;
            this.tbPlayerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlayerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPlayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPlayerName_KeyDown);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(184, 268);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(94, 19);
            this.lblBuyPrice.TabIndex = 7;
            this.lblBuyPrice.Text = "Purchase price";
            // 
            // tbPurchasePrice
            // 
            // 
            // 
            // 
            this.tbPurchasePrice.CustomButton.Image = null;
            this.tbPurchasePrice.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbPurchasePrice.CustomButton.Name = "";
            this.tbPurchasePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPurchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPurchasePrice.CustomButton.TabIndex = 1;
            this.tbPurchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPurchasePrice.CustomButton.UseSelectable = true;
            this.tbPurchasePrice.CustomButton.Visible = false;
            this.tbPurchasePrice.Lines = new string[0];
            this.tbPurchasePrice.Location = new System.Drawing.Point(23, 268);
            this.tbPurchasePrice.MaxLength = 32767;
            this.tbPurchasePrice.Name = "tbPurchasePrice";
            this.tbPurchasePrice.PasswordChar = '\0';
            this.tbPurchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPurchasePrice.SelectedText = "";
            this.tbPurchasePrice.SelectionLength = 0;
            this.tbPurchasePrice.SelectionStart = 0;
            this.tbPurchasePrice.Size = new System.Drawing.Size(155, 23);
            this.tbPurchasePrice.TabIndex = 6;
            this.tbPurchasePrice.UseSelectable = true;
            this.tbPurchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(445, 268);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(62, 19);
            this.lblSellPrice.TabIndex = 9;
            this.lblSellPrice.Text = "Sell price";
            // 
            // tbSellPrice
            // 
            // 
            // 
            // 
            this.tbSellPrice.CustomButton.Image = null;
            this.tbSellPrice.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tbSellPrice.CustomButton.Name = "";
            this.tbSellPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSellPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSellPrice.CustomButton.TabIndex = 1;
            this.tbSellPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSellPrice.CustomButton.UseSelectable = true;
            this.tbSellPrice.CustomButton.Visible = false;
            this.tbSellPrice.Lines = new string[0];
            this.tbSellPrice.Location = new System.Drawing.Point(284, 268);
            this.tbSellPrice.MaxLength = 32767;
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.PasswordChar = '\0';
            this.tbSellPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSellPrice.SelectedText = "";
            this.tbSellPrice.SelectionLength = 0;
            this.tbSellPrice.SelectionStart = 0;
            this.tbSellPrice.Size = new System.Drawing.Size(155, 23);
            this.tbSellPrice.TabIndex = 8;
            this.tbSellPrice.UseSelectable = true;
            this.tbSellPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSellPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOK
            // 
            this.btnOK.Highlight = true;
            this.btnOK.Location = new System.Drawing.Point(23, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(104, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // btnSearch
            // 
            this.btnSearch.Highlight = true;
            this.btnSearch.Location = new System.Drawing.Point(245, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mgTable
            // 
            this.mgTable.AllowUserToResizeRows = false;
            this.mgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ImageUrl});
            this.mgTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgTable.EnableHeadersVisualStyles = false;
            this.mgTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTable.Location = new System.Drawing.Point(23, 108);
            this.mgTable.Name = "mgTable";
            this.mgTable.ReadOnly = true;
            this.mgTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgTable.RowTemplate.Height = 40;
            this.mgTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgTable.Size = new System.Drawing.Size(639, 154);
            this.mgTable.TabIndex = 15;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rarity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rating";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ImageUrl
            // 
            this.ImageUrl.HeaderText = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.ReadOnly = true;
            this.ImageUrl.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(23, 90);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 16;
            this.lblResults.Text = "Results:";
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 328);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.mgTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.tbSellPrice);
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.tbPurchasePrice);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPlayer";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Add player";
            this.Load += new System.EventHandler(this.FormAddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel lblPlayerName;
        private MetroTextBox tbPlayerName;
        private MetroLabel lblBuyPrice;
        private MetroTextBox tbPurchasePrice;
        private MetroLabel lblSellPrice;
        private MetroTextBox tbSellPrice;
        private MetroButton btnOK;
        private MetroButton btnCancel;
        private MetroStyleManager metroStyleManager;
        private MetroButton btnSearch;
        private Label lblResults;
        private MetroGrid mgTable;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn ImageUrl;
    }
}