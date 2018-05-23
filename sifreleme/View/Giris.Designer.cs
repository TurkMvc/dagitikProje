namespace sifreleme
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.resim_pcbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kayit_ol = new System.Windows.Forms.Button();
            this.Giris_yap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sifre_giris = new System.Windows.Forms.TextBox();
            this.Kullanici_giris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resim_pcbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resim_pcbx
            // 
            this.resim_pcbx.BackColor = System.Drawing.Color.Black;
            this.resim_pcbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resim_pcbx.BackgroundImage")));
            this.resim_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resim_pcbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resim_pcbx.ErrorImage = null;
            this.resim_pcbx.InitialImage = null;
            this.resim_pcbx.Location = new System.Drawing.Point(0, 0);
            this.resim_pcbx.Name = "resim_pcbx";
            this.resim_pcbx.Size = new System.Drawing.Size(387, 311);
            this.resim_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resim_pcbx.TabIndex = 16;
            this.resim_pcbx.TabStop = false;
            this.resim_pcbx.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.kayit_ol);
            this.panel1.Controls.Add(this.Giris_yap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Sifre_giris);
            this.panel1.Controls.Add(this.Kullanici_giris);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 97);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kayit_ol
            // 
            this.kayit_ol.BackColor = System.Drawing.SystemColors.Highlight;
            this.kayit_ol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayit_ol.BackgroundImage")));
            this.kayit_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_ol.Location = new System.Drawing.Point(259, 49);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(111, 31);
            this.kayit_ol.TabIndex = 19;
            this.kayit_ol.UseVisualStyleBackColor = false;
            this.kayit_ol.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris_yap
            // 
            this.Giris_yap.BackColor = System.Drawing.SystemColors.Highlight;
            this.Giris_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Giris_yap.BackgroundImage")));
            this.Giris_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_yap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Giris_yap.Location = new System.Drawing.Point(259, 6);
            this.Giris_yap.Name = "Giris_yap";
            this.Giris_yap.Size = new System.Drawing.Size(111, 34);
            this.Giris_yap.TabIndex = 18;
            this.Giris_yap.UseVisualStyleBackColor = false;
            this.Giris_yap.Click += new System.EventHandler(this.Giris_yap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Sifre_giris
            // 
            this.Sifre_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_giris.Location = new System.Drawing.Point(93, 44);
            this.Sifre_giris.MaxLength = 20;
            this.Sifre_giris.Name = "Sifre_giris";
            this.Sifre_giris.Size = new System.Drawing.Size(125, 22);
            this.Sifre_giris.TabIndex = 3;
            this.Sifre_giris.UseSystemPasswordChar = true;
            this.Sifre_giris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sifre_giris_KeyDown);
            // 
            // Kullanici_giris
            // 
            this.Kullanici_giris.BackColor = System.Drawing.Color.White;
            this.Kullanici_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_giris.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Kullanici_giris.Location = new System.Drawing.Point(93, 18);
            this.Kullanici_giris.MaxLength = 20;
            this.Kullanici_giris.Name = "Kullanici_giris";
            this.Kullanici_giris.Size = new System.Drawing.Size(125, 22);
            this.Kullanici_giris.TabIndex = 2;
            this.Kullanici_giris.TextChanged += new System.EventHandler(this.Kullanici_giris_TextChanged);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 408);
            this.Controls.Add(this.resim_pcbx);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Giris_FormClosed);
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim_pcbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resim_pcbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kayit_ol;
        private System.Windows.Forms.Button Giris_yap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sifre_giris;
        private System.Windows.Forms.TextBox Kullanici_giris;
    }
}