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
    public partial class EditUser : Form
    {
        User u;
        public EditUser(int id)
        {
            InitializeComponent();
            u = new UserBLL().Retrieve(id);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            var Roles = new RoleBLL().RetrieveALL();
            foreach (Role role in Roles)
            {
                cbRoles.Items.Add(role);
            }

            lblHeader.Text += u.ID;
            txtFirstName.Text = u.FirstName;
            txtLastName.Text = u.LastName;
            txtUserName.Text = u.UserName;
            txtPassword.Text = u.Password;
            cbRoles.Text = u.Role.Name;
            cbRoles.SelectedItem = u.Role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            u.FirstName = txtFirstName.Text;
            u.LastName = txtLastName.Text;
            u.UserName = txtUserName.Text;
            if (u.Password != txtPassword.Text)
            {
                u.IsPasswordChanged = true;
                u.LastPasswordChangeDate = DateTime.Now;
            }
            else
            {
                u.IsPasswordChanged = false;
            }
            u.Password = txtPassword.Text;
            u.Role = (Role)cbRoles.SelectedItem;
            if (u.BaseAuditObject == null)
            {
                u.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                u.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new UserBLL().Update(u);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Canceling!" , $"Are you sure that you want to cancel this operation?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation canceled!");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            u.FirstName = txtFirstName.Text;
            u.LastName = txtLastName.Text;
            u.UserName = txtUserName.Text;
            if (u.Password != txtPassword.Text)
            {
                u.IsPasswordChanged = true;
                u.LastPasswordChangeDate = DateTime.Now;
            }
            else
            {
                u.IsPasswordChanged = false;
            }
            u.Password = txtPassword.Text;
            u.Role = (Role)cbRoles.SelectedItem;
            if (u.BaseAuditObject == null)
            {
                u.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                u.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new UserBLL().Update(u);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
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
    }
}
