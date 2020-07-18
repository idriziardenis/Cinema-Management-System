namespace MenaxhimiKinemase
{
    partial class ActiveEventsPanel
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
            this.lblEventTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSale = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.ForeColor = System.Drawing.Color.White;
            this.lblEventTitle.Location = new System.Drawing.Point(3, 13);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(87, 19);
            this.lblEventTitle.TabIndex = 5;
            this.lblEventTitle.Text = "Event Tittle";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(3, 41);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(59, 17);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(3, 60);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 17);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(4, 77);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(39, 17);
            this.lblSale.TabIndex = 8;
            this.lblSale.Text = "Sales";
            // 
            // ActiveEventsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEventTitle);
            this.Name = "ActiveEventsPanel";
            this.Size = new System.Drawing.Size(179, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblEventTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDuration;
        private Bunifu.Framework.UI.BunifuCustomLabel lblType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSale;
    }
}
