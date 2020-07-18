namespace MenaxhimiKinemase
{
    partial class ClientsMenu
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
            this.fpnClients = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btnWoman = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnMan = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFirstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBirthday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.chBCheck = new System.Windows.Forms.CheckBox();
            this.table.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnClients
            // 
            this.fpnClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnClients.AutoScroll = true;
            this.fpnClients.Location = new System.Drawing.Point(22, 122);
            this.fpnClients.Name = "fpnClients";
            this.fpnClients.Size = new System.Drawing.Size(592, 411);
            this.fpnClients.TabIndex = 19;
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
            this.txtSearch.Location = new System.Drawing.Point(194, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(336, 36);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Active = false;
            this.btnAddClient.Activecolor = System.Drawing.Color.White;
            this.btnAddClient.BackColor = System.Drawing.Color.Gray;
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddClient.BorderRadius = 0;
            this.btnAddClient.ButtonText = "+ Add Client";
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddClient.Iconimage = null;
            this.btnAddClient.Iconimage_right = null;
            this.btnAddClient.Iconimage_right_Selected = null;
            this.btnAddClient.Iconimage_Selected = null;
            this.btnAddClient.IconMarginLeft = 0;
            this.btnAddClient.IconMarginRight = 0;
            this.btnAddClient.IconRightVisible = true;
            this.btnAddClient.IconRightZoom = 0D;
            this.btnAddClient.IconVisible = true;
            this.btnAddClient.IconZoom = 90D;
            this.btnAddClient.IsTab = false;
            this.btnAddClient.Location = new System.Drawing.Point(26, 12);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddClient.OnHovercolor = System.Drawing.Color.White;
            this.btnAddClient.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddClient.selected = false;
            this.btnAddClient.Size = new System.Drawing.Size(161, 34);
            this.btnAddClient.TabIndex = 20;
            this.btnAddClient.Text = "+ Add Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClient.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddClient.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Active = false;
            this.btnRefresh.Activecolor = System.Drawing.Color.White;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.ButtonText = "Search";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefresh.Iconimage = null;
            this.btnRefresh.Iconimage_right = null;
            this.btnRefresh.Iconimage_right_Selected = null;
            this.btnRefresh.Iconimage_Selected = null;
            this.btnRefresh.IconMarginLeft = 0;
            this.btnRefresh.IconMarginRight = 0;
            this.btnRefresh.IconRightVisible = true;
            this.btnRefresh.IconRightZoom = 0D;
            this.btnRefresh.IconVisible = true;
            this.btnRefresh.IconZoom = 90D;
            this.btnRefresh.IsTab = false;
            this.btnRefresh.Location = new System.Drawing.Point(521, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.Gray;
            this.btnRefresh.OnHovercolor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(78, 34);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete Selected",
            "Export to Excel"});
            this.cbAction.Location = new System.Drawing.Point(22, 539);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(118, 24);
            this.cbAction.TabIndex = 23;
            this.cbAction.Text = "  Choose Action";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // btnWoman
            // 
            this.btnWoman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWoman.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWoman.Location = new System.Drawing.Point(530, 56);
            this.btnWoman.Name = "btnWoman";
            this.btnWoman.Size = new System.Drawing.Size(69, 23);
            this.btnWoman.TabIndex = 29;
            this.btnWoman.Text = "Woman";
            this.btnWoman.UseVisualStyleBackColor = true;
            this.btnWoman.Click += new System.EventHandler(this.btnWoman_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(446, 56);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(30, 23);
            this.btnAll.TabIndex = 28;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnMan
            // 
            this.btnMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMan.Location = new System.Drawing.Point(482, 56);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(42, 23);
            this.btnMan.TabIndex = 27;
            this.btnMan.Text = "Man";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 9;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.812825F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.332756F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.74523F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.47834F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59792F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.74523F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30503F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.13172F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85096F));
            this.table.Controls.Add(this.bunifuCustomLabel1, 8, 0);
            this.table.Controls.Add(this.lblID, 1, 0);
            this.table.Controls.Add(this.lblFirstName, 2, 0);
            this.table.Controls.Add(this.lblLastName, 3, 0);
            this.table.Controls.Add(this.lblEmail, 4, 0);
            this.table.Controls.Add(this.lblPassword, 5, 0);
            this.table.Controls.Add(this.lblBirthday, 7, 0);
            this.table.Controls.Add(this.lblGender, 6, 0);
            this.table.Controls.Add(this.pnlCheck, 0, 0);
            this.table.Location = new System.Drawing.Point(22, 85);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(577, 40);
            this.table.TabIndex = 30;
            this.table.SizeChanged += new System.EventHandler(this.table_SizeChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(472, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 38);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Manage";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(112, 1);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 38);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(183, 1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 38);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "UserName";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(272, 1);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 38);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(403, 1);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(62, 38);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Birthday";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(333, 1);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 38);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.chBCheck);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Location = new System.Drawing.Point(4, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(15, 32);
            this.pnlCheck.TabIndex = 32;
            // 
            // chBCheck
            // 
            this.chBCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBCheck.AutoSize = true;
            this.chBCheck.Location = new System.Drawing.Point(1, 10);
            this.chBCheck.Name = "chBCheck";
            this.chBCheck.Size = new System.Drawing.Size(15, 14);
            this.chBCheck.TabIndex = 1;
            this.chBCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBCheck.UseVisualStyleBackColor = true;
            this.chBCheck.CheckedChanged += new System.EventHandler(this.chBCheck_CheckedChanged);
            // 
            // ClientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(626, 572);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnWoman);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.fpnClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsMenu";
            this.Text = "ClientsMenu";
            this.Load += new System.EventHandler(this.ClientsMenu_Load);
            this.table.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpnClients;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddClient;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button btnWoman;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.TableLayoutPanel table;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private System.Windows.Forms.CheckBox chBCheck;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFirstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBirthday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnlCheck;
    }
}