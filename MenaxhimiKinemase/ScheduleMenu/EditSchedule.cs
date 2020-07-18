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
    public partial class EditSchedule : Form
    {
        Schedule s;
        public EditSchedule(int scheduleID)
        {
            s = new ScheduleBLL().Retrieve(scheduleID);
            InitializeComponent();
        }

        private void EditSchedule_Load(object sender, EventArgs e)
        {
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

            lblEdit.Text += s.ID;
            cbMovies.SelectedItem = s.Movie;

            for (int i = 0; i < cbHalls.Items.Count; i++)
            {
                if(s.Hall == cbHalls.Items[i])
                {
                    cbHalls.SelectedIndex = i;
                }
            }
            //cbHalls.SelectedItem = s.Hall;
            dtStartTime.Value = s.StartTime;
            dtEndTime.Value = s.EndTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            s.Movie = (Movie)cbMovies.SelectedItem;
            s.Hall = (Hall)cbHalls.SelectedItem;
            s.StartTime = dtStartTime.Value;
            s.EndTime = dtEndTime.Value;
            if (s.BaseAuditObject == null)
            {
                s.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                s.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new ScheduleBLL().Update(s);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtStartTime_ValueChanged(object sender, EventArgs e)
        {
            if(cbMovies.SelectedIndex != -1)
                dtEndTime.Value = dtStartTime.Value.AddMinutes((cbMovies.SelectedItem as Movie).Duration);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
