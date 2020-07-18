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
    public partial class SchedulePanel : UserControl
    {
        int X = 0, Y = 0;
        public SchedulePanel(int x, int y)
        {
            InitializeComponent();
            this.X = x;
            this.Y = y;
        }
        public CheckBox Check
        {
            get { return chCheck; }
            set { chCheck = value; }
        }
        public string ID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        public string MovieName
        {
            get { return lblMovieName.Text; }
            set { lblMovieName.Text = value; }
        }
        public string HallName
        {
            get { return lblHallName.Text; }
            set { lblHallName.Text = value; }
        }
        public string StartTime
        {
            get { return lblStartTime.Text; }
            set { lblStartTime.Text = value; }
        }
        public string EndTime
        {
            get { return lblEndTime.Text; }
            set { lblEndTime.Text = value; }
        }
        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }
        public string IsMaintened
        {
            get { return lblIsMaintened.Text; }
            set { lblIsMaintened.Text = value; }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditSchedule(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting schedule with id " + ID, $"Are you sure that you want to delete this schedule?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new ScheduleBLL().Delete(ID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Schedule, int.Parse(lblID.Text)).ShowDialog();
        }

        private void SchedulePanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbBook_Click(object sender, EventArgs e)
        {
            new Book(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            new CancelSchedule(int.Parse(lblID.Text)).Show();
        }
    }
}
