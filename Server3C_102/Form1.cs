using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service3B_102;

namespace Server3C_102
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceHost hostObjek = null;

			try
			{
				hostObjek = new ServiceHost(typeof(Service1));
				hostObjek.Open();
				label1.Text = "ON";
				label2.Text = "Klik OFF Untuk Mematikan";
				button1.Enabled = false;
				button2.Enabled = true;
			}
			catch (Exception ex)
			{
				hostObjek = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ServiceHost hostObjek;

			try
			{
				hostObjek = new ServiceHost(typeof(Service1));
				hostObjek.Close();
				label2.Text = "OFF";
				label1.Text = "Klik ON Untuk Menghidupkan";
				button1.Enabled = true;
				button2.Enabled = false;
			}
			catch (Exception ex)
			{
				hostObjek = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
	}
}