using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    public partial class OgrenciListeleme : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=ogrenci_islemleri;Uid=root;Pwd=12345");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public OgrenciListeleme()
        {
            InitializeComponent();
        }


        private void OgrenciListeleme_Load(object sender, EventArgs e)
        {

        }
        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            String query = "Select name,surname,ogrNo from ogrenciler";
            adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }

        private void OgrenciListeleme_Load_1(object sender, EventArgs e)
        {
            verigetir();
        }

        private void goMain_Click(object sender, EventArgs e)
        {
            this.Close();

            // Ana ekranı oluştur ve göster
            AnaEkran anaEkran = new AnaEkran(); // AnaEkran yerine kendi ana ekran formunuzun adını kullanmalısınız
            anaEkran.Show();
        }
    }
}
