namespace MenaxhimiKinemase
{
    partial class AddNewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSchedule));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbMovies = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbHalls = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbladdnewhall = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAddSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(396, 118);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(76, 21);
            this.bunifuCustomLabel2.TabIndex = 47;
            this.bunifuCustomLabel2.Text = "EndTime";
            // 
            // cbMovies
            // 
            this.cbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.ItemHeight = 13;
            this.cbMovies.Location = new System.Drawing.Point(127, 58);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(202, 21);
            this.cbMovies.TabIndex = 0;
            this.cbMovies.Validating += new System.ComponentModel.CancelEventHandler(this.cbMovies_Validating);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(16, 118);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(84, 21);
            this.bunifuCustomLabel5.TabIndex = 43;
            this.bunifuCustomLabel5.Text = "StartTime";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 55);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 21);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Movie:";
            // 
            // cbHalls
            // 
            this.cbHalls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHalls.FormattingEnabled = true;
            this.cbHalls.Location = new System.Drawing.Point(495, 61);
            this.cbHalls.Name = "cbHalls";
            this.cbHalls.Size = new System.Drawing.Size(202, 21);
            this.cbHalls.TabIndex = 1;
            this.cbHalls.Validating += new System.ComponentModel.CancelEventHandler(this.cbHalls_Validating);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(396, 58);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(42, 21);
            this.bunifuCustomLabel3.TabIndex = 50;
            this.bunifuCustomLabel3.Text = "Hall:";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "dd/HH/yyyy HH:mm";
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(495, 119);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(202, 20);
            this.dtEndTime.TabIndex = 3;
            this.dtEndTime.Validating += new System.ComponentModel.CancelEventHandler(this.dtEndTime_Validating);
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(127, 118);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(202, 20);
            this.dtStartTime.TabIndex = 2;
            this.dtStartTime.ValueChanged += new System.EventHandler(this.dtStartTime_ValueChanged);
            this.dtStartTime.Validating += new System.ComponentModel.CancelEventHandler(this.dtStartTime_Validating);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lbladdnewhall);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.imgCloseButton);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(713, 42);
            this.pnlHeader.TabIndex = 57;
            // 
            // lbladdnewhall
            // 
            this.lbladdnewhall.AutoSize = true;
            this.lbladdnewhall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewhall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbladdnewhall.Location = new System.Drawing.Point(12, 9);
            this.lbladdnewhall.Name = "lbladdnewhall";
            this.lbladdnewhall.Size = new System.Drawing.Size(176, 21);
            this.lbladdnewhall.TabIndex = 55;
            this.lbladdnewhall.Text = "Add a New Schedule";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(671, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgCloseButton
            // 
            this.imgCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.imgCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("imgCloseButton.Image")));
            this.imgCloseButton.ImageActive = null;
            this.imgCloseButton.Location = new System.Drawing.Point(827, 12);
            this.imgCloseButton.Name = "imgCloseButton";
            this.imgCloseButton.Size = new System.Drawing.Size(20, 20);
            this.imgCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCloseButton.TabIndex = 3;
            this.imgCloseButton.TabStop = false;
            this.imgCloseButton.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Active = false;
            this.btnAddSchedule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSchedule.BorderRadius = 0;
            this.btnAddSchedule.ButtonText = "Add";
            this.btnAddSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSchedule.Iconimage = global::MenaxhimiKinemase.Properties.Resources.add;
            this.btnAddSchedule.Iconimage_right = null;
            this.btnAddSchedule.Iconimage_right_Selected = null;
            this.btnAddSchedule.Iconimage_Selected = null;
            this.btnAddSchedule.IconMarginLeft = 0;
            this.btnAddSchedule.IconMarginRight = 0;
            this.btnAddSchedule.IconRightVisible = true;
            this.btnAddSchedule.IconRightZoom = 0D;
            this.btnAddSchedule.IconVisible = true;
            this.btnAddSchedule.IconZoom = 60D;
            this.btnAddSchedule.IsTab = false;
            this.btnAddSchedule.Location = new System.Drawing.Point(19, 156);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddSchedule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddSchedule.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSchedule.selected = false;
            this.btnAddSchedule.Size = new System.Drawing.Size(310, 33);
            this.btnAddSchedule.TabIndex = 4;
            this.btnAddSchedule.Text = "Add";
            this.btnAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSchedule.Textcolor = System.Drawing.Color.Gainsboro;
            this.btnAddSchedule.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Active = false;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = global::MenaxhimiKinemase.Properties.Resources.cancel;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 60D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(400, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(297, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.Gainsboro;
            this.btnCancel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(713, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.cbHalls);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cbMovies);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewSchedule";
            this.Load += new System.EventHandler(this.AddNewSchedule_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddSchedule;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cbMovies;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbHalls;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel lbladdnewhall;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton imgCloseButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}