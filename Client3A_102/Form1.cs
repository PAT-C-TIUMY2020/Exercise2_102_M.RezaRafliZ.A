using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client3A_102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baseurl = "http://localhost:1907/";
        private void btSimpan_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nama = textBoxNama.Text;
            mhs.nim = textBoxNIM.Text;
            mhs.prodi = textBoxProdi.Text;
            mhs.angkatan = textBoxAngkatan.Text;

            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseurl + "Mahasiswa", data);
            Console.WriteLine(response);
            TampilData();
        }

        private void btLihat_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        public void SearchData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            string nim = textBoxCari.Text;
            if (nim == null || nim == "")
            {
                MessageBox.Show("Masukkan NIM yang ingin dicari!");
                dataGridView2.DataSource = null;
            }
            else
            {
                var item = data.Where(x => x.nim == textBoxCari.Text).ToList();

                dataGridView2.DataSource = item;
            }
        }

        public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dataGridView1.DataSource = data;

        }

        public class Mahasiswa
        {
            private string _nama, _nim, _prodi, _angkatan;
            public string nama
            {
                get { return _nama; }
                set { _nama = value; }
            }

            public string nim
            {
                get { return _nim; }
                set { _nim = value; }
            }

            public string prodi
            {
                get { return _prodi; }
                set { _prodi = value; }
            }

            public string angkatan
            {
                get { return _angkatan; }
                set { _angkatan = value; }
            }
        }

        public void Clear()
        {
            textBoxNIM.Text = "";
            textBoxNama.Text = "";
            textBoxProdi.Text = "";
            textBoxAngkatan.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
