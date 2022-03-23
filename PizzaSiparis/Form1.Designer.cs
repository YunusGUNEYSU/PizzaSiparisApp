namespace PizzaSiparis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEbatlar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.rdbInceKenar = new System.Windows.Forms.RadioButton();
            this.rdbKalınKenar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZACI SİPARİŞ EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ebatlar";
            // 
            // cmbEbatlar
            // 
            this.cmbEbatlar.FormattingEnabled = true;
            this.cmbEbatlar.Location = new System.Drawing.Point(131, 112);
            this.cmbEbatlar.Name = "cmbEbatlar";
            this.cmbEbatlar.Size = new System.Drawing.Size(185, 24);
            this.cmbEbatlar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pizzalar";
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 16;
            this.lstPizzalar.Location = new System.Drawing.Point(131, 175);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(200, 116);
            this.lstPizzalar.TabIndex = 4;
            // 
            // rdbInceKenar
            // 
            this.rdbInceKenar.AutoSize = true;
            this.rdbInceKenar.Checked = true;
            this.rdbInceKenar.Location = new System.Drawing.Point(131, 316);
            this.rdbInceKenar.Name = "rdbInceKenar";
            this.rdbInceKenar.Size = new System.Drawing.Size(97, 21);
            this.rdbInceKenar.TabIndex = 5;
            this.rdbInceKenar.TabStop = true;
            this.rdbInceKenar.Text = "İnce Kenar";
            this.rdbInceKenar.UseVisualStyleBackColor = true;
            // 
            // rdbKalınKenar
            // 
            this.rdbKalınKenar.AutoSize = true;
            this.rdbKalınKenar.Location = new System.Drawing.Point(247, 316);
            this.rdbKalınKenar.Name = "rdbKalınKenar";
            this.rdbKalınKenar.Size = new System.Drawing.Size(102, 21);
            this.rdbKalınKenar.TabIndex = 5;
            this.rdbKalınKenar.Text = "Kalın Kenar";
            this.rdbKalınKenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(131, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(122, 130);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(70, 21);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Peynir";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(122, 103);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 21);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Ton Balığı";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(122, 76);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(74, 21);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Mantar";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(122, 49);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(69, 21);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Sucuk";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(122, 22);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 21);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Salam";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 130);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 21);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Zeytin";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 103);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 21);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Ançuez";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 21);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Mısır";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dana Jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(112, 602);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(52, 22);
            this.txtAdet.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(183, 601);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(97, 23);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(440, 604);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(106, 22);
            this.txtTutar.TabIndex = 11;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(571, 604);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(123, 33);
            this.btnSepeteEkle.TabIndex = 12;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(813, 603);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(145, 34);
            this.btnSiparisiOnayla.TabIndex = 13;
            this.btnSiparisiOnayla.Text = "Siparisi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.HorizontalScrollbar = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(440, 119);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(590, 388);
            this.lstSiparisler.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplam Tutar :";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(904, 524);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 17);
            this.lblTutar.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 665);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbKalınKenar);
            this.Controls.Add(this.rdbInceKenar);
            this.Controls.Add(this.lstPizzalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEbatlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEbatlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.RadioButton rdbInceKenar;
        private System.Windows.Forms.RadioButton rdbKalınKenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSiparisiOnayla;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTutar;
    }
}

