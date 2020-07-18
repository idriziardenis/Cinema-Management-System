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
    public partial class EventPanel : UserControl
    {
        int X, Y;
        public EventPanel(int x, int y)
        {
            InitializeComponent();
            X = x;
            Y = this.table.Size.Height;
        }

        public string ID { get { return lblEventID.Text; } set { lblEventID.Text = value; } }
        public CheckBox Check { get { return chCheck; } set { chCheck = value; } }
        public string Title { get { return lblEventTittle.Text; } set { lblEventTittle.Text = value; } }
        public PictureBox EventImage { get { return pbEventImage; } set { pbEventImage = value; } }
        public string EventType { get { return lblEventType.Text; } set { lblEventType.Text = value; } }
        public string Sales { get { return lblSales.Text; } set { lblSales.Text = value; } }
        public string EventStart { get { return lblStartDate.Text; } set { lblStartDate.Text = value; } }
        public string EventEnd { get { return lblEndDate.Text; } set { lblEndDate.Text = value; } }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditEvent(int.Parse(lblEventID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int eventID = int.Parse(lblEventID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting Event with id " + eventID, $"Are you sure that you want to delete ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new EventBLL().Delete(eventID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void EventComponent_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Event, int.Parse(lblEventID.Text)).ShowDialog();
        }
    }
}
