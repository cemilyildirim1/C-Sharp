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
using System.Xml.Linq;

namespace BilgisayarGrafikleriÖğrenciİşlemleri
{

    public partial class OgrenciSilme : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=ogrenci_islemleri;Uid=root;Pwd=12345");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public OgrenciSilme()
        {
            InitializeComponent();
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

        private void OgrenciSilme_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwListe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgwListe.SelectedRows[0];

                // İsim ve soyisim bilgisini al
                string no = selectedRow.Cells["ogrNo"].Value.ToString();
                string isim = selectedRow.Cells["name"].Value.ToString();
                string soyisim = selectedRow.Cells["surname"].Value.ToString();

                DialogResult result = MessageBox.Show($"'{isim} {soyisim}' kişisini silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM ogrenciler WHERE ogrNo = @ogrNo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ogrNo", no);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Öğrenci başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    verigetir();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
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
