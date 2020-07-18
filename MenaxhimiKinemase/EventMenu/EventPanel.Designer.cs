namespace MenaxhimiKinemase
{
    partial class EventPanel
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
            this.lblEventType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSales = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            this.lblEventTittle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEventID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEndDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStartDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
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
            this.table.Controls.Add(this.lblEventType, 5, 0);
            this.table.Controls.Add(this.lblSales, 4, 0);
            this.table.Controls.Add(this.pbEventImage, 3, 0);
            this.table.Controls.Add(this.lblEventTittle, 2, 0);
            this.table.Controls.Add(this.lblEventID, 1, 0);
            this.table.Controls.Add(this.panel1, 0, 0);
            this.table.Controls.Add(this.pnButtons, 7, 0);
            this.table.Controls.Add(this.panel2, 6, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(538, 115);
            this.table.TabIndex = 0;
            // 
            // lblEventType
            // 
            this.lblEventType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventType.ForeColor = System.Drawing.Color.White;
            this.lblEventType.Location = new System.Drawing.Point(307, 1);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(63, 113);
            this.lblEventType.TabIndex = 20;
            this.lblEventType.Text = "Daily";
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
            this.lblSales.Size = new System.Drawing.Size(40, 113);
            this.lblSales.TabIndex = 19;
            this.lblSales.Text = "Sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEventImage
            // 
            this.pbEventImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEventImage.Location = new System.Drawing.Point(156, 4);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(97, 107);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 18;
            this.pbEventImage.TabStop = false;
            // 
            // lblEventTittle
            // 
            this.lblEventTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventTittle.ForeColor = System.Drawing.Color.White;
            this.lblEventTittle.Location = new System.Drawing.Point(73, 1);
            this.lblEventTittle.Name = "lblEventTittle";
            this.lblEventTittle.Size = new System.Drawing.Size(76, 113);
            this.lblEventTittle.TabIndex = 17;
            this.lblEventTittle.Text = "HallNameeeee";
            this.lblEventTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventID
            // 
            this.lblEventID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventID.ForeColor = System.Drawing.Color.White;
            this.lblEventID.Location = new System.Drawing.Point(26, 1);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(40, 113);
            this.lblEventID.TabIndex = 16;
            this.lblEventID.Text = "100";
            this.lblEventID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 107);
            this.panel1.TabIndex = 0;
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.AutoSize = true;
            this.chCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.Location = new System.Drawing.Point(0, 46);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 14);
            this.chCheck.TabIndex = 3;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.pbInfo);
            this.pnButtons.Controls.Add(this.pbDelete);
            this.pnButtons.Controls.Add(this.pbEdit);
            this.pnButtons.Location = new System.Drawing.Point(442, 4);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(92, 107);
            this.pnButtons.TabIndex = 15;
            // 
            // pbInfo
            // 
            this.pbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::MenaxhimiKinemase.Properties.Resources.info1;
            this.pbInfo.Location = new System.Drawing.Point(61, 43);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(21, 21);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 12;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelete.Image = global::MenaxhimiKinemase.Properties.Resources.delete;
            this.pbDelete.Location = new System.Drawing.Point(34, 43);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(21, 21);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 11;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::MenaxhimiKinemase.Properties.Resources.edit;
            this.pbEdit.Location = new System.Drawing.Point(7, 43);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(21, 21);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 10;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Location = new System.Drawing.Point(377, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 107);
            this.panel2.TabIndex = 21;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(0, 61);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(61, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "99-99-9999";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(0, 35);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "02-10-2020";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EventPanel";
            this.Size = new System.Drawing.Size(538, 115);
            this.Load += new System.EventHandler(this.EventComponent_Load);
            this.table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.CheckBox chCheck;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventTittle;
        private System.Windows.Forms.PictureBox pbEventImage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSales;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEventType;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEndDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStartDate;
    }
}
