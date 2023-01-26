using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DatabasePart2
{
    internal class ConnectDb
    {
        private string BaglantiAdresi = "Data Source=batu\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = null;
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        public ConnectDb() {
            con = new SqlConnection(BaglantiAdresi);
            cmd = new SqlCommand();

        }

        public bool insertClassData(String className, int capacity)
        {
            bool cond = false;

            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO SINIF VALUES (@sınıfad, @kapasite)";
            cmd.Parameters.AddWithValue("@sınıfad", className);
            cmd.Parameters.AddWithValue("@kapasite", capacity);
            con.Open();
            cmd.ExecuteNonQuery();
            cond = true;
            con.Close();

            return cond;
        }
        public void getData()
        {
            
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM sınıf";
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.Write(dr["sınıfAd"]);
            }

            dr.Close();
            con.Close();
        }
        public bool deleteClassData(int id)
        {
            bool cond = false;

            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM SINIF WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            cond = true;
            con.Close();

            return cond;
        }
        public bool updateClassData(int id, int capacity)
        {
            bool cond = false;

            cmd.Connection = con;
            cmd.CommandText = "UPDATE SINIF SET kapasite=@kap where id=@id";
            cmd.Parameters.AddWithValue("@kap", capacity);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            cond = true;
            con.Close();

            return cond;
        }

        public void runProcedure()
        {
            con.Open();
            cmd = new SqlCommand("sp_Kapasite", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
                Console.WriteLine("kapasite : " + rdr["kapasite"]);
           
        }
    }
}
