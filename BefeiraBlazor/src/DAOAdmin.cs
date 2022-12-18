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
    public class DAOAdmin
    {
        public static void ReadAdmins()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Administrador", cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};", reader[1], reader[4]));
            }


            cnn.Close();


        }

       

        public static int ValidAdmin(string username, string password)
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();

            SqlCommand cmd = new SqlCommand("select * from Admin", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                if (reader[4].Equals(username))
                {

                    if (reader[1].Equals(password))
                    {
                        return (int)reader[0];
                    }
                    else return -1;
                }

            }


            cnn.Close();


            return 0;

        }


        public static bool AddAdmin(User.Admin a)
        {

            if (a == null) { return false; }

            string username = a.get_username();
            string password = a.get_password();


            Console.WriteLine("Cliente:" + username + ";" + password + ";");



            string sql = "INSERT INTO Admin (username,password) VALUES (@username,@password)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@username", SqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 45).Value = password;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;



        }
    }
}


