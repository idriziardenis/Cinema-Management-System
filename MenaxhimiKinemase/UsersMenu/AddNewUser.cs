using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;
using CinemaManagement.BO;

namespace MenaxhimiKinemase
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        private void AddNewUser_Load(object sender, EventArgs e)
        {
            var Roles = new RoleBLL().RetrieveALL();
            foreach (Role role in Roles)
            {
                cbRoles.Items.Add(role);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                new UserBLL().Create(new User() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, UserName = txtUserName.Text, Password = txtPassword.Text, Role = (Role)cbRoles.SelectedItem, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                DialogResult result = MessageBox.Show("User sucessfully added! \n Do you want to add another User?", "User sucessfully added!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtFirstName.Text = txtLastName.Text = txtUserName.Text = txtPassword.Text = "";
                    cbRoles.SelectedIndex = -1;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Canceling!", $"Are you sure that you want to cancel this operation?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation canceled!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbEnglishLanguage_Click(object sender, EventArgs e)
        {
            SysLanguage.ChangeLanguage("En");
        }

        private void pbShqipLanguage_Click(object sender, EventArgs e)
        {
            SysLanguage.ChangeLanguage("sq-XK");
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, null);
            }
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

        private void cbRoles_Validating(object sender, CancelEventArgs e)
        {
            if(cbRoles.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbRoles.Focus();
                errorProvider1.SetError(cbRoles, "Role cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbRoles, null);
            }
        }
    }
}
