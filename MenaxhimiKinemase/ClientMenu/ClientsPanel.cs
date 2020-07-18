using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;

namespace MenaxhimiKinemase
{
    public partial class ClientsPanel : UserControl
    {
        int X = 0, Y = 0;
        public ClientsPanel(int x, int y)
        {
            InitializeComponent();
            this.X = x;
            this.Y = y;
        }
        public CheckBox Check
        {
            get { return chBCheck; }
            set { chBCheck = value; }
        }
        public int ID
        {
            get
            {
                return int.Parse(lblID.Text);
            }
            set
            {
                lblID.Text = value.ToString();
            }
        }

        public string UserName
        {
            get
            {
                return lblUserName.Text;
            }
            set
            {
                lblUserName.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return lblPassword.Text;
            }
            set
            {
                lblPassword.Text = new string('*', value.Length);
            }
        }
        public string FirstName
        {
            get
            {
                return lblFirstName.Text;
            }
            set
            {
                lblFirstName.Text = value;
            }
        }
        public string LastName
        {
            get
            {
                return lblLastName.Text;
            }
            set
            {
                lblLastName.Text = value;
            }
        }

        public string Gender
        {
            get
            {
                return lblGender.Text;
            }
            set
            {
                lblGender.Text = value;
            }
        }
        public string Birthday
        {
            get
            {
                return lblBirthday.Text;
            }
            set
            {
                lblBirthday.Text = value;
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditClient(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting client with id " + userID, $"Are you sure that you want to delete this client?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new ClientBLL().Delete(userID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void ClientsPanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Client, int.Parse(lblID.Text)).Show();
        }
    }
}
