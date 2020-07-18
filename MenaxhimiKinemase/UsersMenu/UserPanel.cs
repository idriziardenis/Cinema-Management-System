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
    public partial class UserPanel : UserControl
    {
        int X = 0, Y = 0;
        public UserPanel(int x, int y)
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

        public string Role
        {
            get
            {
                return lblRole.Text;
            }
            set
            {
                lblRole.Text = value;
            }
        }

        public string IsPasswordChanged
        {
            get
            {
                return lblIsPasswordChanged.Text;
            }
            set
            {
                lblIsPasswordChanged.Text = value;
            }
        }

        public string LastLoginDate
        {
            get
            {
                return lblLastLoginDate.Text;
            }
            set
            {
                if(value == default(DateTime).ToString("dd-MM-yyyy"))
                {
                    lblLastLoginDate.Text = "";
                }
                else
                {
                    lblLastLoginDate.Text = value;
                }
            }
        }

        public string LastPasswordChanged
        {
            get
            {
                return lblLastPasswordChanged.Text;
            }
            set
            {
                if (value == default(DateTime).ToString("dd-MM-yyyy"))
                {
                    lblLastPasswordChanged.Text = "";
                }
                else
                {
                    lblLastPasswordChanged.Text = value;
                }
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditUser(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting User with id " + userID, $"Are you sure that you want to delete Users?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new UserBLL().Delete(userID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.User, int.Parse(lblID.Text)).ShowDialog();
        }
    }
}
