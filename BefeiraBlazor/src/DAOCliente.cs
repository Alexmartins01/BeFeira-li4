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
    public class DAOCliente
    {
        public static void ReadClientes()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Cliente", cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3]));
            }


            cnn.Close();


        }

        public static int ValidCliente(string username, string password)
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();

            SqlCommand cmd = new SqlCommand("select * from Cliente", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                if (reader[1].Equals(username))
                {

                    if (reader[2].Equals(password))
                    {
                        return (int)reader[0];
                    }
                    else return -1;
                }

            }


            cnn.Close();


            return 0;

        }



        public static bool AddCliente(User.Cliente c)
        {

            if (c == null) { return false; }

            string username = c.get_username();
            string email = c.get_email();
            string password = c.get_password();


            Console.WriteLine("Cliente:" + username + ";" + email + ";" + password + ";");



            string sql = "INSERT INTO Cliente (username,password,email) VALUES (@username,@password,@email)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@username", SqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 45).Value = password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 45).Value = email;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;



        }
    }
}

