namespace Project.UI
{
    partial class FormPerson
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKisiListesi = new System.Windows.Forms.ComboBox();
            this.picDataResim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDataTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDataSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDataResim)).BeginInit();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPersonInfo.Controls.Add(this.btnResimEkle);
            this.gbPersonInfo.Controls.Add(this.picResim);
            this.gbPersonInfo.Controls.Add(this.tbEmail);
            this.gbPersonInfo.Controls.Add(this.tbTel);
            this.gbPersonInfo.Controls.Add(this.tbSoyad);
            this.gbPersonInfo.Controls.Add(this.tbAd);
            this.gbPersonInfo.Controls.Add(this.label3);
            this.gbPersonInfo.Controls.Add(this.label4);
            this.gbPersonInfo.Controls.Add(this.label2);
            this.gbPersonInfo.Controls.Add(this.label1);
            this.gbPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPersonInfo.Location = new System.Drawing.Point(13, 13);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(327, 203);
            this.gbPersonInfo.TabIndex = 0;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Kişi Bilgileri";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(60, 151);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(100, 23);
            this.btnResimEkle.TabIndex = 5;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // picResim
            // 
            this.picResim.Location = new System.Drawing.Point(194, 49);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(106, 121);
            this.picResim.TabIndex = 4;
            this.picResim.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(60, 125);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(60, 99);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 3;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(60, 75);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 3;
            this.tbSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAd_KeyPress);
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(60, 49);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 3;
            this.tbAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.cmbKisiListesi);
            this.groupBox2.Controls.Add(this.picDataResim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDataEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDataTel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbDataSoyad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbDataAd);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbKisiListesi
            // 
            this.cmbKisiListesi.FormattingEnabled = true;
            this.cmbKisiListesi.Location = new System.Drawing.Point(70, 11);
            this.cmbKisiListesi.Name = "cmbKisiListesi";
            this.cmbKisiListesi.Size = new System.Drawing.Size(324, 21);
            this.cmbKisiListesi.TabIndex = 6;
            this.cmbKisiListesi.SelectedIndexChanged += new System.EventHandler(this.cmbKisiListesi_SelectedIndexChanged);
            // 
            // picDataResim
            // 
            this.picDataResim.Location = new System.Drawing.Point(206, 50);
            this.picDataResim.Name = "picDataResim";
            this.picDataResim.Size = new System.Drawing.Size(106, 121);
            this.picDataResim.TabIndex = 4;
            this.picDataResim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adı";
            // 
            // tbDataEmail
            // 
            this.tbDataEmail.Location = new System.Drawing.Point(72, 126);
            this.tbDataEmail.Name = "tbDataEmail";
            this.tbDataEmail.Size = new System.Drawing.Size(100, 20);
            this.tbDataEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyadı";
            // 
            // tbDataTel
            // 
            this.tbDataTel.Location = new System.Drawing.Point(72, 100);
            this.tbDataTel.Name = "tbDataTel";
            this.tbDataTel.Size = new System.Drawing.Size(100, 20);
            this.tbDataTel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // tbDataSoyad
            // 
            this.tbDataSoyad.Location = new System.Drawing.Point(72, 76);
            this.tbDataSoyad.Name = "tbDataSoyad";
            this.tbDataSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbDataSoyad.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon";
            // 
            // tbDataAd
            // 
            this.tbDataAd.Location = new System.Drawing.Point(72, 50);
            this.tbDataAd.Name = "tbDataAd";
            this.tbDataAd.Size = new System.Drawing.Size(100, 20);
            this.tbDataAd.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(14, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            // 
            // gbButtons
            // 
            this.gbButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbButtons.Controls.Add(this.btnKaydet);
            this.gbButtons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbButtons.Location = new System.Drawing.Point(13, 222);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(327, 56);
            this.gbButtons.TabIndex = 1;
            this.gbButtons.TabStop = false;
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 281);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "FormPerson";
            this.ShowIcon = false;
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDataResim)).EndInit();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox picResim;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKisiListesi;
        private System.Windows.Forms.PictureBox picDataResim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDataTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDataSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDataAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.GroupBox gbButtons;
    }
}

