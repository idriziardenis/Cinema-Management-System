namespace MenaxhimiKinemase
{
    partial class Movies
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbMoviePhoto = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCB = new System.Windows.Forms.Panel();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.lblMinimumAge = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrailer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblReleaseDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.fpnMovies = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).BeginInit();
            this.table.SuspendLayout();
            this.pnlCB.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "+ Add Movie";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 21);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(161, 34);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "+ Add Movie";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
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
            this.txtSearch.Location = new System.Drawing.Point(180, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(673, 36);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete Selected",
            "Export to Excel"});
            this.cbAction.Location = new System.Drawing.Point(12, 539);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(107, 24);
            this.cbAction.TabIndex = 17;
            this.cbAction.Text = "  Choose Action";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged_1);
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
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSearch.Location = new System.Drawing.Point(851, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHovercolor = System.Drawing.Color.White;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(87, 34);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // pbMoviePhoto
            // 
            this.pbMoviePhoto.Location = new System.Drawing.Point(134, 4);
            this.pbMoviePhoto.Name = "pbMoviePhoto";
            this.pbMoviePhoto.Size = new System.Drawing.Size(100, 92);
            this.pbMoviePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoviePhoto.TabIndex = 4;
            this.pbMoviePhoto.TabStop = false;
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSize = true;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 13;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.36F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.43F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.149999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.47F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.989999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.289999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.149999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.289999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.039999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.789999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.11F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.249999F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.68F));
            this.table.Controls.Add(this.pnlCB, 0, 0);
            this.table.Controls.Add(this.lblMinimumAge, 10, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.pnButtons, 12, 0);
            this.table.Controls.Add(this.bunifuCustomLabel2, 3, 0);
            this.table.Controls.Add(this.lblTitle, 2, 0);
            this.table.Controls.Add(this.lblDescription, 4, 0);
            this.table.Controls.Add(this.bunifuCustomLabel3, 5, 0);
            this.table.Controls.Add(this.lblCategory, 6, 0);
            this.table.Controls.Add(this.lblPrice, 8, 0);
            this.table.Controls.Add(this.pnStatus, 7, 0);
            this.table.Controls.Add(this.lblTrailer, 10, 0);
            this.table.Controls.Add(this.lblDuration, 9, 0);
            this.table.Location = new System.Drawing.Point(12, 100);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(926, 40);
            this.table.TabIndex = 38;
            this.table.SizeChanged += new System.EventHandler(this.table_SizeChanged);
            // 
            // pnlCB
            // 
            this.pnlCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCB.Controls.Add(this.chCheck);
            this.pnlCB.Location = new System.Drawing.Point(4, 4);
            this.pnlCB.Name = "pnlCB";
            this.pnlCB.Size = new System.Drawing.Size(15, 32);
            this.pnlCB.TabIndex = 48;
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.Location = new System.Drawing.Point(1, 4);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 26);
            this.chCheck.TabIndex = 2;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            this.chCheck.CheckedChanged += new System.EventHandler(this.chCheck_CheckedChanged);
            // 
            // lblMinimumAge
            // 
            this.lblMinimumAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimumAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMinimumAge.ForeColor = System.Drawing.Color.White;
            this.lblMinimumAge.Location = new System.Drawing.Point(730, 1);
            this.lblMinimumAge.Name = "lblMinimumAge";
            this.lblMinimumAge.Size = new System.Drawing.Size(69, 38);
            this.lblMinimumAge.TabIndex = 18;
            this.lblMinimumAge.Text = "Minimum Age";
            this.lblMinimumAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(26, 1);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 38);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.label2);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButtons.Location = new System.Drawing.Point(806, 4);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(116, 32);
            this.pnButtons.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(133, 1);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(98, 38);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Image";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(58, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 38);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(238, 1);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 38);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(330, 1);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 38);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Release Date";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(406, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 38);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(575, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 38);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnStatus
            // 
            this.pnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatus.Controls.Add(this.label1);
            this.pnStatus.Location = new System.Drawing.Point(490, 4);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(78, 32);
            this.pnStatus.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrailer
            // 
            this.lblTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTrailer.ForeColor = System.Drawing.Color.White;
            this.lblTrailer.Location = new System.Drawing.Point(683, 1);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(40, 38);
            this.lblTrailer.TabIndex = 16;
            this.lblTrailer.TabStop = true;
            this.lblTrailer.Text = "Trailer";
            this.lblTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(621, 1);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(55, 38);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.White;
            this.lblReleaseDate.Location = new System.Drawing.Point(358, 1);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(61, 32);
            this.lblReleaseDate.TabIndex = 9;
            this.lblReleaseDate.Text = "Release Date";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInActive
            // 
            this.btnInActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInActive.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.Location = new System.Drawing.Point(872, 75);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(66, 23);
            this.btnInActive.TabIndex = 46;
            this.btnInActive.Text = "InActive";
            this.btnInActive.UseVisualStyleBackColor = true;
            this.btnInActive.Click += new System.EventHandler(this.btnInActive_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(806, 75);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(61, 23);
            this.btnActive.TabIndex = 44;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(772, 75);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(28, 23);
            this.btnAll.TabIndex = 45;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // fpnMovies
            // 
            this.fpnMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnMovies.AutoScroll = true;
            this.fpnMovies.Location = new System.Drawing.Point(12, 130);
            this.fpnMovies.Margin = new System.Windows.Forms.Padding(0);
            this.fpnMovies.Name = "fpnMovies";
            this.fpnMovies.Size = new System.Drawing.Size(945, 392);
            this.fpnMovies.TabIndex = 47;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(961, 572);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.table);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.fpnMovies);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).EndInit();
            this.table.ResumeLayout(false);
            this.pnlCB.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private System.Windows.Forms.ComboBox cbAction;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.PictureBox pbMoviePhoto;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDuration;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrailer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinimumAge;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private System.Windows.Forms.CheckBox chCheck;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblReleaseDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.FlowLayoutPanel fpnMovies;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCB;
    }
}