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
    public partial class SchedulesMenu : Form
    {
        List<Schedule> schedules;
        public SchedulesMenu()
        {
            InitializeComponent();
        }

        private void SchedulesMenu_Load(object sender, EventArgs e)
        {
            ShowSchedules();
        }

        private void ShowSchedules()
        {
            if (fpnSchedules.Controls.Count > 0)
            {
                fpnSchedules.Controls.Clear();
            }
            schedules = new ScheduleBLL().RetrieveALL();
            SchedulePanel[] schedule = new SchedulePanel[schedules.Count];
            for (int i = 0; i < schedule.Length; i++)
            {
                schedule[i] = new SchedulePanel(table.Size.Width, table.Size.Height);
                schedule[i].ID = schedules[i].ID.ToString();
                schedule[i].MovieName = schedules[i].Movie.Title;
                schedule[i].HallName = schedules[i].Hall.Name; ;
                schedule[i].StartTime = schedules[i].StartTime.ToString("dd-MM-yyyy HH:mm");
                schedule[i].EndTime = schedules[i].EndTime.ToString("dd-MM-yyyy HH:mm");
                schedule[i].Description = schedules[i].Description;
                schedule[i].IsMaintened = schedules[i].isMaintained.ToString();
                fpnSchedules.Controls.Add(schedule[i]);
            }
        }

        private void ShowSchedules(string moviename)
        {
            if (fpnSchedules.Controls.Count > 0)
            {
                fpnSchedules.Controls.Clear();
            }
            if (this.schedules == null)
            {
                this.schedules = new ScheduleBLL().RetrieveALL();
            }
            var all = this.schedules;
            List<Schedule> schedules = new List<Schedule>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Movie.Title, moviename))
                {
                    schedules.Add(item);
                }
            }

            SchedulePanel[] schedule = new SchedulePanel[schedules.Count];
            for (int i = 0; i < schedule.Length; i++)
            {
                schedule[i] = new SchedulePanel(table.Size.Width, table.Size.Height);
                schedule[i].ID = schedules[i].ID.ToString();
                schedule[i].MovieName = schedules[i].Movie.Title;
                schedule[i].HallName = schedules[i].Hall.Name; ;
                schedule[i].StartTime = schedules[i].StartTime.ToString("dd-MM-yyyy HH:mm");
                schedule[i].EndTime = schedules[i].EndTime.ToString("dd-MM-yyyy HH:mm");
                schedule[i].Description = schedules[i].Description;
                schedule[i].IsMaintened = schedules[i].isMaintained.ToString();
                fpnSchedules.Controls.Add(schedule[i]);
            }
        }


        private void btnAddSchedules_Click(object sender, EventArgs e)
        {
            new AddNewSchedule().ShowDialog();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (SchedulePanel item in fpnSchedules.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (SchedulePanel item in fpnSchedules.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected schedulues!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (SchedulePanel item in fpnSchedules.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new ScheduleBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " schedulues has been deleted!");
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
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected schedules!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Schedule> schedules = new List<Schedule>();
                    int no = 0;
                    foreach (SchedulePanel item in fpnSchedules.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            schedules.Add(new ScheduleBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Schedule>(schedules));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " schedules has been exported to excel!");
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
                ShowSchedules();
            }
            else
                ShowSchedules(txtSearch.Text);
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (SchedulePanel item in fpnSchedules.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (SchedulePanel item in fpnSchedules.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowSchedules();
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowSchedules();
        }
    }
}
