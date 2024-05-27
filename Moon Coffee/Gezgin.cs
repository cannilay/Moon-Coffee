using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Coffee
{
    public partial class Gezgin : Form
    {
        public static string GirisYapanKullaniciUnvani = "Patron"; 
        public Gezgin()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masalar masa = new Masalar();
            masa.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gecmisler gecmis = new Gecmisler();   
            gecmis.Show();  
            this.Close();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kullanıcılar kullanıcılar = new Kullanıcılar();
            kullanıcılar.Show();
            this.Close();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); 
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();   
            this.Close();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
                if (GirisYapanKullaniciUnvani == "Patron")
                {
                    Kullanıcılar form = new Kullanıcılar();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erişim izniniz yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gezgin_Load(object sender, EventArgs e)
        {

        }
    }
}
