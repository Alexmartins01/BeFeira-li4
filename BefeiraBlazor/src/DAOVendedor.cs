using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOVendedor
    {
        public static void ReadVendedores()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Vendedor", cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3]));
            }


            cnn.Close();

            
        }



        public static void setVendedor()
        {
            string sql = "INSERT INTO Vendedor (username) values (@username)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            //cmd.Parameters["@username"].Value = v.get_username();
            cmd.ExecuteNonQuery();

            cnn.Close();

        }
    }
}

