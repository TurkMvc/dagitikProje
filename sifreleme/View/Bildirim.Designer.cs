namespace sifreleme
{
    partial class Bildirim
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bildirim));
            this.mesaj_icerik_lb = new System.Windows.Forms.Label();
            this.kullanici_ad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mesaj_icerik_lb
            // 
            this.mesaj_icerik_lb.AutoSize = true;
            this.mesaj_icerik_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj_icerik_lb.Location = new System.Drawing.Point(14, 53);
            this.mesaj_icerik_lb.Name = "mesaj_icerik_lb";
            this.mesaj_icerik_lb.Size = new System.Drawing.Size(51, 16);
            this.mesaj_icerik_lb.TabIndex = 0;
            this.mesaj_icerik_lb.Text = "label1";
            // 
            // kullanici_ad
            // 
            this.kullanici_ad.AutoSize = true;
            this.kullanici_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_ad.Location = new System.Drawing.Point(14, 24);
            this.kullanici_ad.Name = "kullanici_ad";
            this.kullanici_ad.Size = new System.Drawing.Size(51, 16);
            this.kullanici_ad.TabIndex = 1;
            this.kullanici_ad.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(232, 121);
            this.Controls.Add(this.kullanici_ad);
            this.Controls.Add(this.mesaj_icerik_lb);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bildirim";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bildirim";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Bildirim_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Bildirim_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mesaj_icerik_lb;
        private System.Windows.Forms.Label kullanici_ad;
        private System.Windows.Forms.Timer timer1;
    }
}