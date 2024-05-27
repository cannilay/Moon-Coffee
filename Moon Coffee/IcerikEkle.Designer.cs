namespace Moon_Coffee
{
    partial class IcerikEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IcerikEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moonCoffeeDataSet2 = new Moon_Coffee.MoonCoffeeDataSet2();
            this.txtIcerikAdi = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIcerikID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.kategoriTableAdapter = new Moon_Coffee.MoonCoffeeDataSet2TableAdapters.KategoriTableAdapter();
            this.moonCoffeeDataSet3 = new Moon_Coffee.MoonCoffeeDataSet3();
            this.ıcerikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icerikTableAdapter = new Moon_Coffee.MoonCoffeeDataSet3TableAdapters.IcerikTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonCoffeeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moonCoffeeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıcerikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 60);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 41;
            this.button2.Text = "Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(21, 14);
            this.button34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(120, 39);
            this.button34.TabIndex = 40;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategori Adı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "İçerik Adı ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adet";
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.DataSource = this.kategoriBindingSource;
            this.cmbKategoriAdi.DisplayMember = "ad";
            this.cmbKategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(27, 66);
            this.cmbKategoriAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategoriAdi.Name = "cmbKategoriAdi";
            this.cmbKategoriAdi.Size = new System.Drawing.Size(204, 28);
            this.cmbKategoriAdi.TabIndex = 11;
            this.cmbKategoriAdi.ValueMember = "ad";
            this.cmbKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.moonCoffeeDataSet2;
            // 
            // moonCoffeeDataSet2
            // 
            this.moonCoffeeDataSet2.DataSetName = "MoonCoffeeDataSet2";
            this.moonCoffeeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIcerikAdi
            // 
            this.txtIcerikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerikAdi.Location = new System.Drawing.Point(32, 256);
            this.txtIcerikAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcerikAdi.Name = "txtIcerikAdi";
            this.txtIcerikAdi.Size = new System.Drawing.Size(203, 27);
            this.txtIcerikAdi.TabIndex = 14;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToOrderColumns = true;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(331, 75);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(696, 438);
            this.dgvSearch.TabIndex = 15;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(31, 446);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(203, 27);
            this.txtFiyat.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fiyat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtIcerikID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbAdet);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFiyat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbKategoriAdi);
            this.panel2.Controls.Add(this.txtIcerikAdi);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 516);
            this.panel2.TabIndex = 19;
            // 
            // txtIcerikID
            // 
            this.txtIcerikID.Enabled = false;
            this.txtIcerikID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerikID.Location = new System.Drawing.Point(27, 162);
            this.txtIcerikID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcerikID.Name = "txtIcerikID";
            this.txtIcerikID.Size = new System.Drawing.Size(203, 27);
            this.txtIcerikID.TabIndex = 45;
            this.txtIcerikID.TextChanged += new System.EventHandler(this.txtIcerikID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "İçerik ID";
            // 
            // cmbAdet
            // 
            this.cmbAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAdet.FormattingEnabled = true;
            this.cmbAdet.Location = new System.Drawing.Point(31, 350);
            this.cmbAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAdet.Name = "cmbAdet";
            this.cmbAdet.Size = new System.Drawing.Size(204, 28);
            this.cmbAdet.TabIndex = 21;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "ekle.jpg";
            this.btnEkle.ImageList = this.ımageList2;
            this.btnEkle.Location = new System.Drawing.Point(691, 532);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(157, 39);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "arama.jpg");
            this.ımageList2.Images.SetKeyName(1, "ekle.jpg");
            this.ımageList2.Images.SetKeyName(2, "guncelle.jpg");
            this.ımageList2.Images.SetKeyName(3, "sil.jpg");
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "sil.jpg";
            this.btnSil.ImageList = this.ımageList2;
            this.btnSil.Location = new System.Drawing.Point(513, 532);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(157, 39);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "guncelle.jpg";
            this.btnGuncelle.ImageList = this.ımageList2;
            this.btnGuncelle.Location = new System.Drawing.Point(869, 532);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(157, 39);
            this.btnGuncelle.TabIndex = 44;
            this.btnGuncelle.Text = "    Güncelle    ";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "arama.jpg";
            this.btnAra.ImageList = this.ımageList2;
            this.btnAra.Location = new System.Drawing.Point(331, 532);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(157, 39);
            this.btnAra.TabIndex = 45;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // moonCoffeeDataSet3
            // 
            this.moonCoffeeDataSet3.DataSetName = "MoonCoffeeDataSet3";
            this.moonCoffeeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıcerikBindingSource
            // 
            this.ıcerikBindingSource.DataMember = "Icerik";
            this.ıcerikBindingSource.DataSource = this.moonCoffeeDataSet3;
            // 
            // icerikTableAdapter
            // 
            this.icerikTableAdapter.ClearBeforeFill = true;
            // 
            // IcerikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IcerikEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IcerikEkle";
            this.Load += new System.EventHandler(this.IcerikEkle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonCoffeeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moonCoffeeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıcerikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbKategoriAdi;
        private System.Windows.Forms.TextBox txtIcerikAdi;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbAdet;
        private MoonCoffeeDataSet2 moonCoffeeDataSet2;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private MoonCoffeeDataSet2TableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private MoonCoffeeDataSet3 moonCoffeeDataSet3;
        private System.Windows.Forms.BindingSource ıcerikBindingSource;
        private MoonCoffeeDataSet3TableAdapters.IcerikTableAdapter icerikTableAdapter;
        private System.Windows.Forms.TextBox txtIcerikID;
        private System.Windows.Forms.Label label1;
    }
}