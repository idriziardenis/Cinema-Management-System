namespace MenaxhimiKinemase
{
    partial class HallPanel
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
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHallName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.lblCapacity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTechnology = new System.Windows.Forms.ComboBox();
            this.pnlCB = new System.Windows.Forms.Panel();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.table.SuspendLayout();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 6;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.511523F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.012214F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.56623F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78136F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31155F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.81713F));
            this.table.Controls.Add(this.pnlCB, 0, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.lblHallName, 2, 0);
            this.table.Controls.Add(this.pnButtons, 5, 0);
            this.table.Controls.Add(this.lblCapacity, 3, 0);
            this.table.Controls.Add(this.panel1, 4, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(400, 40);
            this.table.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(26, 1);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 38);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "100";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHallName
            // 
            this.lblHallName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHallName.ForeColor = System.Drawing.Color.White;
            this.lblHallName.Location = new System.Drawing.Point(58, 1);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(82, 38);
            this.lblHallName.TabIndex = 11;
            this.lblHallName.Text = "HallNameeeeee";
            this.lblHallName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.pbInfo);
            this.pnButtons.Controls.Add(this.pbDelete);
            this.pnButtons.Controls.Add(this.pbEdit);
            this.pnButtons.Location = new System.Drawing.Point(297, 4);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(99, 32);
            this.pnButtons.TabIndex = 14;
            // 
            // pbInfo
            // 
            this.pbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::MenaxhimiKinemase.Properties.Resources.info1;
            this.pbInfo.Location = new System.Drawing.Point(64, 6);
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
            this.pbDelete.Location = new System.Drawing.Point(37, 6);
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
            this.pbEdit.Location = new System.Drawing.Point(10, 6);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(21, 21);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 10;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(147, 1);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 38);
            this.lblCapacity.TabIndex = 15;
            this.lblCapacity.Text = "Capacity";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbTechnology);
            this.panel1.Location = new System.Drawing.Point(217, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 32);
            this.panel1.TabIndex = 12;
            // 
            // cbTechnology
            // 
            this.cbTechnology.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTechnology.FormattingEnabled = true;
            this.cbTechnology.Location = new System.Drawing.Point(3, 6);
            this.cbTechnology.Name = "cbTechnology";
            this.cbTechnology.Size = new System.Drawing.Size(66, 21);
            this.cbTechnology.TabIndex = 1;
            this.cbTechnology.SelectedValueChanged += new System.EventHandler(this.cbTechnology_SelectedValueChanged);
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
            this.pnlCB.TabIndex = 40;
            // 
            // chCheck
            // 
            this.chCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCheck.AutoSize = true;
            this.chCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.Location = new System.Drawing.Point(1, 10);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(15, 14);
            this.chCheck.TabIndex = 2;
            this.chCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chCheck.UseVisualStyleBackColor = true;
            // 
            // HallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HallPanel";
            this.Size = new System.Drawing.Size(400, 40);
            this.Load += new System.EventHandler(this.HallControl_Load);
            this.table.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlCB.ResumeLayout(false);
            this.pnlCB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHallName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTechnology;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCapacity;
        private System.Windows.Forms.Panel pnlCB;
        private System.Windows.Forms.CheckBox chCheck;
    }
}
