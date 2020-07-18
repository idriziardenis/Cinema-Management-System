namespace MenaxhimiKinemase
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblInsertedBy = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblInsertedDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUpdatedBy = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUpdatedDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUpdateNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(475, 38);
            this.pnlHeader.TabIndex = 93;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(417, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 94;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(443, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(247, 21);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Info about record in database";
            // 
            // lblInsertedBy
            // 
            this.lblInsertedBy.AutoSize = true;
            this.lblInsertedBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertedBy.ForeColor = System.Drawing.Color.White;
            this.lblInsertedBy.Location = new System.Drawing.Point(34, 59);
            this.lblInsertedBy.Name = "lblInsertedBy";
            this.lblInsertedBy.Size = new System.Drawing.Size(83, 17);
            this.lblInsertedBy.TabIndex = 95;
            this.lblInsertedBy.Text = "Inserted By: ";
            // 
            // lblInsertedDate
            // 
            this.lblInsertedDate.AutoSize = true;
            this.lblInsertedDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertedDate.ForeColor = System.Drawing.Color.White;
            this.lblInsertedDate.Location = new System.Drawing.Point(34, 88);
            this.lblInsertedDate.Name = "lblInsertedDate";
            this.lblInsertedDate.Size = new System.Drawing.Size(102, 17);
            this.lblInsertedDate.TabIndex = 96;
            this.lblInsertedDate.Text = "Inserted Date: ";
            // 
            // lblUpdatedBy
            // 
            this.lblUpdatedBy.AutoSize = true;
            this.lblUpdatedBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedBy.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedBy.Location = new System.Drawing.Point(250, 59);
            this.lblUpdatedBy.Name = "lblUpdatedBy";
            this.lblUpdatedBy.Size = new System.Drawing.Size(90, 17);
            this.lblUpdatedBy.TabIndex = 97;
            this.lblUpdatedBy.Text = "Updated By: ";
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedDate.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedDate.Location = new System.Drawing.Point(250, 88);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(109, 17);
            this.lblUpdatedDate.TabIndex = 98;
            this.lblUpdatedDate.Text = "Updated Date: ";
            // 
            // lblUpdateNo
            // 
            this.lblUpdateNo.AutoSize = true;
            this.lblUpdateNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateNo.ForeColor = System.Drawing.Color.White;
            this.lblUpdateNo.Location = new System.Drawing.Point(34, 121);
            this.lblUpdateNo.Name = "lblUpdateNo";
            this.lblUpdateNo.Size = new System.Drawing.Size(87, 17);
            this.lblUpdateNo.TabIndex = 99;
            this.lblUpdateNo.Text = "Update No: ";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(475, 161);
            this.Controls.Add(this.lblUpdateNo);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.lblUpdatedBy);
            this.Controls.Add(this.lblInsertedDate);
            this.Controls.Add(this.lblInsertedBy);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInsertedBy;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInsertedDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUpdatedBy;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUpdatedDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUpdateNo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}