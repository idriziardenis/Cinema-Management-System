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
    public partial class AddNewSchedule : Form
    {
        public AddNewSchedule()
        {
            InitializeComponent();
        }

        private void AddNewSchedule_Load(object sender, EventArgs e)
        {
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            var Movies = new MovieBLL().RetrieveALL();
            foreach (var item in Movies)
            {
                cbMovies.Items.Add(item);
            }
            var Halls = new HallBLL().RetrieveALL();
            foreach (var item in Halls)
            {
                cbHalls.Items.Add(item);
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Movie m = (Movie)cbMovies.SelectedItem;
                Hall h = (Hall)cbHalls.SelectedItem;
                Schedule s = new Schedule() { Movie = (Movie)cbMovies.SelectedItem, Hall = (Hall)cbHalls.SelectedItem, StartTime = dtStartTime.Value, EndTime = dtEndTime.Value, Description = "", isMaintained = true, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } };
                if (!isScheduled(s))
                {
                    new ScheduleBLL().Create(s);
                    DialogResult result = MessageBox.Show("Schedule sucessfully added! \n Do you want to add another schedule?", "Schedule sucessfully added!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cbMovies.SelectedIndex = -1;
                        cbHalls.SelectedIndex = -1;
                        dtEndTime.Value = DateTime.Now;
                        dtStartTime.Value = DateTime.Now;
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There is already a schedule on this time and this hall! Please change StartTime or Hall", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isScheduled(Schedule newSchedule)
        {
            bool isScheduled = false;
            var schedules = new ScheduleBLL().RetrieveALL();
            foreach (var item in schedules)
            {

                //if(item.Hall.Id != )
                int n1 = DateTime.Compare(newSchedule.StartTime, item.StartTime);
                int n2 = DateTime.Compare(newSchedule.StartTime, item.EndTime);
                int n3 = DateTime.Compare(newSchedule.StartTime, item.StartTime);
                int n4 = DateTime.Compare(newSchedule.EndTime, item.StartTime);
                if (((n1 > 0 && n2 > 0) || (n3 < 0) && (n4 < 0)))
                {
                    isScheduled = false;
                }
                else
                {
                    if (newSchedule.Hall.Name != item.Hall.Name)
                    {
                        isScheduled = false;
                    }
                    else
                    {
                        isScheduled = true;
                        break;
                    }

                }
            }
            return isScheduled;
        }
        private void dtStartTime_ValueChanged(object sender, EventArgs e)
        {
            
            if(cbMovies.SelectedIndex != -1)
            {
                //dtStartTime.Value = DateTime.Now;
                dtEndTime.Value = dtStartTime.Value.AddMinutes((cbMovies.SelectedItem as Movie).Duration);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void cbMovies_Validating(object sender, CancelEventArgs e)
        {
            if (cbMovies.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbMovies.Focus();
                errorProvider1.SetError(cbMovies, "Movie cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbMovies, null);
            }
        }

        private void cbHalls_Validating(object sender, CancelEventArgs e)
        {
            if (cbHalls.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbHalls.Focus();
                errorProvider1.SetError(cbHalls, "Hall cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbHalls, null);
            }
        }

        private void dtStartTime_Validating(object sender, CancelEventArgs e)
        {
            if (dtStartTime.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtStartTime.Focus();
                errorProvider1.SetError(dtStartTime, "Start Time cannot be default!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtStartTime, null);
            }
        }

        private void dtEndTime_Validating(object sender, CancelEventArgs e)
        {
            if (dtEndTime.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtEndTime.Focus();
                errorProvider1.SetError(dtEndTime, "End Time cannot be default!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtEndTime, null);
            }
        }

    }
}
