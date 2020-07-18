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
using CinemaManagement.BO;

namespace MenaxhimiKinemase
{
    public partial class HallPanel : UserControl
    {
        int X, Y;
        public HallPanel(int x, int y)
        {
            InitializeComponent();
            X = x;
            Y = y;
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
        public string HallName
        {
            get { return lblHallName.Text; }
            set { lblHallName.Text = value; }
        }
        public string HallCapacity
        {
            get { return lblCapacity.Text; }
            set { lblCapacity.Text = value; }
        }

        public string HallTechnology
        {
            get { return cbTechnology.Text; }
            set { cbTechnology.Text = value; }
        }

        private void cbTechnology_SelectedValueChanged(object sender, EventArgs e)
        {
            var bll = new HallBLL();
            int hallID = int.Parse(lblID.Text);
            Hall m = bll.Retrieve(hallID);
            m.Technology = (Technology)cbTechnology.SelectedItem;
            if (m.BaseAuditObject == null)
            {
                m.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                m.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            bll.Update(m);
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditHall(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int hallID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting hall with id " + hallID, $"Are you sure that you want to this hall?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new UserBLL().Delete(hallID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void HallControl_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            var techs = new TechnologyBLL().RetrieveALL();
            foreach (Technology item in techs)
            {
                cbTechnology.Items.Add(techs);
            }
            
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Hall, int.Parse(lblID.Text)).ShowDialog();
        }
    }
}
