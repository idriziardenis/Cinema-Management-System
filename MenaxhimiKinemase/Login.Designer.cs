namespace MenaxhimiKinemase
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnLoginB = new System.Windows.Forms.Button();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Vija = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbGetHelp = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbShqipLanguage = new System.Windows.Forms.PictureBox();
            this.pbEnglishLanguage = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnLogin.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGetHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShqipLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnglishLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnLoginB);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.lblUserName);
            this.pnLogin.Controls.Add(this.txtUserName);
            resources.ApplyResources(this.pnLogin, "pnLogin");
            this.pnLogin.Name = "pnLogin";
            // 
            // btnLoginB
            // 
            resources.ApplyResources(this.btnLoginB, "btnLoginB");
            this.btnLoginB.Name = "btnLoginB";
            this.btnLoginB.UseVisualStyleBackColor = true;
            this.btnLoginB.Click += new System.EventHandler(this.btnLoginB_Click);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = true;
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Name = "lblUserName";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtUserName.BorderThickness = 3;
            this.txtUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.isPassword = false;
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // Vija
            // 
            this.Vija.BackColor = System.Drawing.Color.Transparent;
            this.Vija.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Vija.LineThickness = 3;
            resources.ApplyResources(this.Vija, "Vija");
            this.Vija.Name = "Vija";
            this.Vija.Transparency = 255;
            this.Vija.Vertical = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pbGetHelp);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.imgCloseButton);
            this.pnlHeader.Controls.Add(this.lblHeader);
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Name = "pnlHeader";
            // 
            // pbGetHelp
            // 
            this.pbGetHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGetHelp.Image = global::MenaxhimiKinemase.Properties.Resources.gethelp3;
            resources.ApplyResources(this.pbGetHelp, "pbGetHelp");
            this.pbGetHelp.Name = "pbGetHelp";
            this.pbGetHelp.TabStop = false;
            this.pbGetHelp.Click += new System.EventHandler(this.pbGetHelp_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ImageActive = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgCloseButton
            // 
            this.imgCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.imgCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.imgCloseButton, "imgCloseButton");
            this.imgCloseButton.ImageActive = null;
            this.imgCloseButton.Name = "imgCloseButton";
            this.imgCloseButton.TabStop = false;
            this.imgCloseButton.Zoom = 10;
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblHeader.Name = "lblHeader";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbShqipLanguage
            // 
            this.pbShqipLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShqipLanguage.Image = global::MenaxhimiKinemase.Properties.Resources.kosovo_flag;
            resources.ApplyResources(this.pbShqipLanguage, "pbShqipLanguage");
            this.pbShqipLanguage.Name = "pbShqipLanguage";
            this.pbShqipLanguage.TabStop = false;
            this.pbShqipLanguage.Click += new System.EventHandler(this.pbShqipLanguage_Click);
            // 
            // pbEnglishLanguage
            // 
            this.pbEnglishLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEnglishLanguage.Image = global::MenaxhimiKinemase.Properties.Resources.usa_flag1;
            resources.ApplyResources(this.pbEnglishLanguage, "pbEnglishLanguage");
            this.pbEnglishLanguage.Name = "pbEnglishLanguage";
            this.pbEnglishLanguage.TabStop = false;
            this.pbEnglishLanguage.Click += new System.EventHandler(this.pbEnglishLanguage_Click);
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.pbShqipLanguage);
            this.Controls.Add(this.pbEnglishLanguage);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.Vija);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGetHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShqipLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnglishLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuSeparator Vija;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton imgCloseButton;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.PictureBox pbEnglishLanguage;
        private System.Windows.Forms.PictureBox pbShqipLanguage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbGetHelp;
        private System.Windows.Forms.Button btnLoginB;
    }
}