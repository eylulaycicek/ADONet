using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetOrnek2
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=DESKTOP-99V8I6Q\\SQLEXPRESS;database=Northwind;Integrated Security=true");

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListele();

        }

        private void KategoriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("KategoriListesi", baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; //stored procedure ile kategori getirme
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgv_kategori.DataSource = dt;
            dgv_kategori.Columns["CategoryID"].Visible = false;
        }

        private void btn_katekle_Click(object sender, EventArgs e)
        {
            string CategoryName=txt_kadad.Text;
            string Description = txt_tanim.Text;

            if(CategoryName==" " || Description==" ")
            {
                MessageBox.Show("Kategori bilgileri boş geçilemez");
            }
            else
            {
                //SqlCommand komut = new SqlCommand();
                //komut.CommandText = "insert into Categories (CategoryName,Description) values(@kulAd,@tanim)";
                //komut.Connection= baglanti;
                //komut.Parameters.AddWithValue("@kulad", txt_kadad.Text);
                //komut.Parameters.AddWithValue("@tanim", txt_tanim.Text);  

                SqlCommand cmd = new SqlCommand("KategoriEkle",baglanti);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kategoriad", CategoryName);
                cmd.Parameters.AddWithValue("@acıklama",Description);



                baglanti.Open();

                try
                {
                    int sonuc = cmd.ExecuteNonQuery();
                    baglanti.Close();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı.");
                        KategoriListele();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız oldu.");
                    }
                }
                catch(Exception ex)
                {
                  MessageBox.Show(ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kategori.CurrentRow != null) //eğer seçilmiş satır varsa
            {
                int id = Convert.ToInt32(dgv_kategori.CurrentRow.Cells["CategoryID"].Value);
                //SqlCommand cmd = new SqlCommand();
                ////cmd.CommandText = "delete Products where ProductID=" + id;
                //cmd.CommandText = string.Format("delete Categories where CategoryID={0}", id);

                SqlCommand cmd = new SqlCommand("KategoriSil", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id); //???



                baglanti.Open();
                int sonuc = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                    KategoriListele();
                }
                else
                {
                    MessageBox.Show("Kayıt silme işlemi sırasında hata oluştu");
                }

            } 

            
        }

        private void dgv_kategori_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv_kategori.CurrentRow.Cells["CategoryID"].Value);
            string kad = dgv_kategori.CurrentRow.Cells["CategoryName"].Value.ToString();
            string tanim = dgv_kategori.CurrentRow.Cells["Description"].Value.ToString();
            SqlCommand cmd = new SqlCommand("KategoriGuncelle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kId", id);
            cmd.Parameters.AddWithValue("@kAd", kad);
            cmd.Parameters.AddWithValue("@tanim", tanim);
            baglanti.Open() ;
            cmd.ExecuteNonQuery() ;
            baglanti.Close();

        }
    }
}
