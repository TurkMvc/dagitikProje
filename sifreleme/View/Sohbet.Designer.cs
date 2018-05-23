namespace sifreleme
{
    partial class Sohbet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sohbet));
            this.gelen_giden_mesaj = new System.Windows.Forms.RichTextBox();
            this.mesaj_icerik = new System.Windows.Forms.TextBox();
            this.mesaj_gonder = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Sil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gelen_giden_mesaj
            // 
            this.gelen_giden_mesaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gelen_giden_mesaj.BackColor = System.Drawing.Color.LightGray;
            this.gelen_giden_mesaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.gelen_giden_mesaj.Location = new System.Drawing.Point(12, 12);
            this.gelen_giden_mesaj.Name = "gelen_giden_mesaj";
            this.gelen_giden_mesaj.ReadOnly = true;
            this.gelen_giden_mesaj.Size = new System.Drawing.Size(518, 284);
            this.gelen_giden_mesaj.TabIndex = 0;
            this.gelen_giden_mesaj.Text = "";
            // 
            // mesaj_icerik
            // 
            this.mesaj_icerik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mesaj_icerik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mesaj_icerik.Location = new System.Drawing.Point(157, 302);
            this.mesaj_icerik.Multiline = true;
            this.mesaj_icerik.Name = "mesaj_icerik";
            this.mesaj_icerik.Size = new System.Drawing.Size(518, 85);
            this.mesaj_icerik.TabIndex = 1;
            this.mesaj_icerik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mesaj_icerik_KeyDown);
            // 
            // mesaj_gonder
            // 
            this.mesaj_gonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaj_gonder.BackgroundImage")));
            this.mesaj_gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj_gonder.Location = new System.Drawing.Point(255, 406);
            this.mesaj_gonder.Name = "mesaj_gonder";
            this.mesaj_gonder.Size = new System.Drawing.Size(118, 37);
            this.mesaj_gonder.TabIndex = 2;
            this.mesaj_gonder.UseVisualStyleBackColor = true;
            this.mesaj_gonder.Click += new System.EventHandler(this.mesaj_gonder_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sil.BackgroundImage")));
            this.Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.Location = new System.Drawing.Point(469, 406);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(135, 37);
            this.Sil.TabIndex = 3;
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(545, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(21, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 85);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Sohbet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.mesaj_gonder);
            this.Controls.Add(this.mesaj_icerik);
            this.Controls.Add(this.gelen_giden_mesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sohbet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sohbet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sohbet_FormClosed);
            this.Load += new System.EventHandler(this.Sohbet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gelen_giden_mesaj;
        private System.Windows.Forms.TextBox mesaj_icerik;
        private System.Windows.Forms.Button mesaj_gonder;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}