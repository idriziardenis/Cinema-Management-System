namespace MenaxhimiKinemase
{
    partial class UserPanel
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
            this.pnButtons = new System.Windows.Forms.Panel();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.lblIsPasswordChanged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastPasswordChanged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastLoginDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFirstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCB = new System.Windows.Forms.Panel();
            this.chBCheck = new System.Windows.Forms.CheckBox();
            this.lblRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.table.SuspendLayout();
            this.pnlCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.pbInfo);
            this.pnButtons.Controls.Add(this.pbDelete);
            this.pnButtons.Controls.Add(this.pbEdit);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButtons.Location = new System.Drawing.Point(604, 4);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(100, 32);
            this.pnButtons.TabIndex = 13;
            // 
            // pbInfo
            // 
            this.pbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::MenaxhimiKinemase.Properties.Resources.info1;
            this.pbInfo.Location = new System.Drawing.Point(68, 6);
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
            this.pbDelete.Location = new System.Drawing.Point(41, 6);
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
            this.pbEdit.Location = new System.Drawing.Point(14, 6);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(21, 21);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 10;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // lblIsPasswordChanged
            // 
            this.lblIsPasswordChanged.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsPasswordChanged.ForeColor = System.Drawing.Color.White;
            this.lblIsPasswordChanged.Location = new System.Drawing.Point(544, 1);
            this.lblIsPasswordChanged.Name = "lblIsPasswordChanged";
            this.lblIsPasswordChanged.Size = new System.Drawing.Size(53, 38);
            this.lblIsPasswordChanged.TabIndex = 9;
            this.lblIsPasswordChanged.Text = "Password Changed";
            this.lblIsPasswordChanged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastPasswordChanged
            // 
            this.lblLastPasswordChanged.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastPasswordChanged.ForeColor = System.Drawing.Color.White;
            this.lblLastPasswordChanged.Location = new System.Drawing.Point(408, 1);
            this.lblLastPasswordChanged.Name = "lblLastPasswordChanged";
            this.lblLastPasswordChanged.Size = new System.Drawing.Size(61, 38);
            this.lblLastPasswordChanged.TabIndex = 8;
            this.lblLastPasswordChanged.Text = "10-10-2020";
            this.lblLastPasswordChanged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastLoginDate
            // 
            this.lblLastLoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastLoginDate.ForeColor = System.Drawing.Color.White;
            this.lblLastLoginDate.Location = new System.Drawing.Point(476, 1);
            this.lblLastLoginDate.Name = "lblLastLoginDate";
            this.lblLastLoginDate.Size = new System.Drawing.Size(61, 38);
            this.lblLastLoginDate.TabIndex = 7;
            this.lblLastLoginDate.Text = "10-10-2020";
            this.lblLastLoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(270, 1);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 38);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(182, 1);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 38);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(112, 1);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 38);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(51, 1);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 38);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "FirstName";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(26, 1);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 38);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table
            // 
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 11;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.107345F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.531073F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.757062F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.02825F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57062F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.615819F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.15819F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.745763F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.745763F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.615819F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.12429F));
            this.table.Controls.Add(this.pnlCB, 0, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.lblFirstName, 2, 0);
            this.table.Controls.Add(this.lblLastName, 3, 0);
            this.table.Controls.Add(this.lblUserName, 4, 0);
            this.table.Controls.Add(this.lblPassword, 5, 0);
            this.table.Controls.Add(this.lblLastPasswordChanged, 7, 0);
            this.table.Controls.Add(this.lblRole, 6, 0);
            this.table.Controls.Add(this.lblLastLoginDate, 8, 0);
            this.table.Controls.Add(this.pnButtons, 10, 0);
            this.table.Controls.Add(this.lblIsPasswordChanged, 9, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(708, 40);
            this.table.TabIndex = 0;
            // 
            // pnlCB
            // 
            this.pnlCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCB.Controls.Add(this.chBCheck);
            this.pnlCB.Location = new System.Drawing.Point(4, 4);
            this.pnlCB.Name = "pnlCB";
            this.pnlCB.Size = new System.Drawing.Size(15, 32);
            this.pnlCB.TabIndex = 41;
            // 
            // chBCheck
            // 
            this.chBCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBCheck.AutoSize = true;
            this.chBCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBCheck.Location = new System.Drawing.Point(1, 10);
            this.chBCheck.Name = "chBCheck";
            this.chBCheck.Size = new System.Drawing.Size(15, 14);
            this.chBCheck.TabIndex = 2;
            this.chBCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBCheck.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(330, 1);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(71, 38);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Receptionist";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(708, 40);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.table.ResumeLayout(false);
            this.pnlCB.ResumeLayout(false);
            this.pnlCB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIsPasswordChanged;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastPasswordChanged;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastLoginDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFirstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private System.Windows.Forms.TableLayoutPanel table;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRole;
        private System.Windows.Forms.Panel pnlCB;
        private System.Windows.Forms.CheckBox chBCheck;
    }
}
