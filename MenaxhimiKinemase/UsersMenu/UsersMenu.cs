using CinemaManagement.BLL;
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
namespace MenaxhimiKinemase
{
    public partial class UsersMenu : Form
    {
        List<User> all;
        public enum Roles { Admin,Manager,Receptionist,SuperAdmin}
        public UsersMenu()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new AddNewUser().ShowDialog();
        }

        private void ShowUsers()
        {
            if (fpnUsers.Controls.Count > 0)
            {
                fpnUsers.Controls.Clear();
            }
            all = new UserBLL().RetrieveALL();
            UserPanel[] users = new UserPanel[all.Count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new UserPanel(table.Size.Width, table.Size.Height)
                {
                    ID = all[i].ID,
                    UserName = all[i].UserName,
                    Password = all[i].Password,
                    FirstName = all[i].FirstName,
                    LastName = all[i].LastName,
                    Role = all[i].Role.Name,
                    LastLoginDate = all[i].LastLoginDate.ToString("dd-MM-yyyy"),
                    LastPasswordChanged = all[i].LastPasswordChangeDate.ToString("dd-MM-yyyy"),
                    IsPasswordChanged = all[i].IsPasswordChanged.ToString()
                };
                fpnUsers.Controls.Add(users[i]);
            }
        }
        private void ShowUsers(Roles roles)
        {
            if (fpnUsers.Controls.Count > 0)
            {
                fpnUsers.Controls.Clear();
            }
            if(roles == Roles.Admin)
            {
                all = new UserBLL().RetrieveByRole(1);
            }
            else if(roles == Roles.Manager)
            {
                all = new UserBLL().RetrieveByRole(2);
            }
            else if(roles == Roles.Receptionist)
            {
                all = new UserBLL().RetrieveByRole(3);
            }
            else if(roles == Roles.SuperAdmin)
            {
                all = new UserBLL().RetrieveByRole(4);
            }
            UserPanel[] users = new UserPanel[all.Count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new UserPanel(table.Size.Width, table.Size.Height)
                {
                    ID = all[i].ID,
                    UserName = all[i].UserName,
                    Password = all[i].Password,
                    FirstName = all[i].FirstName,
                    LastName = all[i].LastName,
                    Role = all[i].Role.Name,
                    LastLoginDate = all[i].LastLoginDate.ToString("dd-MM-yyyy"),
                    LastPasswordChanged = all[i].LastPasswordChangeDate.ToString("dd-MM-yyyy"),
                    IsPasswordChanged = all[i].IsPasswordChanged.ToString()
                };
                fpnUsers.Controls.Add(users[i]);
            }
        }
        private void ShowUsers(string firstName)
        {
            if (fpnUsers.Controls.Count > 0)
            {
                fpnUsers.Controls.Clear();
            }
            if(all==null)
            {
                all = new UserBLL().RetrieveALL();
            }
            List<User> u = new List<User>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.FirstName.ToLower(), firstName.ToLower()))
                {
                    u.Add(item);
                }
            }
            UserPanel[] users = new UserPanel[u.Count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new UserPanel(table.Size.Width, table.Size.Height)
                {
                    ID = u[i].ID,
                    UserName = u[i].UserName,
                    Password = u[i].Password,
                    FirstName = u[i].FirstName,
                    LastName = u[i].LastName,
                    Role = u[i].Role.Name,
                    LastLoginDate = u[i].LastLoginDate.ToString("dd-MM-yyyy"),
                    LastPasswordChanged = u[i].LastPasswordChangeDate.ToString("dd-MM-yyyy"),
                    IsPasswordChanged = u[i].IsPasswordChanged.ToString()
                };
                fpnUsers.Controls.Add(users[i]);
            }
        }
        private void UsersMenu_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void chBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chBCheck.Checked == true)
            {
                foreach (UserPanel item in fpnUsers.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (UserPanel item in fpnUsers.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected users!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (UserPanel item in fpnUsers.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new UserBLL().Delete(item.ID);
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " users has been deleted!");
                        cbAction.Text = "Choose Action";
                    }
                    else
                    {
                        MessageBox.Show("You need to select one or more!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deleting canceled!");
                }
            }
            else if (cbAction.Text == "Export to Excel")
            {
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected users!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<User> users = new List<User>();
                    int no = 0;
                    foreach (UserPanel item in fpnUsers.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            users.Add(new UserBLL().Retrieve(item.ID));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<User>(users));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " users has been exported to excel!");
                        cbAction.Text = "Choose Action";
                    }
                    else
                    {
                        MessageBox.Show("You need to select one or more!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Exporting canceled!");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowUsers();
            }
            else
            {
                ShowUsers(txtSearch.Text);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void btnSuperAdmin_Click(object sender, EventArgs e)
        {
            ShowUsers(Roles.SuperAdmin);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowUsers(Roles.Admin);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ShowUsers(Roles.Manager);
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            ShowUsers(Roles.Receptionist);
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowUsers();
        }
    }
}
