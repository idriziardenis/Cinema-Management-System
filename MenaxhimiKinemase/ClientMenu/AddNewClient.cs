using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BO;
using CinemaManagement.BLL;

namespace MenaxhimiKinemase
{
    public partial class AddNewClient : Form
    {
        public AddNewClient()
        {
            InitializeComponent();
        }

        private void btnRRegister_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            var Genre = new GenderBLL().RetrieveALL();
            foreach (Gender role in Genre)
            {
                cbGender.Items.Add(role);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && dtBirthday.Value != DateTime.Now && cbGender.SelectedIndex != -1)
            {
                //if (!ClientStore.Contain(txtRUserName.Text))
                //{
                new ClientBLL().Create(new Client() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Birthday = dtBirthday.Value, UserName = txtUserName.Text, Password = txtPassword.Text, Gender = (Gender)cbGender.SelectedItem, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                DialogResult result = MessageBox.Show("Client sucessfully added! \n Do you want to add another Client?", "Client sucessfully added!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtFirstName.Text = txtLastName.Text = txtUserName.Text = txtPassword.Text = "";
                    dtBirthday.Value = DateTime.Now;
                    cbGender.SelectedIndex = -1;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                //}
                //else
                //{
                //    MessageBox.Show("This username already exist. Please choose another one!");
                //    txtRUserName.Focus();
                //}
            }
            else
            {
                MessageBox.Show("Please fill out all the fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
