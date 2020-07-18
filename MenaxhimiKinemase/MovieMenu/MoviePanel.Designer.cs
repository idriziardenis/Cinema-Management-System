namespace MenaxhimiKinemase
{
    partial class MoviePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbMoviePhoto = new System.Windows.Forms.PictureBox();
            this.lblReleaseDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTrailer = new System.Windows.Forms.LinkLabel();
            this.lblMinimumAge = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.table.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).BeginInit();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
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
            this.table.Controls.Add(this.pnlCheck, 0, 0);
            this.table.Controls.Add(this.pnStatus, 6, 0);
            this.table.Controls.Add(this.lblDescription, 3, 0);
            this.table.Controls.Add(this.pbMoviePhoto, 2, 0);
            this.table.Controls.Add(this.lblReleaseDate, 4, 0);
            this.table.Controls.Add(this.lblCategory, 5, 0);
            this.table.Controls.Add(this.lblPrice, 7, 0);
            this.table.Controls.Add(this.lblDuration, 8, 0);
            this.table.Controls.Add(this.lblTrailer, 9, 0);
            this.table.Controls.Add(this.lblMinimumAge, 10, 0);
            this.table.Controls.Add(this.pnButtons, 11, 0);
            this.table.Controls.Add(this.lblTitle, 2, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(933, 100);
            this.table.TabIndex = 0;
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.chCheck);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Location = new System.Drawing.Point(4, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(15, 92);
            this.pnlCheck.TabIndex = 49;
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.Location = new System.Drawing.Point(1, 0);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 92);
            this.chCheck.TabIndex = 2;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.cbStatus);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatus.Location = new System.Drawing.Point(493, 4);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(79, 92);
            this.pnStatus.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "InActive"});
            this.cbStatus.Location = new System.Drawing.Point(3, 36);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(76, 21);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(239, 1);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 98);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "FirstNameFirstddd";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMoviePhoto
            // 
            this.pbMoviePhoto.Location = new System.Drawing.Point(58, 4);
            this.pbMoviePhoto.Name = "pbMoviePhoto";
            this.pbMoviePhoto.Size = new System.Drawing.Size(68, 92);
            this.pbMoviePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoviePhoto.TabIndex = 4;
            this.pbMoviePhoto.TabStop = false;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.White;
            this.lblReleaseDate.Location = new System.Drawing.Point(331, 1);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(70, 98);
            this.lblReleaseDate.TabIndex = 9;
            this.lblReleaseDate.Text = "10-10-2020";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(408, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 98);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Philosophical";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(579, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 98);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price $";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(626, 1);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(56, 98);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrailer
            // 
            this.lblTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTrailer.Location = new System.Drawing.Point(689, 1);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(40, 98);
            this.lblTrailer.TabIndex = 16;
            this.lblTrailer.TabStop = true;
            this.lblTrailer.Text = "Trailer";
            this.lblTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrailer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTrailer_LinkClicked);
            // 
            // lblMinimumAge
            // 
            this.lblMinimumAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimumAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMinimumAge.ForeColor = System.Drawing.Color.White;
            this.lblMinimumAge.Location = new System.Drawing.Point(736, 1);
            this.lblMinimumAge.Name = "lblMinimumAge";
            this.lblMinimumAge.Size = new System.Drawing.Size(69, 98);
            this.lblMinimumAge.TabIndex = 18;
            this.lblMinimumAge.Text = "Minimum Age";
            this.lblMinimumAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.pbInfo);
            this.pnButtons.Controls.Add(this.pbDelete);
            this.pnButtons.Controls.Add(this.pbEdit);
            this.pnButtons.Location = new System.Drawing.Point(812, 4);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(117, 92);
            this.pnButtons.TabIndex = 19;
            // 
            // pbInfo
            // 
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::MenaxhimiKinemase.Properties.Resources.info1;
            this.pbInfo.Location = new System.Drawing.Point(74, 36);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(21, 21);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 12;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelete.Image = global::MenaxhimiKinemase.Properties.Resources.delete;
            this.pbDelete.Location = new System.Drawing.Point(47, 36);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(21, 21);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 11;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::MenaxhimiKinemase.Properties.Resources.edit;
            this.pbEdit.Location = new System.Drawing.Point(20, 36);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(21, 21);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 10;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(133, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 98);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "36 Patrys Cres, Brackenfell, Cape Town";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblID.Size = new System.Drawing.Size(25, 98);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "100";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MoviePanel";
            this.Size = new System.Drawing.Size(933, 100);
            this.Load += new System.EventHandler(this.MoviePanel_Load);
            this.table.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).EndInit();
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.CheckBox chCheck;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private System.Windows.Forms.PictureBox pbMoviePhoto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel lblReleaseDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice;
        private System.Windows.Forms.LinkLabel lblTrailer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDuration;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinimumAge;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlCheck;
    }
}
