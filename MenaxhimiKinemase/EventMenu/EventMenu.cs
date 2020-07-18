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
    public partial class EventMenu : Form
    {
        public enum EventTypes { Daily,Weekly,Monthly,Yearly};
        public EventTypes EventType;
        public EventMenu()
        {
            InitializeComponent();
        }



        private void ShowEvents()
        {
            if (fpnEvents.Controls.Count > 0)
            {
                fpnEvents.Controls.Clear();
            }
            var e = new EventBLL().RetrieveALL();
            EventPanel[] events = new EventPanel[e.Count];
            for (int i = 0; i < events.Length; i++)
            {
                events[i] = new EventPanel(table.Size.Width, table.Size.Height);
                events[i].ID = e[i].ID.ToString();
                events[i].Title = e[i].Title;
                events[i].EventImage.Image = Image.FromFile(@"" + e[i].ImagePath);
                events[i].EventType = e[i].EventType.Type;
                events[i].Sales = e[i].Sales.ToString() + "%";
                events[i].EventStart = e[i].StartDate.ToString("dd/MM/yyyy");
                events[i].EventEnd = e[i].EndDate.ToString("dd/MM/yyyy");

                fpnEvents.Controls.Add(events[i]);
            }
        }

        private void ShowEvents(EventTypes eventTypes)
        {
            if (fpnEvents.Controls.Count > 0)
            {
                fpnEvents.Controls.Clear();
            }
            List<Event> e = new List<Event>();
            if(eventTypes == EventTypes.Daily)
            {
                e = new EventBLL().RetrieveByType(1);
            }
            else if(eventTypes == EventTypes.Weekly)
            {
                e = new EventBLL().RetrieveByType(2);
            }
            else if (eventTypes == EventTypes.Monthly)
            {
                e = new EventBLL().RetrieveByType(3);
            }
            else if (eventTypes == EventTypes.Yearly)
            {
                e = new EventBLL().RetrieveByType(4);
            }
            EventPanel[] events = new EventPanel[e.Count];
            for (int i = 0; i < events.Length; i++)
            {
                events[i] = new EventPanel(table.Size.Width, table.Size.Height);
                events[i].ID = e[i].ID.ToString();
                events[i].Title = e[i].Title;
                events[i].EventImage.Image = Image.FromFile(@"" + e[i].ImagePath);
                events[i].EventType = e[i].EventType.Type;
                events[i].Sales = e[i].Sales.ToString() + "%";
                events[i].EventStart = e[i].StartDate.ToString("dd/MM/yyyy");
                events[i].EventEnd = e[i].EndDate.ToString("dd/MM/yyyy");

                fpnEvents.Controls.Add(events[i]);
            }
        }

        private void ShowEvents(string eventname)
        {
            if (fpnEvents.Controls.Count > 0)
            {
                fpnEvents.Controls.Clear();
            }
            
            var all = new EventBLL().RetrieveALL();

            List<Event> e = new List<Event>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Title, eventname))
                {
                    e.Add(item);
                }
            }

            EventPanel[] events = new EventPanel[e.Count];
            for (int i = 0; i < events.Length; i++)
            {
                events[i] = new EventPanel(table.Size.Width, table.Size.Height);
                events[i].ID = e[i].ID.ToString();
                events[i].Title = e[i].Title;
                events[i].EventImage.Image = Image.FromFile(@"" + e[i].ImagePath);
                events[i].EventType = e[i].EventType.Type;
                events[i].Sales = e[i].Sales.ToString() + "%";
                events[i].EventStart = e[i].StartDate.ToString("dd/MM/yyyy");
                events[i].EventEnd = e[i].EndDate.ToString("dd/MM/yyyy");


                fpnEvents.Controls.Add(events[i]);
            }
        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            new AddNewEvent().ShowDialog();
        }

        private void EventMenu_Load(object sender, EventArgs e)
        {
            ShowEvents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                ShowEvents();
            }
            else
                ShowEvents(txtSearch.Text);
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (EventPanel item in fpnEvents.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (EventPanel item in fpnEvents.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected events!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (EventPanel item in fpnEvents.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new EventBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " events has been deleted!");
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
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected events!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Event> events = new List<Event>();
                    int no = 0;
                    foreach (EventPanel item in fpnEvents.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            events.Add(new EventBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Event>(events));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " events has been exported to excel!");
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

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (EventPanel item in fpnEvents.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (EventPanel item in fpnEvents.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            ShowEvents(EventTypes.Daily);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            ShowEvents(EventTypes.Weekly);
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            ShowEvents(EventTypes.Monthly);
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            ShowEvents(EventTypes.Yearly);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowEvents();
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowEvents();
        }
    }
}
