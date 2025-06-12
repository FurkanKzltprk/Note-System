namespace Not_system_new
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriler.Add(new Kategori("kiþisel"));
            kategoriler.Add(new Kategori("Ýþ"));
            kategoriler.Add(new Kategori("Alýþveriþ"));
            kategoriler.Add(new Kategori("Okul"));
            kategoriler.Add(new Kategori("Dersler"));
            kategoriler.Add(new Kategori("Önemli"));
            kategoriler.Add(new Kategori(txtYeniKategori.Text));

            comboBoxKategori.DataSource = kategoriler;

            notlar = yonetici.Yukle();

            NotlariGoster();   //metod eklenecek
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string icerik = txtIcerik.Text;

            Kategori seciliKategori = comboBoxKategori.SelectedItem as Kategori;

            if (string.IsNullOrEmpty(baslik) || seciliKategori == null)
            {
                MessageBox.Show("Baþlýk ve kategori boþ olamaz");
                return;

            }
            Not yeniNot = new Not(baslik, icerik, seciliKategori);
            notlar.Add(yeniNot);
            yonetici.Kaydet(notlar);

            NotlariGoster();  // metot eklenecek 

            txtBaslik.Clear();
            txtIcerik.Clear();
        }


        private void NotlariGoster(List<Not> filtreliListe = null)
        {
            listBox1.Items.Clear();
            var liste = filtreliListe ?? notlar;

            foreach (var not in liste)
            {
                listBox1.Items.Add(not);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();
            #region varFiltreli1
            //var filtreli = notlar.FindAll(n =>
            //    n.Baslik.ToLower().Contains(aranan) ||
            //    n.Kategori.Ad.ToLower().Contains(aranan)
            //);

            #endregion

            var filtreli = notlar.Where(n => n.Ara(aranan)).ToList();
            NotlariGoster(filtreli);

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string yeniKategoriAd = txtYeniKategori.Text.Trim();

            if (string.IsNullOrWhiteSpace(yeniKategoriAd))
            {
                MessageBox.Show("Kategori adý boþ olamaz.");
                return;
            }

            // Daha önce eklenmiþ mi kontrol et
            if (kategoriler.Exists(k => k.Ad.Equals(yeniKategoriAd, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Bu kategori zaten mevcut.");
                return;
            }

            Kategori yeniKategori = new Kategori(yeniKategoriAd);
            kategoriler.Add(yeniKategori);


            // ComboBox güncelle
            comboBoxKategori.DataSource = null;
            comboBoxKategori.DataSource = kategoriler;



            txtYeniKategori.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Silmek için bir not seçin.");
                return;
            }

            Not seciliNot = listBox1.SelectedItem as Not;
            DialogResult sonuc = MessageBox.Show("Bu notu silmek istediðinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                notlar.Remove(seciliNot);
                yonetici.Kaydet(notlar);
                NotlariGoster();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Not seciliNot = listBox1.SelectedItem as Not;

            txtNotDetay.Text =
                $"Baþlýk: {seciliNot.Baslik}\r\n" +
                $"Kategori: {seciliNot.Kategori.Ad}\r\n" +
                $"Tarih: {seciliNot.Tarih:g}\r\n" +
                $"----------------------------------"+
                $"\r\nÝçerik :\r\n{seciliNot.Icerik}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
