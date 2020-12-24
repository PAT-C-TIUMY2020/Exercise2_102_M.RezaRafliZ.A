using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service3B_102
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string CountMahasiswa()
        {
            throw new NotImplementedException();
        }

        public string DeleteByNIM(string nim)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source =WINDOWS-C8ATAQL; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =pacitan1");
            string query = "delete from dbo.Mahasiswa where NIM = '" + nim + "'";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                msg = "Sukses";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }


            return msg;
        }

        public string UpdateMahasiswa(string nim, string nama, string prodi, string angkatan)
        {
            try
            {
                string constring = "Data Source =WINDOWS-C8ATAQL; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =pacitan1";
                SqlConnection connection;
                SqlCommand com;

                string sql2 = "update Mahasiswa SET Nama ='" + nama + "', Prodi ='" + prodi + "', Angkatan ='" + angkatan + "' where NIM = '" + nim + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql2, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                return "sukses";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
