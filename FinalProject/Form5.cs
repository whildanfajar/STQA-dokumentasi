using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    /// <summary>
    /// class Form5
    /// </summary>
    /// <remarks> Form 5 daapat melakukan tambah data (add) </remarks>
    public partial class Form5 : Form
    {
        /// <summary>
        /// koneksi deklarasi sebagai SqlConnection
        /// </summary>
        SqlConnection koneksi = new SqlConnection("data source=LAPTOP-JTN2HOA8; database=TugasAkhirPABD;User " + "ID=sa;Password=123");
        /// <summary>
        /// adaptr sebagai SqlDataAdapter
        /// </summary>
        SqlDataAdapter adaptr;
        /// <summary>
        /// cmd sebagai SqlCommand
        /// </summary>
        SqlCommand cmd;
        /// <summary>
        /// menampilkan form 5
        /// </summary>
        public Form5()
        {
            InitializeComponent();
            // memanggil class Display Data
            DisplayData();
        }

        /// <summary>
        /// menampilkan data dari table database yang diambil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// menampilkan data yang ada di table database
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        private void Form5_Load(object sender, EventArgs e)
        {
            //database yang digunakan pada form5
            // TODO: This line of code loads data into the 'tugasAkhirPABDDataSet2.sparepart' table. You can move, or remove it, as needed.
            this.sparepartTableAdapter.Fill(this.tugasAkhirPABDDataSet2.sparepart);

        }

        /// <summary>
        /// button untuk ke Form 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //button yang mengarah ke form 4
            Form4 fm = new Form4();
            fm.Show();
            this.Hide();
        }

        /// <summary>
        /// menambahkan data pada table database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// menambahkan data pada database melalui textbox yang sesuai
        /// jika berhasil atau gagal akan muncul pesan
        /// </remarks>
        private void btnADD_Click(object sender, EventArgs e)
        {
            // deklarasi jika textbox kosong 
            if (tbx_Id.Text != "" && tbx_Kode.Text != "" && tbx_Nama.Text != "" && tbx_Stok.Text != "" && tbx_Harga.Text != "")
            {
                koneksi.Open();
                //perintah menambah data pada tabel spare part
                cmd = new SqlCommand("insert into sparepart(Id,kode_barang,nama_barang,stok,harga) values(@Id,@kode_barang,@nama_barang,@stok,@harga)", koneksi);
                //memasukkan data ke dalam tabel spare part dengan textbox
                cmd.Parameters.AddWithValue("@Id", tbx_Id.Text);
                cmd.Parameters.AddWithValue("@kode_barang", tbx_Kode.Text);
                cmd.Parameters.AddWithValue("@nama_barang", tbx_Nama.Text);
                cmd.Parameters.AddWithValue("@stok", tbx_Stok.Text);
                cmd.Parameters.AddWithValue("@harga", tbx_Harga.Text);
                //eksekusi data
                cmd.ExecuteNonQuery();
                //membuka koneksi database diatas 
                koneksi.Close();
                //jika data berhasil di tambah akan muncul pesan seperti dibawah
                MessageBox.Show("Data Berhasil Ditambahkan");
                DisplayData();
                ClearData();
            }
            else
            {
                //jika textbox kosong atau tidak lengkap maka akan muncul pesan ini
                MessageBox.Show("Anda Belum Mengisi Data atau Data Belum Lengkap");
            }
        }

        /// <summary>
        /// menampilkan data di table
        /// </summary>
        /// <remarks>
        /// data yang ditmpilkan dari table sparepart 
        /// </remarks>
        private void DisplayData()
        {
            //koneksi dengan tabel sparepart untuk ditampilkan
            koneksi.Open();
            DataTable dt = new DataTable();
            adaptr = new SqlDataAdapter("select * from sparepart", koneksi);
            adaptr.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        /// <summary>
        /// deklarasi pada textbox 
        /// </summary>
        private void ClearData()
        {
            //deklarasi textbox kosong
            tbx_Id.Text = "";
            tbx_Kode.Text = "";
            tbx_Nama.Text = "";
            tbx_Stok.Text = "";
            tbx_Harga.Text = "";
        }

        /// <summary>
        /// button untuk kembali ke form 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //jika button diklik akan memunculkan pesan ini
            MessageBox.Show("Yakin Keluar Dari Akses Admin?");
            //button mengarahkan ke form 2
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        /// <summary>
        /// textbox untuk input ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Id_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox untuk input kode barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Kode_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox untuk input Nama barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Nama_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox untuk input stok barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Stok_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox untuk input harga barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Harga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
