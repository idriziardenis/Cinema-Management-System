namespace MenaxhimiKinemase
{
    partial class BookingMenu
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
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblManage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStartTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEndTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.lblHallName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMovieName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIsMaintened = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.fpnBookings = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnlCheck.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.AutoSize = true;
            this.chCheck.Location = new System.Drawing.Point(0, 10);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 14);
            this.chCheck.TabIndex = 3;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            this.chCheck.CheckedChanged += new System.EventHandler(this.chCheck_CheckedChanged);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(710, 64);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(31, 23);
            this.btnAll.TabIndex = 50;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblManage
            // 
            this.lblManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManage.AutoSize = true;
            this.lblManage.ForeColor = System.Drawing.Color.White;
            this.lblManage.Location = new System.Drawing.Point(587, 1);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(138, 38);
            this.lblManage.TabIndex = 0;
            this.lblManage.Text = "Manage";
            this.lblManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(260, 1);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(61, 38);
            this.lblStartTime.TabIndex = 23;
            this.lblStartTime.Text = "StartTime";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(328, 1);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(61, 38);
            this.lblEndTime.TabIndex = 24;
            this.lblEndTime.Text = "EndTime";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(26, 1);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 38);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSearch.Location = new System.Drawing.Point(666, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHovercolor = System.Drawing.Color.White;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete Selected",
            "Export to Excel"});
            this.cbAction.Location = new System.Drawing.Point(12, 536);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(109, 24);
            this.cbAction.TabIndex = 46;
            this.cbAction.Text = "  Choose Action";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // lblHallName
            // 
            this.lblHallName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHallName.ForeColor = System.Drawing.Color.White;
            this.lblHallName.Location = new System.Drawing.Point(182, 1);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(71, 38);
            this.lblHallName.TabIndex = 21;
            this.lblHallName.Text = "HallName";
            this.lblHallName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovieName
            // 
            this.lblMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(59, 1);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(116, 38);
            this.lblMovieName.TabIndex = 22;
            this.lblMovieName.Text = "MovieName";
            this.lblMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(396, 1);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 38);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Client Name";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsMaintened
            // 
            this.lblIsMaintened.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsMaintened.ForeColor = System.Drawing.Color.White;
            this.lblIsMaintened.Location = new System.Drawing.Point(519, 1);
            this.lblIsMaintened.Name = "lblIsMaintened";
            this.lblIsMaintened.Size = new System.Drawing.Size(61, 38);
            this.lblIsMaintened.TabIndex = 26;
            this.lblIsMaintened.Text = "Chair";
            this.lblIsMaintened.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.chCheck);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Location = new System.Drawing.Point(4, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(15, 32);
            this.pnlCheck.TabIndex = 27;
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 9;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.02F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.53F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.01F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.84F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.329999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.329999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.99F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.329999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.62F));
            this.table.Controls.Add(this.lblManage, 8, 0);
            this.table.Controls.Add(this.lblStartTime, 4, 0);
            this.table.Controls.Add(this.lblEndTime, 5, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.lblHallName, 3, 0);
            this.table.Controls.Add(this.lblMovieName, 2, 0);
            this.table.Controls.Add(this.lblDescription, 6, 0);
            this.table.Controls.Add(this.lblIsMaintened, 7, 0);
            this.table.Controls.Add(this.pnlCheck, 0, 0);
            this.table.Location = new System.Drawing.Point(12, 100);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(729, 40);
            this.table.TabIndex = 48;
            this.table.SizeChanged += new System.EventHandler(this.table_SizeChanged);
            // 
            // fpnBookings
            // 
            this.fpnBookings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnBookings.AutoScroll = true;
            this.fpnBookings.Location = new System.Drawing.Point(12, 138);
            this.fpnBookings.Margin = new System.Windows.Forms.Padding(0);
            this.fpnBookings.Name = "fpnBookings";
            this.fpnBookings.Size = new System.Drawing.Size(744, 392);
            this.fpnBookings.TabIndex = 45;
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
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(657, 36);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(769, 572);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.table);
            this.Controls.Add(this.fpnBookings);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingMenu";
            this.Text = "BookingMenu";
            this.Load += new System.EventHandler(this.BookingMenu_Load);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chCheck;
        private System.Windows.Forms.Button btnAll;
        private Bunifu.Framework.UI.BunifuCustomLabel lblManage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStartTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEndTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.ComboBox cbAction;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHallName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMovieName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIsMaintened;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.FlowLayoutPanel fpnBookings;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
    }
}