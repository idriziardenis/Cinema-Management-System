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
    public partial class CancelSchedule : Form
    {
        Schedule s;
        public CancelSchedule(int ID)
        {
            s = new ScheduleBLL().Retrieve(ID);
            InitializeComponent();
        }

        private void CancelSchedule_Load(object sender, EventArgs e)
        {
            lblID.Text = s.ID.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            s.Description = txtDescription.Text;
            s.isMaintained = false;
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

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
