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
    public partial class EditEvent : Form
    {
        Event ev;
        public EditEvent(int id)
        {
            ev = new EventBLL().Retrieve(id);
            InitializeComponent();
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            lblEventID.Text += ev.ID.ToString();
            txtTittle.Text = ev.Title;
            numericSales.Value = (decimal)ev.Sales;
            txtImagePath.Text = ev.ImagePath;
            txtDescription.Text = ev.Description;
            dtStartDate.Value = ev.StartDate;
            dtEndDate.Value = ev.EndDate;
            var eventtypes = new EventTypeBLL().RetrieveALL();
            foreach (EventType et in eventtypes)
            {
                cbType.Items.Add(et);
            }
            cbType.Text = ev.EventType.Type;
            cbType.SelectedItem = ev.EventType;
            var movies = new MovieBLL().RetrieveALL();
            foreach (Movie m in movies)
            {
                cbMovies.Items.Add(m);
            }
            cbMovies.Text = ev.Movie.Title;
            cbMovies.SelectedItem = ev.Movie;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ev.Title = txtTittle.Text;
            ev.ImagePath = txtImagePath.Text;
            ev.Description = txtDescription.Text;
            ev.StartDate = dtStartDate.Value;
            ev.EndDate = dtEndDate.Value;
            ev.Sales = (double)numericSales.Value;
            ev.EventType = (EventType)cbType.SelectedItem;
            ev.Movie = (Movie)cbMovies.SelectedItem;

            if (ev.BaseAuditObject == null)
            {
                ev.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                ev.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new EventBLL().Update(ev);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ev.Title = txtTittle.Text;
            ev.ImagePath = txtImagePath.Text;
            ev.Description = txtDescription.Text;
            ev.StartDate = dtStartDate.Value;
            ev.EndDate = dtEndDate.Value;
            ev.Sales = (double)numericSales.Value;
            ev.EventType = (EventType)cbType.SelectedItem;
            ev.Movie = (Movie)cbMovies.SelectedItem;

            if (ev.BaseAuditObject == null)
            {
                ev.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                ev.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new EventBLL().Update(ev);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
        }
    }
}
