using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NotDefteri_KategoriSistemi
{
    public partial class Form1 : Form
    {
        List<Not> notlar = new List<Not>();
        List<Kategori> kategoriler = new List<Kategori>();
        NotYonetici yonetici = new NotYonetici();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Örnek kategoriler ekleniyor
            kategoriler.Add(new Kategori("Kiþisel"));
            kategoriler.Add(new Kategori("Ýþ"));
            kategoriler.Add(new Kategori("Alýþveriþ"));

            comboBoxKategori.DataSource = kategoriler;

            // Kayýtlý notlar yükleniyor
            notlar = yonetici.Yukle();

            NotlariGoster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string icerik = txtIcerik.Text;
            Kategori seciliKategori = comboBoxKategori.SelectedItem as Kategori;

            if (string.IsNullOrWhiteSpace(baslik) || seciliKategori == null)
            {
                MessageBox.Show("Baþlýk ve kategori boþ olamaz.");
                return;
            }

            Not yeniNot = new Not(baslik, icerik, seciliKategori);
            notlar.Add(yeniNot);
            yonetici.Kaydet(notlar);

            NotlariGoster();

            txtBaslik.Clear();
            txtIcerik.Clear();
        }

        private void NotlariGoster()
        {
            listBox1.Items.Clear();
            foreach (var not in notlar)
            {
                listBox1.Items.Add(not);
            }
        }
    }
}
