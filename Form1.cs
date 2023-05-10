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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=DESKTOP-99V8I6Q\\SQLEXPRESS;database=Northwind;Integrated Security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void UrunListele()
        {
            //Disconnected mimari
            SqlDataAdapter adp = new SqlDataAdapter("select* from Products where Discontinued=0", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt); //adapterdan dönen bilgiyi data table'a doldur dedik

            dgv_urunler.DataSource = dt;
            dgv_urunler.Columns["ProductID"].Visible = false; //ıd görünmesin
            dgv_urunler.Columns["SupplierID"].Visible = false;
            dgv_urunler.Columns["CategoryID"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ProductName=txt_urunad.Text;
            decimal UnitPrice = nud_fiyat.Value;
            decimal UnitsInStock = nud_stok.Value;

            if(ProductName==" " || UnitPrice == 0 || UnitsInStock == 0)
            {
                MessageBox.Show("Ürün bilgileri boş geçilemez");

            }
            else
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Products (ProductName,UnitPrice,UnitsInStock)values(@urunAdi,@fiyat,@stok)";
                komut.Parameters.AddWithValue("@urunAdi", ProductName);
                komut.Parameters.AddWithValue("@fiyat",UnitPrice);
                komut.Parameters.AddWithValue("@stok", UnitsInStock);

                komut.Connection = baglanti;
                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery(); //bu sefer yazdırdığımız için execute reader kullanmıyoruz
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı.");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.");
                }

            }
                      
        }

        private void btn_kategoriler_Click(object sender, EventArgs e)
        {
            KategoriForm kf;
            if (Application.OpenForms["KategoriForm"] == null)
            {
                kf=new KategoriForm();
                kf.Show();
            }
            else
            {
                kf = (KategoriForm)Application.OpenForms["KategoriForm"];
                kf.Focus();
            }
        }
        private void dgv_urunler_Click(object sender, EventArgs e)
        {
            txt_urunad.Text = dgv_urunler.CurrentRow.Cells["ProductName"].Value.ToString();
            nud_fiyat.Value = (decimal)dgv_urunler.CurrentRow.Cells["UnitPrice"].Value;
            nud_stok.Value = Convert.ToInt16(dgv_urunler.CurrentRow.Cells["UnitsInStock"].Value);
            txt_urunad.Tag = dgv_urunler.CurrentRow.Cells["ProductID"].Value; //urunadın tagine attık tag her türlü değikeni alır burada fiyat ya da stoğa da atabilirdik
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string fiyat = nud_fiyat.Value.ToString().Replace(',', '.');
          
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("update Products set ProductName=@urunAd,UnitPrice=@fiyat,UnitsInStock=@stok where ProductID={3}", txt_urunad.Text,fiyat, nud_stok.Value,txt_urunad.Tag);
            komut.Parameters.AddWithValue("@urunAd", txt_urunad.Text);
            komut.Parameters.AddWithValue("@fiyat",nud_fiyat.Value);
            komut.Parameters.AddWithValue("@stok", nud_stok.Value);

            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        //btn_clickte commandtext'te parametre aldık çünkü üürün adına: insert into Products ('elma2',1,1) drop table --'1,1) yazarsak
        //bu fadeyi komple isim olarak algılayacak ama sorguda tabloyu drop edecek amacımız bunu engellemek sadece değişken almasını sağlamak

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.CurrentRow != null) //eğer ürün satırı seçildiyse
            {
                int id = Convert.ToInt32(dgv_urunler.CurrentRow.Cells["ProductID"].Value);
                //SqlCommand cmd = new SqlCommand();
                ////cmd.CommandText = "delete Products where ProductID=" + id;
                //cmd.CommandText = string.Format("delete Products where ProductID={0}", id);
                //cmd.Connection = baglanti;

                //stored procedure ile ürüm silme
                SqlCommand cmd=new SqlCommand("UrunSil",baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@urunadi", txt_urunad.Text);


                baglanti.Open();


                int sonuc = cmd.ExecuteNonQuery();
                baglanti.Close();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Kayıt silme işlemi sırasında hata oluştu");
                }
            }
        }

        private void sp_ekle_Click(object sender, EventArgs e) //stored procedure ile ürün ekleme
        {
            SqlCommand cmd=new SqlCommand("Urunekle",baglanti);
            cmd.CommandType = System.Data.CommandType.StoredProcedure; //komutun stored procedure olduğunu belirttik
            cmd.Parameters.AddWithValue("@adı",txt_urunad.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", nud_fiyat.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", nud_stok.Value);

            baglanti.Open();
            int sonuc = cmd.ExecuteNonQuery();
            baglanti.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Başarılı.");
                UrunListele();
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız oldu.");
            }

        }
    }
}
