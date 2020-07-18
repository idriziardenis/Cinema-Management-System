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
    public partial class EditClient : Form
    {
        Client c;
        public EditClient(int id)
        {
            c = new ClientBLL().Retrieve(id);
            InitializeComponent();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            var Genders = new GenderBLL().RetrieveALL();
            foreach (var item in Genders)
            {
                cbRGender.Items.Add(item);
            }
            lblClientID.Text += c.ID;
            txtRFirstName.Text = c.FirstName;
            txtRLastName.Text = c.LastName;
            txtRUserName.Text = c.UserName;
            txtRPassword.Text = c.Password;
            txtRPassword.isPassword = false;
            dtRBirthday.Value = c.Birthday;
            cbRGender.Text = c.Gender.Name;
            cbRGender.SelectedItem = c.Gender;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            c.FirstName = txtRFirstName.Text;
            c.LastName = txtRLastName.Text;
            c.UserName = txtRUserName.Text;
            c.Password = txtRPassword.Text;
            txtRPassword.isPassword = true;
            c.Birthday = dtRBirthday.Value;
            c.Gender = (Gender)cbRGender.SelectedItem;
            if (c.BaseAuditObject == null)
            {
                c.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                c.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new ClientBLL().Update(c);
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
    }
}
