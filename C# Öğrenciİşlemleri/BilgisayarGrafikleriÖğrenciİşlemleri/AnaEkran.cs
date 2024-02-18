namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            
            OgrenciEkleme ogrenciEkleme = new OgrenciEkleme();
            
            ogrenciEkleme.Visible = true;
            
            ogrenciEkleme.Show();
            this.Hide();

        }

        private void Listeleme_Click(object sender, EventArgs e)
        {
            
            OgrenciListeleme ogrenciListeleme = new OgrenciListeleme();
            ogrenciListeleme.Visible = true;
            ogrenciListeleme.Show();
            this.Hide();
        }

        private void OgrenciSilme_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciSilme ogrenciSilme = new OgrenciSilme();
            ogrenciSilme.Visible = true;
            ogrenciSilme.Show();

        }

        private void OgrenciDuzenleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciDuzenleme ogrenciDuzenleme = new OgrenciDuzenleme();
            ogrenciDuzenleme.Visible = true;
            ogrenciDuzenleme.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}