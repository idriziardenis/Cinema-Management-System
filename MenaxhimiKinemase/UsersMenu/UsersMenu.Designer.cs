namespace MenaxhimiKinemase
{
    partial class UsersMenu
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
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fpnUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSuperAdmin = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastLoginDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastPasswordChanged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblManage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIsPasswordChanged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFirstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chBCheck = new System.Windows.Forms.CheckBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.table.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceptionist.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionist.Location = new System.Drawing.Point(644, 75);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(84, 23);
            this.btnReceptionist.TabIndex = 43;
            this.btnReceptionist.Text = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnManager
            // 
            this.btnManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManager.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(570, 75);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(68, 23);
            this.btnManager.TabIndex = 41;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete Selected",
            "Export to Excel"});
            this.cbAction.Location = new System.Drawing.Point(20, 539);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(113, 24);
            this.cbAction.TabIndex = 40;
            this.cbAction.Text = "  Choose Action";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(638, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHovercolor = System.Drawing.Color.White;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(90, 34);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(184, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 36);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Active = false;
            this.btnAddUser.Activecolor = System.Drawing.Color.White;
            this.btnAddUser.BackColor = System.Drawing.Color.Gray;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 0;
            this.btnAddUser.ButtonText = "+ Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = null;
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 90D;
            this.btnAddUser.IsTab = false;
            this.btnAddUser.Location = new System.Drawing.Point(20, 37);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddUser.OnHovercolor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(161, 34);
            this.btnAddUser.TabIndex = 37;
            this.btnAddUser.Text = "+ Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // fpnUsers
            // 
            this.fpnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnUsers.AutoScroll = true;
            this.fpnUsers.Location = new System.Drawing.Point(20, 142);
            this.fpnUsers.Name = "fpnUsers";
            this.fpnUsers.Size = new System.Drawing.Size(717, 391);
            this.fpnUsers.TabIndex = 36;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(383, 75);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(31, 23);
            this.btnAll.TabIndex = 42;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(507, 75);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(56, 23);
            this.btnAdmin.TabIndex = 44;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSuperAdmin
            // 
            this.btnSuperAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuperAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperAdmin.Location = new System.Drawing.Point(420, 75);
            this.btnSuperAdmin.Name = "btnSuperAdmin";
            this.btnSuperAdmin.Size = new System.Drawing.Size(81, 23);
            this.btnSuperAdmin.TabIndex = 45;
            this.btnSuperAdmin.Text = "SuperAdmin";
            this.btnSuperAdmin.UseVisualStyleBackColor = true;
            this.btnSuperAdmin.Click += new System.EventHandler(this.btnSuperAdmin_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(330, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 38);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Role";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblLastLoginDate.Text = "Last Login";
            this.lblLastLoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblLastPasswordChanged.Text = "Last Password";
            this.lblLastPasswordChanged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(182, 1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 38);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "UserName";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblManage
            // 
            this.lblManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManage.ForeColor = System.Drawing.Color.White;
            this.lblManage.Location = new System.Drawing.Point(604, 1);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(100, 38);
            this.lblManage.TabIndex = 10;
            this.lblManage.Text = "Manage";
            this.lblManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // chBCheck
            // 
            this.chBCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBCheck.AutoSize = true;
            this.chBCheck.Location = new System.Drawing.Point(0, 10);
            this.chBCheck.Name = "chBCheck";
            this.chBCheck.Size = new System.Drawing.Size(15, 14);
            this.chBCheck.TabIndex = 1;
            this.chBCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBCheck.UseVisualStyleBackColor = true;
            this.chBCheck.CheckedChanged += new System.EventHandler(this.chBCheck_CheckedChanged);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.table.Controls.Add(this.lblFirstName, 2, 0);
            this.table.Controls.Add(this.lblIsPasswordChanged, 8, 0);
            this.table.Controls.Add(this.lblManage, 9, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.lblLastName, 3, 0);
            this.table.Controls.Add(this.lblEmail, 4, 0);
            this.table.Controls.Add(this.lblPassword, 5, 0);
            this.table.Controls.Add(this.lblLastPasswordChanged, 7, 0);
            this.table.Controls.Add(this.lblLastLoginDate, 8, 0);
            this.table.Controls.Add(this.bunifuCustomLabel1, 6, 0);
            this.table.Controls.Add(this.pnlCheck, 0, 0);
            this.table.Location = new System.Drawing.Point(20, 104);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(708, 40);
            this.table.TabIndex = 46;
            this.table.SizeChanged += new System.EventHandler(this.table_SizeChanged);
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.chBCheck);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Location = new System.Drawing.Point(4, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(15, 32);
            this.pnlCheck.TabIndex = 16;
            // 
            // UsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(757, 572);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnSuperAdmin);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnReceptionist);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.fpnUsers);
            this.Controls.Add(this.btnAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersMenu";
            this.Text = ",";
            this.Load += new System.EventHandler(this.UsersMenu_Load);
            this.table.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceptionist;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.ComboBox cbAction;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private System.Windows.Forms.FlowLayoutPanel fpnUsers;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSuperAdmin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastLoginDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastPasswordChanged;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblManage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIsPasswordChanged;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFirstName;
        private System.Windows.Forms.CheckBox chBCheck;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel pnlCheck;
    }
}