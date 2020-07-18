using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;
using CinemaManagement.BO;
namespace MenaxhimiKinemase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var bll = new UserBLL();
                var user = bll.Login(txtUserName.Text, txtPassword.Text);
                if (user != null)
                {
                    UserSession.CurrentUser = user;
                    user.LastLoginDate = DateTime.Now;
                    bll.UpdateActivity(user);
                    if (user.Role.ID == 4)
                    {
                        this.Close();
                        //lblUserLogged.Text = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.LastName;
                        //TransferFromFormToPanel(new DashboardMenu());
                        MessageBox.Show($"Welcome {user.FirstName} {user.LastName}");
                        //new SuperAdmin().Show();
                        //this.Close();
                    }
                    if (user.Role.ID == 1)
                    {
                        this.Close();
                        MessageBox.Show($"Welcome {user.FirstName} {user.LastName}");
                        //new Admin().Show();
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password invalid");
                }
            }
        }

        private void pbEnglishLanguage_Click(object sender, EventArgs e)
        {
            SysLanguage.ChangeLanguage("En");
        }

        private void pbShqipLanguage_Click(object sender, EventArgs e)
        {
            SysLanguage.ChangeLanguage("sq-XK");
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "User Name cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void pbGetHelp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.HelpProvider hp = new System.Windows.Forms.HelpProvider();
            hp.HelpNamespace = @"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\CMS_Manual.chm";
            Help.ShowHelp(this, hp.HelpNamespace, HelpNavigator.Topic, "Kyqja.htm");
        }

        private void btnLoginB_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var bll = new UserBLL();
                var user = bll.Login(txtUserName.Text, txtPassword.Text);
                if (user != null)
                {
                    UserSession.CurrentUser = user;
                    user.LastLoginDate = DateTime.Now;
                    bll.UpdateActivity(user);
                    if (user.Role.ID == 4)
                    {
                        this.Close();
                        //lblUserLogged.Text = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.LastName;
                        //TransferFromFormToPanel(new DashboardMenu());
                        MessageBox.Show($"Welcome {user.FirstName} {user.LastName}");
                        //new SuperAdmin().Show();
                        //this.Close();
                    }
                    if (user.Role.ID == 1)
                    {
                        this.Close();
                        MessageBox.Show($"Welcome {user.FirstName} {user.LastName}");
                        //new Admin().Show();
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password invalid");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserSession.CurrentUser == null)
                Application.Exit();
        }
    }
}
