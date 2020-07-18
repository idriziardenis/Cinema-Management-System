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
    public partial class HallMenu : Form
    {
        List<Hall> all;
        public HallMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowHalls();
        }
        private void ShowHalls()
        {
            if (fpnHalls.Controls.Count > 0)
            {
                fpnHalls.Controls.Clear();
            }
            all = new HallBLL().RetrieveALL();
            HallPanel[] hall = new HallPanel[all.Count] ;
            for (int i = 0; i < hall.Length; i++)
            {
                hall[i] = new HallPanel(table.Size.Width, table.Size.Height);
                hall[i].ID = all[i].ID.ToString();
                hall[i].HallName = all[i].Name;
                hall[i].HallCapacity = (all[i].NoColumn * all[i].NoRow).ToString();
                hall[i].HallTechnology = all[i].Technology.Type;
                fpnHalls.Controls.Add(hall[i]);
            }
        }
        private void ShowHalls(string filter)
        {
            if (all == null)
            {
                all = new HallBLL().RetrieveALL();
            }
            
            List<Hall> filtered = new List<Hall>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Name, filter))
                {
                    filtered.Add(item);
                }
            }

            if (fpnHalls.Controls.Count > 0)
            {
                fpnHalls.Controls.Clear();
            }
            HallPanel[] hall = new HallPanel[filtered.Count];
            for (int i = 0; i < hall.Length; i++)
            {
                hall[i] = new HallPanel(table.Size.Width, table.Size.Height);
                hall[i].ID = all[i].ID.ToString();
                hall[i].HallName = all[i].Name;
                hall[i].HallCapacity = (all[i].NoColumn * all[i].NoRow).ToString();
                hall[i].HallTechnology = all[i].Technology.Type;
                fpnHalls.Controls.Add(hall[i]);
            }
        }

        private void ShowHalls(bool tech)
        {
            var bll = new HallBLL();
            List<Hall> filtered = new List<Hall>();
            if (tech == true)
            {
                filtered = bll.RetrieveByTechnology(3);
            }
            else
            {
                filtered = bll.RetrieveByTechnology(2);
            }

            if (fpnHalls.Controls.Count > 0)
            {
                fpnHalls.Controls.Clear();
            }
            HallPanel[] hall = new HallPanel[filtered.Count];
            for (int i = 0; i < hall.Length; i++)
            {
                hall[i] = new HallPanel(table.Size.Width,table.Size.Height);
                hall[i].ID = filtered[i].ID.ToString();
                hall[i].HallName = filtered[i].Name;
                hall[i].HallCapacity = (filtered[i].NoColumn * all[i].NoRow).ToString();
                hall[i].HallTechnology = filtered[i].Technology.Type;
                fpnHalls.Controls.Add(hall[i]);
            }
        }


        private void btnAddHall_Click(object sender, EventArgs e)
        {
            new AddNewHall().ShowDialog();
        }

        private void HallMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(table.Size.Width.ToString() + " " + table.Size.Height.ToString());
            ShowHalls();
        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            ShowHalls(false);
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            ShowHalls(true);
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (HallPanel item in fpnHalls.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (HallPanel item in fpnHalls.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowHalls();
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected halls!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (HallPanel item in fpnHalls.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new HallBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " halls has been deleted!");
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
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected halls!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Hall> halls = new List<Hall>();
                    int no = 0;
                    foreach (HallPanel item in fpnHalls.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            halls.Add(new HallBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Hall>(halls));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " halls has been exported to excel!");
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
                ShowHalls();
            }
            else
                ShowHalls(txtSearch.Text);
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (HallPanel item in fpnHalls.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (HallPanel item in fpnHalls.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(table.Size.Width.ToString() + " " + table.Size.Height.ToString());
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowHalls();
        }
    }
}
