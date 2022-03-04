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
    /// class Form 2
    /// </summary>
    /// <remarks> Class <c>Form2</c> dapat menampilkan dan mencari data barang dari database (Id, Kode_Barang, Nama_Barang, Stok, Harga) dan juga Login admin </remarks>
    public partial class Form2 : Form
    {
        /// <summary>
        /// koneksi sebagai SqlConnection
        /// </summary>
        private SqlConnection koneksi;
        /// <summary>
        /// koneksi database
        /// </summary>
        private string kstr = "data source=LAPTOP-JTN2HOA8; database=TugasAkhirPABD;User " + "ID=sa;Password=123";
        /// <summary>
        /// adapt sebagai SqlDataAdapter
        /// </summary>
        private SqlDataAdapter adapt;
        /// <summary>
        /// dt sebagai DataTable
        /// </summary>
        private DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  tampilan form
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirPABDDataSet.sparepart' table. You can move, or remove it, as needed.
            this.sparepartTableAdapter1.Fill(this.tugasAkhirPABDDataSet.sparepart);
        }

        /// <summary>
        /// mengarahkan ke form login admin
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        /// <remarks>jika di klik akan mengarahkan ke Form 3</remarks>
        private void btnAlogin_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        ///  button cari data
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        /// <see cref="adapt = new SqlDataAdapter"/>
        /// mencari data di table database sesaui input yang di masukkan
        /// <remarks> mencari data barang dengan input yang di berikan pada textbox </remarks>
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //koneksi ke database
            koneksi = new SqlConnection(kstr); 
            koneksi.Open();

            //mencari data pada tabel sparepart dengan menggunakan nama barang 
            adapt = new SqlDataAdapter("select * from sparepart where nama_barang like '" + tbxSearch.Text + "%'", koneksi);
            dt = new DataTable();                                                
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            //menutup koneksi dengan database
            koneksi.Close();
        }

        /// <summary>
        /// button search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>jika di klik akan mencari data </remarks>
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// menampilkan data table database yang telah di panggil 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
