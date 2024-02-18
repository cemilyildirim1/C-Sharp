using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    public partial class OgrenciEkleme : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=ogrenci_islemleri;Uid=root;Pwd=12345");

        public OgrenciEkleme()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("")){
                MessageBox.Show("Alanları doldurunuz.");
            }else if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Alanları doldurunuz.");
            }
            else if (txtNo.Text.Equals(""))
            {
                MessageBox.Show("Alanları doldurunuz.");
            }else if(int.TryParse(txtNo.Text,out int result) == false){
                MessageBox.Show("No alanınına tam sayı giriniz." + result);
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO ogrenciler (name, surname, ogrNo) VALUES (@name, @surname, @ogrNo)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@ogrNo", txtNo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :Kayıtlı bir numara girdiniz." );
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {

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
