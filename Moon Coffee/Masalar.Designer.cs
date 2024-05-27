namespace Moon_Coffee
{
    partial class Masalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masalar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button34 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMasa = new System.Windows.Forms.Panel();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.btnKrediKarti = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnNakit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-7, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1757, 60);
            this.panel1.TabIndex = 6;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(19, 14);
            this.button34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(120, 39);
            this.button34.TabIndex = 39;
            this.button34.Text = "Ana Menü";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1695, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kilit.jpg");
            // 
            // pnlMasa
            // 
            this.pnlMasa.Location = new System.Drawing.Point(12, 64);
            this.pnlMasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMasa.Name = "pnlMasa";
            this.pnlMasa.Size = new System.Drawing.Size(1039, 524);
            this.pnlMasa.TabIndex = 7;
            this.pnlMasa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMasa_Paint);
            // 
            // dgvSepet
            // 
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Location = new System.Drawing.Point(1055, 64);
            this.dgvSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.RowHeadersWidth = 51;
            this.dgvSepet.Size = new System.Drawing.Size(679, 379);
            this.dgvSepet.TabIndex = 8;
            // 
            // btnKrediKarti
            // 
            this.btnKrediKarti.BackColor = System.Drawing.Color.White;
            this.btnKrediKarti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKrediKarti.ImageKey = "kart.png";
            this.btnKrediKarti.ImageList = this.ımageList2;
            this.btnKrediKarti.Location = new System.Drawing.Point(1059, 449);
            this.btnKrediKarti.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnKrediKarti.Name = "btnKrediKarti";
            this.btnKrediKarti.Size = new System.Drawing.Size(223, 71);
            this.btnKrediKarti.TabIndex = 63;
            this.btnKrediKarti.Text = "Kredi Kartı  ";
            this.btnKrediKarti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKrediKarti.UseVisualStyleBackColor = false;
            this.btnKrediKarti.Click += new System.EventHandler(this.btnKrediKarti_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "ekle.png");
            this.ımageList2.Images.SetKeyName(1, "kart.png");
            this.ımageList2.Images.SetKeyName(2, "odeme.jpg");
            // 
            // btnNakit
            // 
            this.btnNakit.BackColor = System.Drawing.Color.White;
            this.btnNakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNakit.ImageKey = "odeme.jpg";
            this.btnNakit.ImageList = this.ımageList2;
            this.btnNakit.Location = new System.Drawing.Point(1289, 449);
            this.btnNakit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(223, 71);
            this.btnNakit.TabIndex = 64;
            this.btnNakit.Text = "Nakit      ";
            this.btnNakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNakit.UseVisualStyleBackColor = false;
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(1479, 537);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 67;
            this.label13.Text = "Masa No :";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "ekle.png";
            this.btnEkle.ImageList = this.ımageList2;
            this.btnEkle.Location = new System.Drawing.Point(1520, 449);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(213, 71);
            this.btnEkle.TabIndex = 69;
            this.btnEkle.Text = "      Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(1596, 559);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(129, 27);
            this.txtToplamTutar.TabIndex = 71;
            this.txtToplamTutar.TextChanged += new System.EventHandler(this.txtToplamTutar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1596, 537);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Toplam Tutar :";
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaNo.Location = new System.Drawing.Point(1483, 559);
            this.txtMasaNo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(87, 27);
            this.txtMasaNo.TabIndex = 72;
            this.txtMasaNo.TextChanged += new System.EventHandler(this.txtMasaNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1076, 537);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Müşteri Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1285, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "MüsteriSoyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(1289, 559);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 27);
            this.txtSoyad.TabIndex = 71;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtToplamTutar_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(1080, 560);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 27);
            this.txtAd.TabIndex = 72;
            // 
            // Masalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1740, 606);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnNakit);
            this.Controls.Add(this.btnKrediKarti);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.pnlMasa);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Masalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa";
            this.Load += new System.EventHandler(this.Masa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Panel pnlMasa;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.Button btnKrediKarti;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ImageList ımageList2;
    }
}