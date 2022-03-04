using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// main class form 3
    /// </summary>
    /// <remarks> Class form 3 untuk melankukan login admin (memasukkan Username dan Password) 
    /// menyetel username dan password untuk data login
    /// </remarks>
    public partial class Form3 : Form
    {
        readonly string Username = "whildan"; 
        readonly string Password = "103";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// konfirmasi data login
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        /// <remarks> 
        /// input username dan password pada textbox
        /// konfirmasi apakah username dan password yang di input sesuai 
        /// jika benar atau salah akan muncul pesan
        /// jika berhasil akan lanjut ke form 5
        /// </remarks>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // verifikasi input data yang di masukkan sesuai dengan username dan passwrod yang telah diatur
            if (tbxUsNm.Text == Username && tbxPass.Text == Password) 
            {
                //memunculkan pesan Login sukses
                MessageBox.Show("Login Sukses");

                //jika login berhasil akan berpindah ke form 5
                Form5 fm = new Form5();
                fm.Show();
                this.Hide();
            }
            //kondisi jika username dan password kosong
            else if (tbxUsNm.Text == "" || tbxPass.Text == "") 
            {
                //pesan akan muncul jika username dan  password kosong
                MessageBox.Show("Isi Form Login");
            }
            else
            {
                //jika password dan username tidak sesuai maka akan muncul pesan ini
                MessageBox.Show("Username atau Password Salah "); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// button kembali ke form 2
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol yang terdapat di dalam event</param>
        /// <param name="e">parameter yang berisi data informasi dari event</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //button yang mengarahkan kembali pada form 2
            Form2 fm = new Form2(); 
            fm.Show();
            this.Hide();
        }

        /// <summary>
        /// textbox untuk input username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxUsNm_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// textbox untuk input password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
