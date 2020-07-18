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
    public partial class ClientsMenu : Form
    {
        public ClientsMenu()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new AddNewClient().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                ShowClients();
            }
            else
            {
                ShowClients(txtSearch.Text);
            }
        }

        private void ShowClients(string filter)
        {
            if (fpnClients.Controls.Count > 0)
            {
                fpnClients.Controls.Clear();
            }
            var all = new ClientBLL().RetrieveALL();
            List<Client> c = new List<Client>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.UserName, filter))
                {
                    c.Add(item);
                }
            }
            all = c;
            
            ClientsPanel[] clients = new ClientsPanel[c.Count];
            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = new ClientsPanel(table.Size.Width, table.Size.Height)
                {
                    ID = all[i].ID,
                    FirstName = all[i].FirstName,
                    LastName = all[i].LastName,
                    UserName = all[i].UserName,
                    Password = all[i].Password,
                    Gender = all[i].Gender.Name,
                    Birthday = all[i].Birthday.ToString("dd-MM-yyyy")
                };
                fpnClients.Controls.Add(clients[i]);
            }
        }
        private void ShowClients()
        {
            if (fpnClients.Controls.Count > 0)
            {
                fpnClients.Controls.Clear();
            }
            var c = new ClientBLL().RetrieveALL();
            ClientsPanel[] clients = new ClientsPanel[c.Count];
            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = new ClientsPanel(table.Size.Width, table.Size.Height)
                {
                    ID = c[i].ID,
                    FirstName = c[i].FirstName,
                    LastName = c[i].LastName,
                    UserName = c[i].UserName,
                    Password = c[i].Password,
                    Gender = c[i].Gender.Name,
                    Birthday = c[i].Birthday.ToString("dd-MM-yyyy")
                };
                fpnClients.Controls.Add(clients[i]);
            }
        }

        private void ShowClients(bool genre)
        {
            if (fpnClients.Controls.Count > 0)
            {
                fpnClients.Controls.Clear();
            }
            List<Client> c;
            if (genre == true)
            {
                c = new ClientBLL().RetrieveByGenre(1);
            }
            else
            {
                c = new ClientBLL().RetrieveByGenre(2);
            }

            ClientsPanel[] clients = new ClientsPanel[c.Count];
            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = new ClientsPanel(table.Size.Width, table.Size.Height)
                {
                    ID = c[i].ID,
                    FirstName = c[i].FirstName,
                    LastName = c[i].LastName,
                    UserName = c[i].UserName,
                    Password = c[i].Password,
                    Gender = c[i].Gender.Name,
                    Birthday = c[i].Birthday.ToString("dd-MM-yyyy")
                };
                fpnClients.Controls.Add(clients[i]);
            }
        }


        private void ClientsMenu_Load(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (chBCheck.Checked == true)
            {
                foreach (ClientsPanel item in fpnClients.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (ClientsPanel item in fpnClients.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected clients!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (ClientsPanel item in fpnClients.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new ClientBLL().Delete(item.ID);
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " clients has been deleted!");
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
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected clients!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Client> clients = new List<Client>();
                    int no = 0;
                    foreach (ClientsPanel item in fpnClients.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            clients.Add(new ClientBLL().Retrieve(item.ID));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Client>(clients));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " clients has been exported to excel!");
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            ShowClients(true);
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            ShowClients(false);
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void chBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chBCheck.Checked == true)
            {
                foreach (ClientsPanel item in fpnClients.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (ClientsPanel item in fpnClients.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }
    }
}
