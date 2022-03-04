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
    /// class Form4
    /// </summary>
    /// <remarks>Form4 dapat mengedit dan menghapus data di table database</remarks>
    public partial class Form4 : Form
    {
        /// <summary>
        /// id dikondisikan menjadi 0
        /// </summary>
        int Id = 0;
        /// <summary>
        /// koneksi sebagai SqlConnection
        /// </summary>
        SqlConnection koneksi = new SqlConnection ( "data source=LAPTOP-JTN2HOA8; database=TugasAkhirPABD;User " + "ID=sa;Password=123");
        /// <summary>
        /// adaptr sebagai SqlDataAdapter
        /// </summary>
        SqlDataAdapter adaptr;
        /// <summary>
        /// cmd sebagai SqlCommand
        /// </summary>
        SqlCommand cmd;

        /// <summary>
        /// menampilkan form 4
        /// </summary>
        public Form4()
        {
            InitializeComponent();
            //memanggil class Display Data
            DisplayData();
        }

        /// <summary>
        /// menampilkan data yang diambil dari table database
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        private void Form4_Load(object sender, EventArgs e)
        {
            //database yang digunakan pada form 4
            // TODO: This line of code loads data into the 'tugasAkhirPABDDataSet1.sparepart' table. You can move, or remove it, as needed.
            this.sparepartTableAdapter2.Fill(this.tugasAkhirPABDDataSet1.sparepart);
        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// menampilkan data table sparepart dari database
        /// </summary>
        private void DisplayData()
        {
            //koneksi dengan tabel spare part untuk di tampilkan 
            koneksi.Open();
            DataTable dt = new DataTable();
            adaptr = new SqlDataAdapter("select * from sparepart", koneksi);
            adaptr.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        /// <summary>
        /// menghapus data yang ada di textbox
        /// </summary>
        private void ClearData()
        {
            //deklrasi textbox kosong
            tbx_IdBrg.Text = "";
            tbx_NmBrg.Text = "";
            tbx_Stok.Text = "";
            tbx_Hrg.Text = "";
            Id = 0;
        }
        
        /// <summary>
        /// menampilkan table data yang di ambil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// mengedit data yang sudah ada di table sparepart database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// mengubah data sesuai dengan urutan textbox jika berhasil akan muncul pesan "Data Berhasil di ubah"
        /// akan muncul pesan jika belum memilih data 
        /// </remarks>
        private void btnUP_Click(object sender, EventArgs e)
        {
            //deklarasi yang digunakan textbox
            if (tbx_IdBrg.Text != "" && tbx_NmBrg.Text != "" && tbx_Stok.Text != "" && tbx_Hrg.Text != "")
            {
                //perintah mengubah data pada tabel sparepart
                cmd = new SqlCommand("update sparepart set kode_barang=@kode_barang,nama_barang=@nama_barang,stok=@stok, harga=@harga where Id = @Id", koneksi);
                //mwmbuka koneksi dengan databasse
                koneksi.Open();
                //menambah data sesuai dengan yang di ketik pada textbox
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@kode_barang", tbx_IdBrg.Text);
                cmd.Parameters.AddWithValue("@nama_barang", tbx_NmBrg.Text);
                cmd.Parameters.AddWithValue("@stok", tbx_Stok.Text);
                cmd.Parameters.AddWithValue("@harga", tbx_Hrg.Text);
                //eksekusi
                cmd.ExecuteNonQuery();
                //jika data berhasil diubah akan muncul pesan di bawah ini
                MessageBox.Show("Data Berhasil Diubah");
                //menutup koneksi
                koneksi.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                //jika belum ada data yang di pilih maka akan muncul pesan ini
                MessageBox.Show("Pilih Data Sebelum di Update");
            }
        }

        /// <summary>
        /// button menghapus data dari teble sparepart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// memilih data dulu dengan paramter ID yang akan di hapus
        /// jika berhasil akan muncul pesan
        /// jika belum memilih data juga akan muncul pesan
        /// </remarks>
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            //deklarasi jika Id = 0
            if (Id != 0)
            {
                //perintah untuk menghapus data pada table spare part 
                cmd = new SqlCommand("delete sparepart where Id=@Id", koneksi);
                //membuka koneksi database diatas
                koneksi.Open();
                //memilih data yang di klik
                cmd.Parameters.AddWithValue("@Id", Id);
                //eksekui
                cmd.ExecuteNonQuery();
                //menutup koneksi database
                koneksi.Close();
                //jika berhasil menghapus data akan menucul pesan sepert di bawah 
                MessageBox.Show("Data Berhasil Dihapus!");
                DisplayData();
                ClearData();
            }
            else
            {
                //jika tidak ada data yang di pilih akan muncul pesan seperti ini
                MessageBox.Show("Pilih Data Untuk DIhapus");
            }
        }

        /// <summary>
        /// menampilkan data sesui dengan table database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //mengkoneksikan datagridview dengan textbox
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbx_IdBrg.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbx_NmBrg.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_Stok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_Hrg.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        /// <summary>
        /// textbox harga barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Hrg_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// button untuk ke form 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            //button mengarahkan ke form 5
            Form5 fm = new Form5();
            fm.Show();
            this.Hide();
        }

        /// <summary>
        /// textbox kode barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_IdBrg_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox nama barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_NmBrg_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox stok barang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Stok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
