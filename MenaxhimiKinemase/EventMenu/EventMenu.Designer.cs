namespace MenaxhimiKinemase
{
    partial class EventMenu
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
            this.fpnEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddEvent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEventType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSales = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.lblEventID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEventTittle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnYearly = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnEvents
            // 
            this.fpnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnEvents.AutoScroll = true;
            this.fpnEvents.Location = new System.Drawing.Point(12, 138);
            this.fpnEvents.Name = "fpnEvents";
            this.fpnEvents.Size = new System.Drawing.Size(560, 296);
            this.fpnEvents.TabIndex = 29;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColorFocused = System.Drawing.Color.White;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtSearch.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtSearch.BorderThickness = 3;
            this.txtSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.isPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(180, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 36);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Active = false;
            this.btnAddEvent.Activecolor = System.Drawing.Color.White;
            this.btnAddEvent.BackColor = System.Drawing.Color.Gray;
            this.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEvent.BorderRadius = 0;
            this.btnAddEvent.ButtonText = "+ Add Event";
            this.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEvent.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddEvent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddEvent.Iconimage = null;
            this.btnAddEvent.Iconimage_right = null;
            this.btnAddEvent.Iconimage_right_Selected = null;
            this.btnAddEvent.Iconimage_Selected = null;
            this.btnAddEvent.IconMarginLeft = 0;
            this.btnAddEvent.IconMarginRight = 0;
            this.btnAddEvent.IconRightVisible = true;
            this.btnAddEvent.IconRightZoom = 0D;
            this.btnAddEvent.IconVisible = true;
            this.btnAddEvent.IconZoom = 90D;
            this.btnAddEvent.IsTab = false;
            this.btnAddEvent.Location = new System.Drawing.Point(12, 17);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddEvent.OnHovercolor = System.Drawing.Color.White;
            this.btnAddEvent.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddEvent.selected = false;
            this.btnAddEvent.Size = new System.Drawing.Size(161, 34);
            this.btnAddEvent.TabIndex = 25;
            this.btnAddEvent.Text = "+ Add Event";
            this.btnAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddEvent.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEvent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.White;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(474, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHovercolor = System.Drawing.Color.White;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(76, 34);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete Selected",
            "Export to Excel"});
            this.cbAction.Location = new System.Drawing.Point(12, 452);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(100, 21);
            this.cbAction.TabIndex = 36;
            this.cbAction.Text = "  Choose Action";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 8;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.089219F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.736058F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.61338F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.51673F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.736058F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.19703F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.26766F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.84386F));
            this.table.Controls.Add(this.bunifuCustomLabel1, 7, 0);
            this.table.Controls.Add(this.lblEventType, 5, 0);
            this.table.Controls.Add(this.lblSales, 4, 0);
            this.table.Controls.Add(this.panel1, 0, 0);
            this.table.Controls.Add(this.lblEventID, 1, 0);
            this.table.Controls.Add(this.btnImage, 3, 0);
            this.table.Controls.Add(this.lblEventTittle, 2, 0);
            this.table.Controls.Add(this.lblDuration, 6, 0);
            this.table.Location = new System.Drawing.Point(12, 102);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.table.Size = new System.Drawing.Size(538, 38);
            this.table.TabIndex = 38;
            this.table.SizeChanged += new System.EventHandler(this.table_SizeChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(442, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 36);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Manage";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventType
            // 
            this.lblEventType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventType.ForeColor = System.Drawing.Color.White;
            this.lblEventType.Location = new System.Drawing.Point(307, 1);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(63, 36);
            this.lblEventType.TabIndex = 20;
            this.lblEventType.Text = "Type";
            this.lblEventType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSales
            // 
            this.lblSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSales.ForeColor = System.Drawing.Color.White;
            this.lblSales.Location = new System.Drawing.Point(260, 1);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(40, 36);
            this.lblSales.TabIndex = 19;
            this.lblSales.Text = "Sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 30);
            this.panel1.TabIndex = 0;
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.AutoSize = true;
            this.chCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.Location = new System.Drawing.Point(0, 8);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 14);
            this.chCheck.TabIndex = 3;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            this.chCheck.CheckedChanged += new System.EventHandler(this.chCheck_CheckedChanged);
            // 
            // lblEventID
            // 
            this.lblEventID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventID.ForeColor = System.Drawing.Color.White;
            this.lblEventID.Location = new System.Drawing.Point(26, 1);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(40, 36);
            this.lblEventID.TabIndex = 16;
            this.lblEventID.Text = "ID";
            this.lblEventID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(156, 1);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(97, 36);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Image";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventTittle
            // 
            this.lblEventTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventTittle.ForeColor = System.Drawing.Color.White;
            this.lblEventTittle.Location = new System.Drawing.Point(73, 1);
            this.lblEventTittle.Name = "lblEventTittle";
            this.lblEventTittle.Size = new System.Drawing.Size(76, 36);
            this.lblEventTittle.TabIndex = 17;
            this.lblEventTittle.Text = "Title";
            this.lblEventTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(377, 1);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(58, 36);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYearly
            // 
            this.btnYearly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYearly.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearly.Location = new System.Drawing.Point(501, 67);
            this.btnYearly.Name = "btnYearly";
            this.btnYearly.Size = new System.Drawing.Size(49, 23);
            this.btnYearly.TabIndex = 41;
            this.btnYearly.Text = "Yearly";
            this.btnYearly.UseVisualStyleBackColor = true;
            this.btnYearly.Click += new System.EventHandler(this.btnYearly_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(280, 67);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(27, 23);
            this.btnAll.TabIndex = 40;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonthly.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(428, 67);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(67, 23);
            this.btnMonthly.TabIndex = 39;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(313, 67);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(45, 23);
            this.btnDaily.TabIndex = 42;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeekly.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(364, 67);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(58, 23);
            this.btnWeekly.TabIndex = 43;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // EventMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(575, 485);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.btnYearly);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.table);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.fpnEvents);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEvent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventMenu";
            this.Text = "EventMenu";
            this.Load += new System.EventHandler(this.EventMenu_Load);
            this.table.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpnEvents;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddEvent;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.TableLayoutPanel table;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSales;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventTittle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chCheck;
        private System.Windows.Forms.Button btnYearly;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnWeekly;
        private Bunifu.Framework.UI.BunifuCustomLabel btnImage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDuration;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}