using Microsoft.Build.Tasks.Xaml;
using Newtonsoft.Json;
using RestSharp;
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

namespace Client3B_102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baseUrl = "http://localhost:1908/";
        public bool UpdateDatabase(Mahasiswa mhs)
        {
            bool updated = false;
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("UpdateMahasiswa", Method.PUT);
                request.AddJsonBody(mhs);
                client.Execute(request);
            }
            catch (Exception ex)
            {

            }
            return updated;
        }

        public bool DeleteMahasiswa(string nim)
        {
            bool deleted = false;
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("DeleteByNIM" + nim, Method.DELETE);
                client.Execute(request);
            }
            catch (Exception ex)
            {

            }
            return deleted;
        }

        public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dataGridView1.DataSource = data;

        }

        public void Clear()
        {
            textBoxNIM.Text = "";
            textBoxNama.Text = "";
            textBoxProdi.Text = "";
            textBoxAngkatan.Text = "";
        }

        private void btHitung_Click(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            int length = data.Count();
            labelJumlah.Text = "Jumlah Data : " + Convert.ToString(length);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxNIM.Text != "" &&
                textBoxNama.Text != "" &&
                textBoxProdi.Text != "" &&
                textBoxAngkatan.Text != "")
            {
                if (textBoxNIM.Text.Length <= 12 &&
                textBoxAngkatan.Text.Length <= 4 &&
                textBoxProdi.Text.Length <= 30 &&
                textBoxNama.Text.Length <= 20)
                {
                    try
                    {
                        Mahasiswa mhs = new Mahasiswa();
                        mhs.nim = textBoxNIM.Text;
                        mhs.nama = textBoxNama.Text;
                        mhs.prodi = textBoxProdi.Text;
                        mhs.angkatan = textBoxAngkatan.Text;

                        UpdateDatabase(mhs);
                        MessageBox.Show("Data successfuly updated");

                        TampilData();
                    }
                    catch(Exception ex)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Data harus sesuai dengan panjang data");
                }
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DeleteMahasiswa(textBoxNIM.Text);
                    TampilData();
                    MessageBox.Show("Data successfuly deleted");
                }
                catch (Exception ex)
                {
                    labelJumlah.Text = "Server Error";
                }
            }
        }

        private void buttonLihat_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
