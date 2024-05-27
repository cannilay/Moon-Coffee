namespace Moon_Coffee
{
    partial class Gecmisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gecmisler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button34 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbUrunAd = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1104, 60);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button1.ImageKey = "kilit.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1019, 16);
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
            // dgvSonuc
            // 
            this.dgvSonuc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuc.Location = new System.Drawing.Point(244, 65);
            this.dgvSonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.RowHeadersWidth = 51;
            this.dgvSonuc.RowTemplate.Height = 24;
            this.dgvSonuc.Size = new System.Drawing.Size(805, 501);
            this.dgvSonuc.TabIndex = 8;
            this.dgvSonuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(12, 107);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(225, 27);
            this.txtAd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(735, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toplam Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Müşteri Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Kategorisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(12, 194);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(225, 27);
            this.txtSoyad.TabIndex = 16;
            // 
            // txtToplam
            // 
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(875, 580);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(171, 26);
            this.txtToplam.TabIndex = 20;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 287);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(225, 28);
            this.cmbKategori.TabIndex = 21;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Checked = false;
            this.dtpTarih.Location = new System.Drawing.Point(12, 471);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(225, 22);
            this.dtpTarih.TabIndex = 22;
            // 
            // cmbUrunAd
            // 
            this.cmbUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunAd.FormattingEnabled = true;
            this.cmbUrunAd.Location = new System.Drawing.Point(12, 380);
            this.cmbUrunAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUrunAd.Name = "cmbUrunAd";
            this.cmbUrunAd.Size = new System.Drawing.Size(225, 28);
            this.cmbUrunAd.TabIndex = 23;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.ImageKey = "arama.jpg";
            this.btnAra.ImageList = this.ımageList2;
            this.btnAra.Location = new System.Drawing.Point(12, 528);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(227, 38);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "arama.jpg");
            // 
            // Gecmisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1061, 618);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbUrunAd);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gecmisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gecmis";
            this.Load += new System.EventHandler(this.Gecmis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbUrunAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}