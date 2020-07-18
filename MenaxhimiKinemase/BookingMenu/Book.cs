using CinemaManagement.BLL;
using CinemaManagement.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public partial class Book : Form
    {
        int ScheduleID;
        Schedule schedule;
        int ClientID;
        int Column;
        int Row;
        public Book(int scheduleid)
        {
            InitializeComponent();
            ScheduleID = scheduleid;
            schedule = new ScheduleBLL().Retrieve(scheduleid);
            Column = schedule.Hall.NoColumn;
            Row = schedule.Hall.NoRow;
        }

        private void Book_Load(object sender, EventArgs e)
        {
            if(pnlChairs.Controls.Count >= 0)
            {
                pnlChairs.Controls.Clear();
            }
            var clients = new ClientBLL().RetrieveALL();
            for (int i = 0; i < clients.Count; i++)
            {
                cbClients.Items.Add(clients[i]);
            }

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            tlp.ColumnCount = Column;

            tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp.Location = new System.Drawing.Point(0, 0);
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)100 / Column));
            }
            //tlp.Location = new System.Drawing.Point(1, 1);
            tlp.Name = "tlp";
            tlp.RowCount = Row;
            for (int i = 0; i < tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)100 / Row));
            }
            tlp.TabIndex = 6;
            tlp.Size = pnlChairs.Size;
            pnlChairs.Controls.Add(tlp);
            var bookings = new BookingBLL().RetrieveBySchedule(ScheduleID);
            List<Chair> bookedchairs = new List<Chair>();
            foreach (CinemaManagement.BO.Booking ch in bookings)
            {
                bookedchairs.Add(ch.Chair);
            }
            for (int i = 0; i < tlp.RowCount; i++)
            {
                for (int j = 0; j < tlp.ColumnCount; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
                    pb.Cursor = Cursors.Hand;
                    pb.Dock = DockStyle.Fill;
                    pb.Click += (s, ea) => pb_Click(s, ea, i, j);
                    this.Controls.Add(pb);
                    tlp.Controls.Add(pb, i, j);
                    //if (bookings.Count != 0)
                    //{
                    //    foreach (Chair chair in bookedchairs)
                    //    {
                    //        if (chair.Column - 1 == i && chair.Row - 1 == j)
                    //        {
                    //            pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\bookedchair.png"), Name = "pb" + i.ToString() + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
                    //            pb.Dock = DockStyle.Fill;
                    //            this.Controls.Add(pb);
                    //            tlp.Controls.Add(pb, i, j);
                    //            tlp.GetControlFromPosition()
                    //        }
                    //        else
                    //        {
                    //            pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
                    //            pb.Cursor = Cursors.Hand;
                    //            pb.Dock = DockStyle.Fill;
                    //            pb.Click += (s, ea) => pb_Click(s, ea, i, j);
                    //            this.Controls.Add(pb);
                    //            tlp.Controls.Add(pb, i, j);
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
                    //    pb.Cursor = Cursors.Hand;
                    //    pb.Dock = DockStyle.Fill;
                    //    pb.Click += (s, ea) => pb_Click(s, ea, i, j);
                    //    this.Controls.Add(pb);
                    //    tlp.Controls.Add(pb, i, j);
                    //}
                }
            }

            //if (chair.Column - 1 == i && chair.Row - 1 == j)
            //{
            //    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\bookedchair.png"), Name = "pb" + i.ToString() + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //    pb.Dock = DockStyle.Fill;
            //    this.Controls.Add(pb);
            //    tlp.Controls.Add(pb, i, j);
            //    tlp.GetControlFromPosition()
            //                }
            for (int i = 0; i < bookedchairs.Count; i++)
            {
                Control c = tlp.GetControlFromPosition(bookedchairs[i].Column - 1, bookedchairs[i].Row - 1);
                PictureBox pb = c as PictureBox;
                int row = int.Parse(pb.Name.Split(',')[1]);
                int col = int.Parse(pb.Name.Split(',')[2]);
                pb.Cursor = Cursors.Default;
                pb.Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\bookedchair.png");
                //pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\bookedchair.png"), Name = "pb" + bookedchairs[i].Column.ToString() + bookedchairs[i].Row.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
                //pb.Dock = DockStyle.Fill;
                RemoveClickEvent(pb);
                //pb.Click -= (s, ea) => pb_Click(s, ea, row, col);
            }
            //pnlChairs.Controls.Add(tlp);
        }
        private void RemoveClickEvent(PictureBox b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }
        private void cbClients_SelectedValueChanged(object sender, EventArgs e)
        {
            //TableLayoutPanel tlp = new TableLayoutPanel();
            //tlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            //tlp.ColumnCount = Column;

            //tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            //tlp.Location = new System.Drawing.Point(0, 0);
            //for (int i = 0; i < tlp.ColumnCount; i++)
            //{
            //    tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)100/Column));
            //}
            ////tlp.Location = new System.Drawing.Point(1, 1);
            //tlp.Name = "tlp";
            //tlp.RowCount = Row;
            //for (int i = 0; i < tlp.RowCount; i++)
            //{
            //    tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)100/Row));
            //}
            //tlp.TabIndex = 6;
            //tlp.Size = pnlChairs.Size;
            //pnlChairs.Controls.Add(tlp);

            //for (int i = 0; i < tlp.RowCount; i++)
            //{
            //    for (int j = 0; j < tlp.ColumnCount; j++)
            //    {
            //        PictureBox pb = new PictureBox();
            //        var bookings = new BookingBLL().RetrieveBySchedule(ScheduleID);
            //        List<Chair> bookedchairs = new List<Chair>();
            //        if (bookings.Count != 0)
            //        {
            //            foreach (CinemaManagement.BO.Booking ch in bookings)
            //            {
            //                bookedchairs.Add(ch.Chair);
            //            }
            //            foreach (Chair chair in bookedchairs)
            //            {
            //                if(chair.Column == i && chair.Row == j)
            //                {
            //                    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\bookedchair.png"), Name = "pb" + i.ToString() + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //                    pb.Dock = DockStyle.Fill;
            //                    this.Controls.Add(pb);
            //                    tlp.Controls.Add(pb, i, j);
            //                }
            //                else
            //                {
            //                    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //                    pb.Cursor = Cursors.Hand;
            //                    pb.Dock = DockStyle.Fill;
            //                    pb.Click += (s, ea) => pb_Click(s, ea, i, j);
            //                    this.Controls.Add(pb);
            //                    tlp.Controls.Add(pb, i, j);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\images\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //            pb.Cursor = Cursors.Hand;
            //            pb.Dock = DockStyle.Fill;
            //            pb.Click += (s, ea) => pb_Click(s, ea, i, j);
            //            this.Controls.Add(pb);
            //            tlp.Controls.Add(pb, i, j);
            //        }
                   
                    
            //        //var sc = ScheduleStore.Find(ScheduleID).Hall.Chair[i, j];
            //        //if (sc != null)
            //        //{
            //        //    if (sc.isBooked == true)
            //        //    {
            //        //        pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\Faza2\bookedchair.png"), Name = "pb" + i.ToString() + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //        //        pb.Dock = DockStyle.Fill;
            //        //        this.Controls.Add(pb);
            //        //        tlp.Controls.Add(pb, i, j);
            //        //    }
            //        //    else
            //        //    {
            //        //        pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\Faza2\Chair.png"), Name = "pb" + i.ToString() + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //        //        pb.Cursor = Cursors.Hand;
            //        //        pb.Dock = DockStyle.Fill;
            //        //        pb.Click += (s, ea) => pb_Click(s, ea, i, j);
            //        //        this.Controls.Add(pb);
            //        //        tlp.Controls.Add(pb, i, j);
            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    pb = new PictureBox() { Image = Image.FromFile(@"C:\Users\Ardenis\Desktop\Faza2\Chair.png"), Name = "pb," + i.ToString() + "," + j.ToString(), Size = new System.Drawing.Size(25, 25), SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
            //        //    pb.Cursor = Cursors.Hand;
            //        //    pb.Dock = DockStyle.Fill;
            //        //    pb.Click += (s, ea) => pb_Click(s, ea, i, j);
            //        //    this.Controls.Add(pb);
            //        //    tlp.Controls.Add(pb, i, j);
            //        //}
            //    }
            //}
            ////pnlChairs.Controls.Add(tlp);
        }
        private void pb_Click(object s, EventArgs e, int row, int col)
        {
            if(cbClients.SelectedIndex != -1)
            {
                PictureBox pb = s as PictureBox;
                col = int.Parse(pb.Name.Split(',')[1])+1;
                row = int.Parse(pb.Name.Split(',')[2])+1;
                DialogResult result = MessageBox.Show($"Do you want to book this Chair [Row: {row}, Column {col}] ?", "Booking chair!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Chair c = new ChairBLL().RetrieveByRC(row, col);
                    var client = (Client)cbClients.SelectedItem;
                    Booking b = new CinemaManagement.BO.Booking() { Chair = c, Client = client, Schedule = new Schedule() { ID = ScheduleID }, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } };
                    new BookingBLL().Create(b);

                    DialogResult end = MessageBox.Show("Chair sucessfully booked! \n Do you want to get ticket?", "Chair sucessfully booked!", MessageBoxButtons.YesNo);
                    if (end == DialogResult.Yes)
                    {
                        new CreateTicket(c.ID, ScheduleID).ShowDialog();
                        this.Close();
                    }
                    else if (end == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Please choose the client!", "Client needed to choose!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //ScheduleStore.Find(ScheduleID).Hall.Chair[row, col] = new Chair(row, col);
            //ScheduleStore.Find(ScheduleID).Hall.Chair[row, col].isBooked = true;
            //Booking b = new Booking(ClientStore.Retrieve(ClientID), ScheduleStore.Find(ScheduleID), ScheduleStore.Find(ScheduleID).Hall.Chair[row, col]);
            //BookingStore.Add(b);
            //TicketMenu obj = new TicketMenu(b);
            //obj.Show();
            //this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
