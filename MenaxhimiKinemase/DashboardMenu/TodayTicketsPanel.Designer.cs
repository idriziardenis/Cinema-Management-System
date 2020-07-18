namespace MenaxhimiKinemase
{
    partial class TodayTicketsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketMovie = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketHall = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Price:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(4, 59);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 17);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Hall:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(4, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Movie:";
            // 
            // lblTicketClient
            // 
            this.lblTicketClient.AutoSize = true;
            this.lblTicketClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketClient.ForeColor = System.Drawing.Color.White;
            this.lblTicketClient.Location = new System.Drawing.Point(3, 12);
            this.lblTicketClient.Name = "lblTicketClient";
            this.lblTicketClient.Size = new System.Drawing.Size(53, 19);
            this.lblTicketClient.TabIndex = 16;
            this.lblTicketClient.Text = "Client";
            // 
            // lblTicketMovie
            // 
            this.lblTicketMovie.AutoSize = true;
            this.lblTicketMovie.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblTicketMovie.ForeColor = System.Drawing.Color.White;
            this.lblTicketMovie.Location = new System.Drawing.Point(50, 40);
            this.lblTicketMovie.Name = "lblTicketMovie";
            this.lblTicketMovie.Size = new System.Drawing.Size(0, 17);
            this.lblTicketMovie.TabIndex = 20;
            // 
            // lblTicketHall
            // 
            this.lblTicketHall.AutoSize = true;
            this.lblTicketHall.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblTicketHall.ForeColor = System.Drawing.Color.White;
            this.lblTicketHall.Location = new System.Drawing.Point(33, 59);
            this.lblTicketHall.Name = "lblTicketHall";
            this.lblTicketHall.Size = new System.Drawing.Size(0, 17);
            this.lblTicketHall.TabIndex = 21;
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblTicketPrice.ForeColor = System.Drawing.Color.White;
            this.lblTicketPrice.Location = new System.Drawing.Point(43, 76);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(0, 17);
            this.lblTicketPrice.TabIndex = 22;
            // 
            // TodayTicketsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblTicketPrice);
            this.Controls.Add(this.lblTicketHall);
            this.Controls.Add(this.lblTicketMovie);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.lblTicketClient);
            this.Name = "TodayTicketsPanel";
            this.Size = new System.Drawing.Size(179, 100);
            this.MouseLeave += new System.EventHandler(this.TodayTicketsPanel_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TodayTicketsPanel_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketClient;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketMovie;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketHall;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketPrice;
    }
}
