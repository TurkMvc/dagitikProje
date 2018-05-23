namespace sifreleme
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            this.Kullanici_Ad = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dogum_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uyari = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.resim_pcbx = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim_pcbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Kullanici_Ad
            // 
            this.Kullanici_Ad.BackColor = System.Drawing.SystemColors.Window;
            this.Kullanici_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Ad.Location = new System.Drawing.Point(105, 24);
            this.Kullanici_Ad.MaxLength = 20;
            this.Kullanici_Ad.Name = "Kullanici_Ad";
            this.Kullanici_Ad.Size = new System.Drawing.Size(125, 22);
            this.Kullanici_Ad.TabIndex = 2;
            this.Kullanici_Ad.TextChanged += new System.EventHandler(this.Kullanici_Ad_TextChanged);
            // 
            // Sifre
            // 
            this.Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.Location = new System.Drawing.Point(105, 52);
            this.Sifre.MaxLength = 20;
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(125, 22);
            this.Sifre.TabIndex = 3;
            this.Sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(105, 80);
            this.Ad.MaxLength = 20;
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(125, 22);
            this.Ad.TabIndex = 8;
            // 
            // Soyad
            // 
            this.Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyad.Location = new System.Drawing.Point(105, 108);
            this.Soyad.MaxLength = 20;
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(125, 22);
            this.Soyad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyad:";
         
            // 
            // Dogum_Tarih
            // 
            this.Dogum_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dogum_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dogum_Tarih.Location = new System.Drawing.Point(105, 164);
            this.Dogum_Tarih.Name = "Dogum_Tarih";
            this.Dogum_Tarih.Size = new System.Drawing.Size(125, 22);
            this.Dogum_Tarih.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uyari);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Mail);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Dogum_Tarih);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Soyad);
            this.panel1.Controls.Add(this.Ad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Sifre);
            this.panel1.Controls.Add(this.Kullanici_Ad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 256);
            this.panel1.TabIndex = 15;
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari.ForeColor = System.Drawing.Color.Red;
            this.uyari.Location = new System.Drawing.Point(102, 0);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(0, 13);
            this.uyari.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mail:";
            // 
            // Mail
            // 
            this.Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mail.Location = new System.Drawing.Point(105, 136);
            this.Mail.MaxLength = 40;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(125, 22);
            this.Mail.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(56, 204);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 23);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // resim_pcbx
            // 
            this.resim_pcbx.BackColor = System.Drawing.Color.White;
            this.resim_pcbx.ErrorImage = null;
            this.resim_pcbx.Image = ((System.Drawing.Image)(resources.GetObject("resim_pcbx.Image")));
            this.resim_pcbx.InitialImage = null;
            this.resim_pcbx.Location = new System.Drawing.Point(0, -2);
            this.resim_pcbx.Name = "resim_pcbx";
            this.resim_pcbx.Size = new System.Drawing.Size(295, 168);
            this.resim_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim_pcbx.TabIndex = 0;
            this.resim_pcbx.TabStop = false;
            this.resim_pcbx.WaitOnLoad = true;
           
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(169, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(295, 425);
            this.Controls.Add(this.resim_pcbx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kayit_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim_pcbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Kullanici_Ad;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dogum_Tarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label uyari;
        private System.Windows.Forms.PictureBox resim_pcbx;
        private System.Windows.Forms.Button button1;
    }
}

