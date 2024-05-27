using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Moon_Coffee.Model;

namespace Moon_Coffee
{
    public partial class Form1 : Form
    {
        private readonly MoonCoffeeContext dbContext = new MoonCoffeeContext();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool GirisBilgileriDogruMu(string kullaniciAdi, string sifre)
        {
            try
            {
                var kullanici = dbContext.Kullanici
                    .Where(k => k.ad == kullaniciAdi && k.sifre == sifre)
                    .FirstOrDefault();

                return kullanici != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnKayit_Click_1(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (GirisBilgileriDogruMu(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş başarılı!");

                Gezgin gezginForm = new Gezgin();
                gezginForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
