namespace MenaxhimiKinemase
{
    partial class MovieBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieBookings));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fpnShowTimes = new System.Windows.Forms.FlowLayoutPanel();
            this.pbMoviePhoto = new System.Windows.Forms.PictureBox();
            this.pbClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pbClose);
            this.pnlHeader.Controls.Add(this.imgCloseButton);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(579, 42);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(71, 21);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Booking";
            // 
            // fpnShowTimes
            // 
            this.fpnShowTimes.Location = new System.Drawing.Point(118, 48);
            this.fpnShowTimes.Name = "fpnShowTimes";
            this.fpnShowTimes.Size = new System.Drawing.Size(450, 143);
            this.fpnShowTimes.TabIndex = 6;
            // 
            // pbMoviePhoto
            // 
            this.pbMoviePhoto.Location = new System.Drawing.Point(12, 66);
            this.pbMoviePhoto.Name = "pbMoviePhoto";
            this.pbMoviePhoto.Size = new System.Drawing.Size(100, 107);
            this.pbMoviePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoviePhoto.TabIndex = 5;
            this.pbMoviePhoto.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.ImageActive = null;
            this.pbClose.Location = new System.Drawing.Point(547, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Zoom = 10;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
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
            // MovieBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(579, 202);
            this.Controls.Add(this.pbMoviePhoto);
            this.Controls.Add(this.fpnShowTimes);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieBookings";
            this.Text = "MovieBookings";
            this.Load += new System.EventHandler(this.MovieBookings_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton pbClose;
        private Bunifu.Framework.UI.BunifuImageButton imgCloseButton;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.PictureBox pbMoviePhoto;
        private System.Windows.Forms.FlowLayoutPanel fpnShowTimes;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}