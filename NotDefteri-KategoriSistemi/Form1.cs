namespace NotDefteri_KategoriSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_kategori.Items.Add(new Kategori("iþ"));
            Cmb_kategori.Items.Add(new Kategori("Kiþisel"));
            Cmb_kategori.Items.Add(new Kategori("Alýþveriþ"));
        }
    }
}
