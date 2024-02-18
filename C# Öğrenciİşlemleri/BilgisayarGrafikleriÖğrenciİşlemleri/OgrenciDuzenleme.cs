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
    public partial class OgrenciDuzenleme : Form
    {

        MySqlConnection conn = DbHelper.getConnection();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public OgrenciDuzenleme()
        {
            InitializeComponent();
        }

        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            String query = "Select * from ogrenciler";
            adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();

            txtName.Text = "";
            txtSurname.Text = "";
            txtNo.Text = "";
        }

        private void OgrenciDuzenleme_Load(object sender, EventArgs e)
        {
            verigetir();

        }


        void elemanlarıCek()
        {
            if (dgwListe.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgwListe.SelectedRows[0];

                // İsim ve soyisim bilgisini al
                string no = selectedRow.Cells["ogrNo"].Value.ToString();
                string isim = selectedRow.Cells["name"].Value.ToString();
                string soyisim = selectedRow.Cells["surname"].Value.ToString();

                txtName.Text = isim;
                txtSurname.Text = soyisim;
                txtNo.Text = no;

            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }

        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {

                // Ogrenci bilgilerini güncelle
                conn.Open();
                DataGridViewRow selectedRow = dgwListe.SelectedRows[0];

                // İsim ve soyisim bilgisini al
                string id = selectedRow.Cells["id"].Value.ToString();

                string query = "update ogrenciler set name = @name, surname = @surname, ogrNo = @ogrNo where id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@ogrNo", txtNo.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Öğrenci bilgileri başarıyla değiştirildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Hatalı seçim yaptınız lütfen tekrar deneyiniz.");
            }
            finally
            {
                conn.Close();
            }
            verigetir();

        }


        private void dgwListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            elemanlarıCek();
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
