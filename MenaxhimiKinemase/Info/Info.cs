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
    public partial class Info : Form
    {
        public enum Record {Booking, CashPaymentDetails, Category, Chair, ChairClass, Cinema, Client, ClientPremiumDetails, Event, EventDetails, EventType, Genre, Hall, Movie, Payment, Role, Schedule, Technology, Ticket, User, User_Roles }
        Record RecordType;
        int RecordID;
        public Info(Record recordtype,int recordid)
        {
            InitializeComponent();
            RecordType = recordtype;
            RecordID = recordid;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            if (RecordType == Record.Booking)
            {
                var obj = new BookingBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if(RecordType == Record.CashPaymentDetails)
            {
                var obj = new CashPaymentDetailsBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Category)
            {
                var obj = new CategoryBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Chair)
            {
                var obj = new ChairBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.ChairClass)
            {
                var obj = new ChairClassBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Cinema)
            {
                var obj = new CinemaBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Client)
            {
                var obj = new ClientBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);

            }
            else if (RecordType == Record.ClientPremiumDetails)
            {
                var obj = new ClientPremiumDetailsBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Event)
            {
                var obj = new EventBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.EventDetails)
            {
                var obj = new EventDetailsBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.EventType)
            {
                var obj = new EventTypeBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Genre)
            {
                var obj = new GenderBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Hall)
            {
                var obj = new HallBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);

            }
            else if (RecordType == Record.Movie)
            {
                var obj = new MovieBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Payment)
            {
                var obj = new PaymentBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Role)
            {
                var obj = new RoleBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Schedule)
            {
                var obj = new ScheduleBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.Technology)
            {
                var obj = new TechnologyBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);

            }
            else if (RecordType == Record.Ticket)
            {
                var obj = new TicketBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.User)
            {
                var obj = new UserBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
            else if (RecordType == Record.User_Roles)
            {
                var obj = new UserBLL().Retrieve(RecordID);
                InitData(obj.BaseAuditObject);
            }
        }

        private void InitData(BaseAudit BaseAuditObject)
        {
            var bll = new UserBLL();
            lblInsertedBy.Text += bll.Retrieve(BaseAuditObject.InsertBy).UserName;
            lblInsertedDate.Text += BaseAuditObject.InsertDate.ToString("dd-MM-yyyy");
            lblUpdatedBy.Text += bll.Retrieve(BaseAuditObject.UpdateBy).UserName;
            lblUpdatedDate.Text += BaseAuditObject.UpdateDate.ToString("dd-MM-yyyy");
            lblUpdateNo.Text += BaseAuditObject.UpdateNo.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
