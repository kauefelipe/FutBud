using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace FutBud
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblCredits = new MetroFramework.Controls.MetroLabel();
            this.tcMain = new MetroFramework.Controls.MetroTabControl();
            this.tpMain = new MetroFramework.Controls.MetroTabPage();
            this.mgTable = new MetroFramework.Controls.MetroGrid();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroToggle();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.tpLog = new MetroFramework.Controls.MetroTabPage();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.tpSettings = new MetroFramework.Controls.MetroTabPage();
            this.btnSaveSettings = new MetroFramework.Controls.MetroButton();
            this.numericUpDownPricefix = new System.Windows.Forms.NumericUpDown();
            this.lblBuyRestriction = new MetroFramework.Controls.MetroLabel();
            this.trackbarChecktradepile = new MetroFramework.Controls.MetroTrackBar();
            this.tbChecktradepile = new MetroFramework.Controls.MetroTextBox();
            this.lblCheckTradepile = new MetroFramework.Controls.MetroLabel();
            this.trackbarSearch = new MetroFramework.Controls.MetroTrackBar();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.lblDebug = new MetroFramework.Controls.MetroLabel();
            this.toggleDebug = new MetroFramework.Controls.MetroToggle();
            this.tpAppearance = new MetroFramework.Controls.MetroTabPage();
            this.mtDark = new MetroFramework.Controls.MetroTile();
            this.mtLight = new MetroFramework.Controls.MetroTile();
            this.mtYellow = new MetroFramework.Controls.MetroTile();
            this.mtRed = new MetroFramework.Controls.MetroTile();
            this.mtPurple = new MetroFramework.Controls.MetroTile();
            this.mtMagenta = new MetroFramework.Controls.MetroTile();
            this.mtPink = new MetroFramework.Controls.MetroTile();
            this.mtBrown = new MetroFramework.Controls.MetroTile();
            this.mtOrange = new MetroFramework.Controls.MetroTile();
            this.mtTeal = new MetroFramework.Controls.MetroTile();
            this.mtLime = new MetroFramework.Controls.MetroTile();
            this.mtGreen = new MetroFramework.Controls.MetroTile();
            this.mtBlue = new MetroFramework.Controls.MetroTile();
            this.mtSilver = new MetroFramework.Controls.MetroTile();
            this.lblTheme = new MetroFramework.Controls.MetroLabel();
            this.lblColor = new MetroFramework.Controls.MetroLabel();
            this.tpAbout = new MetroFramework.Controls.MetroTabPage();
            this.btnCheckUpdates = new MetroFramework.Controls.MetroButton();
            this.lblLink = new MetroFramework.Controls.MetroLink();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lblDonate = new MetroFramework.Controls.MetroLabel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.psStatus = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblRuntime = new MetroFramework.Controls.MetroLabel();
            this.tmrRuntime = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.tmrSearchRequest = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tmrChecktradepile = new System.Windows.Forms.Timer(this.components);
            this.cbCheckforUpdates = new MetroFramework.Controls.MetroCheckBox();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgTable)).BeginInit();
            this.tpLog.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricefix)).BeginInit();
            this.tpAppearance.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(286, 71);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(50, 19);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits";
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpLog);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpAppearance);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Location = new System.Drawing.Point(24, 104);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 2;
            this.tcMain.Size = new System.Drawing.Size(662, 328);
            this.tcMain.TabIndex = 1;
            this.tcMain.UseSelectable = true;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.mgTable);
            this.tpMain.Controls.Add(this.btnLoad);
            this.tpMain.Controls.Add(this.btnSave);
            this.tpMain.Controls.Add(this.btnStart);
            this.tpMain.Controls.Add(this.btnAdd);
            this.tpMain.HorizontalScrollbarBarColor = true;
            this.tpMain.HorizontalScrollbarHighlightOnWheel = false;
            this.tpMain.HorizontalScrollbarSize = 10;
            this.tpMain.Location = new System.Drawing.Point(4, 38);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(654, 286);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.VerticalScrollbarBarColor = true;
            this.tpMain.VerticalScrollbarHighlightOnWheel = false;
            this.tpMain.VerticalScrollbarSize = 10;
            // 
            // mgTable
            // 
            this.mgTable.AllowUserToResizeRows = false;
            this.mgTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Column1,
            this.Buy,
            this.Sell,
            this.Counter,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ImageUrl});
            this.mgTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgTable.EnableHeadersVisualStyles = false;
            this.mgTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTable.Location = new System.Drawing.Point(3, 44);
            this.mgTable.MultiSelect = false;
            this.mgTable.Name = "mgTable";
            this.mgTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgTable.RowTemplate.Height = 40;
            this.mgTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgTable.Size = new System.Drawing.Size(651, 210);
            this.mgTable.TabIndex = 16;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Buy";
            this.Buy.Name = "Buy";
            // 
            // Sell
            // 
            this.Sell.HeaderText = "Sell";
            this.Sell.Name = "Sell";
            // 
            // Counter
            // 
            this.Counter.HeaderText = "Counter";
            this.Counter.Name = "Counter";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rarity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rating";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            // 
            // ImageUrl
            // 
            this.ImageUrl.HeaderText = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Highlight = true;
            this.btnLoad.Location = new System.Drawing.Point(575, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(490, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(0, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 17);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Aus";
            this.btnStart.UseSelectable = true;
            this.btnStart.CheckedChanged += new System.EventHandler(this.btnStart_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(3, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add player";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.btnClear);
            this.tpLog.Controls.Add(this.tbLog);
            this.tpLog.HorizontalScrollbarBarColor = true;
            this.tpLog.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLog.HorizontalScrollbarSize = 10;
            this.tpLog.Location = new System.Drawing.Point(4, 38);
            this.tpLog.Name = "tpLog";
            this.tpLog.Size = new System.Drawing.Size(654, 286);
            this.tpLog.TabIndex = 4;
            this.tpLog.Text = "Log";
            this.tpLog.VerticalScrollbarBarColor = true;
            this.tpLog.VerticalScrollbarHighlightOnWheel = false;
            this.tpLog.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.Highlight = true;
            this.btnClear.Location = new System.Drawing.Point(3, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(3, 3);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(640, 245);
            this.tbLog.TabIndex = 6;
            this.tbLog.Text = "";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.cbCheckforUpdates);
            this.tpSettings.Controls.Add(this.btnSaveSettings);
            this.tpSettings.Controls.Add(this.numericUpDownPricefix);
            this.tpSettings.Controls.Add(this.lblBuyRestriction);
            this.tpSettings.Controls.Add(this.trackbarChecktradepile);
            this.tpSettings.Controls.Add(this.tbChecktradepile);
            this.tpSettings.Controls.Add(this.lblCheckTradepile);
            this.tpSettings.Controls.Add(this.trackbarSearch);
            this.tpSettings.Controls.Add(this.tbSearch);
            this.tpSettings.Controls.Add(this.lblSearch);
            this.tpSettings.Controls.Add(this.lblDebug);
            this.tpSettings.Controls.Add(this.toggleDebug);
            this.tpSettings.HorizontalScrollbarBarColor = true;
            this.tpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettings.HorizontalScrollbarSize = 10;
            this.tpSettings.Location = new System.Drawing.Point(4, 38);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(654, 286);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.VerticalScrollbarBarColor = true;
            this.tpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettings.VerticalScrollbarSize = 10;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Highlight = true;
            this.btnSaveSettings.Location = new System.Drawing.Point(3, 252);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(79, 23);
            this.btnSaveSettings.TabIndex = 12;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // numericUpDownPricefix
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.numericUpDownPricefix, true);
            this.numericUpDownPricefix.Location = new System.Drawing.Point(253, 83);
            this.numericUpDownPricefix.Name = "numericUpDownPricefix";
            this.numericUpDownPricefix.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownPricefix.TabIndex = 11;
            this.numericUpDownPricefix.ValueChanged += new System.EventHandler(this.numericUpDownPricefix_ValueChanged);
            // 
            // lblBuyRestriction
            // 
            this.lblBuyRestriction.AutoSize = true;
            this.lblBuyRestriction.Location = new System.Drawing.Point(0, 83);
            this.lblBuyRestriction.Name = "lblBuyRestriction";
            this.lblBuyRestriction.Size = new System.Drawing.Size(241, 19);
            this.lblBuyRestriction.TabIndex = 10;
            this.lblBuyRestriction.Text = "Only buy if less than x players are found";
            // 
            // trackbarChecktradepile
            // 
            this.trackbarChecktradepile.BackColor = System.Drawing.Color.Transparent;
            this.trackbarChecktradepile.LargeChange = 100;
            this.trackbarChecktradepile.Location = new System.Drawing.Point(253, 48);
            this.trackbarChecktradepile.Maximum = 300000;
            this.trackbarChecktradepile.Minimum = 10000;
            this.trackbarChecktradepile.MouseWheelBarPartitions = 100;
            this.trackbarChecktradepile.Name = "trackbarChecktradepile";
            this.trackbarChecktradepile.Size = new System.Drawing.Size(75, 23);
            this.trackbarChecktradepile.SmallChange = 100;
            this.trackbarChecktradepile.TabIndex = 9;
            this.trackbarChecktradepile.Value = 60000;
            this.trackbarChecktradepile.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbarChecktradepile_Scroll);
            // 
            // tbChecktradepile
            // 
            // 
            // 
            // 
            this.tbChecktradepile.CustomButton.Image = null;
            this.tbChecktradepile.CustomButton.Location = new System.Drawing.Point(22, 1);
            this.tbChecktradepile.CustomButton.Name = "";
            this.tbChecktradepile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbChecktradepile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbChecktradepile.CustomButton.TabIndex = 1;
            this.tbChecktradepile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbChecktradepile.CustomButton.UseSelectable = true;
            this.tbChecktradepile.CustomButton.Visible = false;
            this.tbChecktradepile.Lines = new string[0];
            this.tbChecktradepile.Location = new System.Drawing.Point(203, 48);
            this.tbChecktradepile.MaxLength = 32767;
            this.tbChecktradepile.Name = "tbChecktradepile";
            this.tbChecktradepile.PasswordChar = '\0';
            this.tbChecktradepile.ReadOnly = true;
            this.tbChecktradepile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChecktradepile.SelectedText = "";
            this.tbChecktradepile.SelectionLength = 0;
            this.tbChecktradepile.SelectionStart = 0;
            this.tbChecktradepile.Size = new System.Drawing.Size(44, 23);
            this.tbChecktradepile.TabIndex = 8;
            this.tbChecktradepile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChecktradepile.UseSelectable = true;
            this.tbChecktradepile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChecktradepile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCheckTradepile
            // 
            this.lblCheckTradepile.AutoSize = true;
            this.lblCheckTradepile.Location = new System.Drawing.Point(0, 48);
            this.lblCheckTradepile.Name = "lblCheckTradepile";
            this.lblCheckTradepile.Size = new System.Drawing.Size(197, 19);
            this.lblCheckTradepile.TabIndex = 7;
            this.lblCheckTradepile.Text = "Check Tradepile every x seconds";
            // 
            // trackbarSearch
            // 
            this.trackbarSearch.BackColor = System.Drawing.Color.Transparent;
            this.trackbarSearch.LargeChange = 100;
            this.trackbarSearch.Location = new System.Drawing.Point(253, 11);
            this.trackbarSearch.Maximum = 10000;
            this.trackbarSearch.Minimum = 100;
            this.trackbarSearch.MouseWheelBarPartitions = 100;
            this.trackbarSearch.Name = "trackbarSearch";
            this.trackbarSearch.Size = new System.Drawing.Size(75, 23);
            this.trackbarSearch.SmallChange = 100;
            this.trackbarSearch.TabIndex = 6;
            this.trackbarSearch.Value = 2000;
            this.trackbarSearch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbarSearch_Scroll);
            // 
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(22, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(203, 13);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ReadOnly = true;
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.Size = new System.Drawing.Size(44, 23);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(0, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(144, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search every x seconds";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(603, 258);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(48, 19);
            this.lblDebug.TabIndex = 3;
            this.lblDebug.Text = "Debug";
            // 
            // toggleDebug
            // 
            this.toggleDebug.AutoSize = true;
            this.toggleDebug.Location = new System.Drawing.Point(517, 258);
            this.toggleDebug.Name = "toggleDebug";
            this.toggleDebug.Size = new System.Drawing.Size(80, 17);
            this.toggleDebug.TabIndex = 2;
            this.toggleDebug.Text = "Aus";
            this.toggleDebug.UseSelectable = true;
            this.toggleDebug.CheckedChanged += new System.EventHandler(this.toggleDebug_CheckedChanged);
            // 
            // tpAppearance
            // 
            this.tpAppearance.Controls.Add(this.mtDark);
            this.tpAppearance.Controls.Add(this.mtLight);
            this.tpAppearance.Controls.Add(this.mtYellow);
            this.tpAppearance.Controls.Add(this.mtRed);
            this.tpAppearance.Controls.Add(this.mtPurple);
            this.tpAppearance.Controls.Add(this.mtMagenta);
            this.tpAppearance.Controls.Add(this.mtPink);
            this.tpAppearance.Controls.Add(this.mtBrown);
            this.tpAppearance.Controls.Add(this.mtOrange);
            this.tpAppearance.Controls.Add(this.mtTeal);
            this.tpAppearance.Controls.Add(this.mtLime);
            this.tpAppearance.Controls.Add(this.mtGreen);
            this.tpAppearance.Controls.Add(this.mtBlue);
            this.tpAppearance.Controls.Add(this.mtSilver);
            this.tpAppearance.Controls.Add(this.lblTheme);
            this.tpAppearance.Controls.Add(this.lblColor);
            this.tpAppearance.HorizontalScrollbarBarColor = true;
            this.tpAppearance.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppearance.HorizontalScrollbarSize = 10;
            this.tpAppearance.Location = new System.Drawing.Point(4, 38);
            this.tpAppearance.Name = "tpAppearance";
            this.tpAppearance.Size = new System.Drawing.Size(654, 286);
            this.tpAppearance.TabIndex = 2;
            this.tpAppearance.Text = "Appearance";
            this.tpAppearance.VerticalScrollbarBarColor = true;
            this.tpAppearance.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppearance.VerticalScrollbarSize = 10;
            // 
            // mtDark
            // 
            this.mtDark.ActiveControl = null;
            this.mtDark.Location = new System.Drawing.Point(102, 213);
            this.mtDark.Name = "mtDark";
            this.mtDark.Size = new System.Drawing.Size(92, 70);
            this.mtDark.TabIndex = 17;
            this.mtDark.Text = "Dark";
            this.mtDark.UseSelectable = true;
            this.mtDark.Click += new System.EventHandler(this.mtDark_Click);
            // 
            // mtLight
            // 
            this.mtLight.ActiveControl = null;
            this.mtLight.Location = new System.Drawing.Point(4, 213);
            this.mtLight.Name = "mtLight";
            this.mtLight.Size = new System.Drawing.Size(92, 70);
            this.mtLight.TabIndex = 16;
            this.mtLight.Text = "Light";
            this.mtLight.UseSelectable = true;
            this.mtLight.Click += new System.EventHandler(this.mtLight_Click);
            // 
            // mtYellow
            // 
            this.mtYellow.ActiveControl = null;
            this.mtYellow.Location = new System.Drawing.Point(494, 110);
            this.mtYellow.Name = "mtYellow";
            this.mtYellow.Size = new System.Drawing.Size(92, 78);
            this.mtYellow.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtYellow.TabIndex = 15;
            this.mtYellow.Text = "Yellow";
            this.mtYellow.UseSelectable = true;
            this.mtYellow.Click += new System.EventHandler(this.mtYellow_Click);
            // 
            // mtRed
            // 
            this.mtRed.ActiveControl = null;
            this.mtRed.Location = new System.Drawing.Point(396, 110);
            this.mtRed.Name = "mtRed";
            this.mtRed.Size = new System.Drawing.Size(92, 78);
            this.mtRed.Style = MetroFramework.MetroColorStyle.Red;
            this.mtRed.TabIndex = 14;
            this.mtRed.Text = "Red";
            this.mtRed.UseSelectable = true;
            this.mtRed.Click += new System.EventHandler(this.mtRed_Click);
            // 
            // mtPurple
            // 
            this.mtPurple.ActiveControl = null;
            this.mtPurple.Location = new System.Drawing.Point(298, 110);
            this.mtPurple.Name = "mtPurple";
            this.mtPurple.Size = new System.Drawing.Size(92, 78);
            this.mtPurple.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtPurple.TabIndex = 13;
            this.mtPurple.Text = "Purple";
            this.mtPurple.UseSelectable = true;
            this.mtPurple.Click += new System.EventHandler(this.mtPurple_Click);
            // 
            // mtMagenta
            // 
            this.mtMagenta.ActiveControl = null;
            this.mtMagenta.Location = new System.Drawing.Point(200, 110);
            this.mtMagenta.Name = "mtMagenta";
            this.mtMagenta.Size = new System.Drawing.Size(92, 78);
            this.mtMagenta.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtMagenta.TabIndex = 12;
            this.mtMagenta.Text = "Magenta";
            this.mtMagenta.UseSelectable = true;
            this.mtMagenta.Click += new System.EventHandler(this.mtMagenta_Click);
            // 
            // mtPink
            // 
            this.mtPink.ActiveControl = null;
            this.mtPink.Location = new System.Drawing.Point(102, 110);
            this.mtPink.Name = "mtPink";
            this.mtPink.Size = new System.Drawing.Size(92, 78);
            this.mtPink.Style = MetroFramework.MetroColorStyle.Pink;
            this.mtPink.TabIndex = 11;
            this.mtPink.Text = "Pink";
            this.mtPink.UseSelectable = true;
            this.mtPink.Click += new System.EventHandler(this.mtPink_Click);
            // 
            // mtBrown
            // 
            this.mtBrown.ActiveControl = null;
            this.mtBrown.Location = new System.Drawing.Point(4, 110);
            this.mtBrown.Name = "mtBrown";
            this.mtBrown.Size = new System.Drawing.Size(92, 78);
            this.mtBrown.Style = MetroFramework.MetroColorStyle.Brown;
            this.mtBrown.TabIndex = 10;
            this.mtBrown.Text = "Brown";
            this.mtBrown.UseSelectable = true;
            this.mtBrown.Click += new System.EventHandler(this.mtBrown_Click);
            // 
            // mtOrange
            // 
            this.mtOrange.ActiveControl = null;
            this.mtOrange.Location = new System.Drawing.Point(494, 26);
            this.mtOrange.Name = "mtOrange";
            this.mtOrange.Size = new System.Drawing.Size(92, 78);
            this.mtOrange.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOrange.TabIndex = 9;
            this.mtOrange.Text = "Orange";
            this.mtOrange.UseSelectable = true;
            this.mtOrange.Click += new System.EventHandler(this.mtOrange_Click);
            // 
            // mtTeal
            // 
            this.mtTeal.ActiveControl = null;
            this.mtTeal.Location = new System.Drawing.Point(396, 26);
            this.mtTeal.Name = "mtTeal";
            this.mtTeal.Size = new System.Drawing.Size(92, 78);
            this.mtTeal.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtTeal.TabIndex = 8;
            this.mtTeal.Text = "Teal";
            this.mtTeal.UseSelectable = true;
            this.mtTeal.Click += new System.EventHandler(this.mtTeal_Click);
            // 
            // mtLime
            // 
            this.mtLime.ActiveControl = null;
            this.mtLime.Location = new System.Drawing.Point(298, 26);
            this.mtLime.Name = "mtLime";
            this.mtLime.Size = new System.Drawing.Size(92, 78);
            this.mtLime.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtLime.TabIndex = 7;
            this.mtLime.Text = "Lime";
            this.mtLime.UseSelectable = true;
            this.mtLime.Click += new System.EventHandler(this.mtLime_Click);
            // 
            // mtGreen
            // 
            this.mtGreen.ActiveControl = null;
            this.mtGreen.Location = new System.Drawing.Point(200, 26);
            this.mtGreen.Name = "mtGreen";
            this.mtGreen.Size = new System.Drawing.Size(92, 78);
            this.mtGreen.Style = MetroFramework.MetroColorStyle.Green;
            this.mtGreen.TabIndex = 6;
            this.mtGreen.Text = "Green";
            this.mtGreen.UseSelectable = true;
            this.mtGreen.Click += new System.EventHandler(this.mtGreen_Click);
            // 
            // mtBlue
            // 
            this.mtBlue.ActiveControl = null;
            this.mtBlue.Location = new System.Drawing.Point(102, 26);
            this.mtBlue.Name = "mtBlue";
            this.mtBlue.Size = new System.Drawing.Size(92, 78);
            this.mtBlue.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBlue.TabIndex = 5;
            this.mtBlue.Text = "Blue";
            this.mtBlue.UseSelectable = true;
            this.mtBlue.Click += new System.EventHandler(this.mtBlue_Click);
            // 
            // mtSilver
            // 
            this.mtSilver.ActiveControl = null;
            this.mtSilver.Location = new System.Drawing.Point(4, 26);
            this.mtSilver.Name = "mtSilver";
            this.mtSilver.Size = new System.Drawing.Size(92, 78);
            this.mtSilver.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtSilver.TabIndex = 4;
            this.mtSilver.Text = "Silver";
            this.mtSilver.UseSelectable = true;
            this.mtSilver.Click += new System.EventHandler(this.mtSilver_Click);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(4, 191);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(49, 19);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Theme";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(4, 4);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 19);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.btnCheckUpdates);
            this.tpAbout.Controls.Add(this.lblLink);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.lblDonate);
            this.tpAbout.Controls.Add(this.btnDonate);
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            this.tpAbout.Location = new System.Drawing.Point(4, 38);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(654, 286);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Highlight = true;
            this.btnCheckUpdates.Location = new System.Drawing.Point(34, 82);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(101, 19);
            this.btnCheckUpdates.TabIndex = 12;
            this.btnCheckUpdates.Text = "Check for updates";
            this.btnCheckUpdates.UseSelectable = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // lblLink
            // 
            this.lblLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblLink.Location = new System.Drawing.Point(34, 18);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(180, 39);
            this.lblLink.TabIndex = 11;
            this.lblLink.Text = "FutBud Homepage";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLink.UseSelectable = true;
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(34, 60);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(90, 19);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version 1.0.0.0";
            // 
            // lblDonate
            // 
            this.lblDonate.AutoSize = true;
            this.lblDonate.Location = new System.Drawing.Point(34, 154);
            this.lblDonate.Name = "lblDonate";
            this.lblDonate.Size = new System.Drawing.Size(355, 57);
            this.lblDonate.TabIndex = 6;
            this.lblDonate.Text = "\r\nI hope you enjoy FutBuddy. Feel free to donate via PayPal :)\r\n";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.White;
            this.btnDonate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDonate.Image = ((System.Drawing.Image)(resources.GetObject("btnDonate.Image")));
            this.btnDonate.Location = new System.Drawing.Point(34, 214);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(147, 29);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: Paused";
            // 
            // psStatus
            // 
            this.psStatus.Location = new System.Drawing.Point(138, 63);
            this.psStatus.Maximum = 100;
            this.psStatus.Name = "psStatus";
            this.psStatus.Size = new System.Drawing.Size(46, 35);
            this.psStatus.Speed = 0.2F;
            this.psStatus.Spinning = false;
            this.psStatus.TabIndex = 3;
            this.psStatus.UseSelectable = true;
            this.psStatus.Value = 20;
            // 
            // lblRuntime
            // 
            this.lblRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(545, 71);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(129, 19);
            this.lblRuntime.TabIndex = 4;
            this.lblRuntime.Text = "Runtime: 00:00:00:00";
            // 
            // tmrRuntime
            // 
            this.tmrRuntime.Enabled = true;
            this.tmrRuntime.Interval = 1000;
            this.tmrRuntime.Tick += new System.EventHandler(this.tmrRuntime_Tick);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // tmrSearchRequest
            // 
            this.tmrSearchRequest.Interval = 2000;
            this.tmrSearchRequest.Tick += new System.EventHandler(this.tmrRequest_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = ".csv|*.csv";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = ".csv|*.csv";
            // 
            // tmrChecktradepile
            // 
            this.tmrChecktradepile.Interval = 60000;
            this.tmrChecktradepile.Tick += new System.EventHandler(this.tmrChecktradepile_Tick);
            // 
            // cbCheckforUpdates
            // 
            this.cbCheckforUpdates.AutoSize = true;
            this.cbCheckforUpdates.Location = new System.Drawing.Point(3, 221);
            this.cbCheckforUpdates.Name = "cbCheckforUpdates";
            this.cbCheckforUpdates.Size = new System.Drawing.Size(176, 15);
            this.cbCheckforUpdates.TabIndex = 14;
            this.cbCheckforUpdates.Text = "Check for updates on startup";
            this.cbCheckforUpdates.UseSelectable = true;
            this.cbCheckforUpdates.CheckedChanged += new System.EventHandler(this.cbCheckforUpdates_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(702, 442);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.psStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblCredits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "FutBud";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgTable)).EndInit();
            this.tpLog.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricefix)).EndInit();
            this.tpAppearance.ResumeLayout(false);
            this.tpAppearance.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel lblCredits;
        private MetroTabControl tcMain;
        private MetroTabPage tpMain;
        private MetroTabPage tpSettings;
        private MetroLabel lblStatus;
        private MetroProgressSpinner psStatus;
        private MetroLabel lblRuntime;
        private Timer tmrRuntime;
        private MetroTabPage tpAppearance;
        private MetroTile mtDark;
        private MetroTile mtLight;
        private MetroTile mtYellow;
        private MetroTile mtRed;
        private MetroTile mtPurple;
        private MetroTile mtMagenta;
        private MetroTile mtPink;
        private MetroTile mtBrown;
        private MetroTile mtOrange;
        private MetroTile mtTeal;
        private MetroTile mtLime;
        private MetroTile mtGreen;
        private MetroTile mtBlue;
        private MetroTile mtSilver;
        private MetroLabel lblTheme;
        private MetroLabel lblColor;
        private MetroStyleExtender metroStyleExtender;
        private MetroStyleManager metroStyleManager;
        private MetroButton btnAdd;
        private MetroToggle btnStart;
        private RichTextBox tbLog;
        private MetroLabel lblDebug;
        private MetroToggle toggleDebug;
        private Timer tmrSearchRequest;
        private MetroButton btnLoad;
        private MetroButton btnSave;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private MetroTrackBar trackbarSearch;
        private MetroTextBox tbSearch;
        private MetroLabel lblSearch;
        private MetroTrackBar trackbarChecktradepile;
        private MetroTextBox tbChecktradepile;
        private MetroLabel lblCheckTradepile;
        private Timer tmrChecktradepile;
        private NumericUpDown numericUpDownPricefix;
        private MetroLabel lblBuyRestriction;
        private Button btnDonate;
        private MetroLabel lblDonate;
        private MetroLabel lblVersion;
        private MetroLink lblLink;
        private MetroTabPage tpLog;
        private MetroTabPage tpAbout;
        private MetroButton btnClear;
        private MetroButton btnSaveSettings;
        private MetroGrid mgTable;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Buy;
        private DataGridViewTextBoxColumn Sell;
        private DataGridViewTextBoxColumn Counter;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn ImageUrl;
        private MetroButton btnCheckUpdates;
        private MetroCheckBox cbCheckforUpdates;
    }
}