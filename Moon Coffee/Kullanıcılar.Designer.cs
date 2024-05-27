namespace Moon_Coffee
{
    partial class Kullanıcılar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcılar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button34 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 8;
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
            this.dgvSonuc.Location = new System.Drawing.Point(16, 262);
            this.dgvSonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.RowHeadersWidth = 51;
            this.dgvSonuc.RowTemplate.Height = 24;
            this.dgvSonuc.Size = new System.Drawing.Size(1035, 327);
            this.dgvSonuc.TabIndex = 9;
            this.dgvSonuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSonuc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(348, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(348, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(355, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-Posta :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(16, 94);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(208, 27);
            this.txtID.TabIndex = 18;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(16, 150);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(208, 27);
            this.txtAd.TabIndex = 19;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(16, 207);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(208, 27);
            this.txtSoyad.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(352, 149);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(208, 27);
            this.txtTelefon.TabIndex = 21;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(352, 206);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(208, 27);
            this.txtEposta.TabIndex = 22;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(352, 91);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(208, 28);
            this.cmbCinsiyet.TabIndex = 26;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "arama.jpg");
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(643, 89);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(208, 27);
            this.txtAdres.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(639, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(639, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Unvan :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(643, 148);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(208, 28);
            this.cmbUnvan.TabIndex = 33;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(923, 128);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(123, 62);
            this.btnListele.TabIndex = 35;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(923, 62);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(123, 62);
            this.btnDuzenle.TabIndex = 36;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(923, 194);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 62);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Kullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kullanıcılar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Kullanıcılar_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
    }
}