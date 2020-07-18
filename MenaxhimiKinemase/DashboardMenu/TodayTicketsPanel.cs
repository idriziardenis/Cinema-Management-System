using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public partial class TodayTicketsPanel : UserControl
    {
        public TodayTicketsPanel()
        {
            InitializeComponent();
        }

        public string TicketClient { get { return lblTicketClient.Text; } set { lblTicketClient.Text = value; } }
        public string TicketHall { get { return lblTicketHall.Text; } set { lblTicketHall.Text = value; } }
        public string TicketMovie { get { return lblTicketMovie.Text; } set { lblTicketMovie.Text = value; } }
        public string TicketPrice { get { return lblTicketPrice.Text; } set { lblTicketPrice.Text = value; } }

        private void TodayTicketsPanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));

        }

        private void TodayTicketsPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));

        }
    }
}
