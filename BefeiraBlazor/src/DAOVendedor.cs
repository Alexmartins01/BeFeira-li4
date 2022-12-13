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
using static User.Vendedor;


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

            SqlCommand cmd = new SqlCommand("select username password mbway iban from Vendedor", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3]));
            }


            cnn.Close();

            
        }



        public static bool AddVendedor(User.Vendedor v) // Está a adicionar tudo a NULL
        {

            if (v == null) { return false; }

            string username = v.get_username();
            string email = v.get_email();
            string password = v.get_password();
            int rating = v.get_rating();
            string mbway = v.get_mbway();
            string iban = v.get_iban();


            Console.WriteLine("Vendedor:" + username + ";" + email + ";" + password + ";" + rating + ";" + mbway + ";" + iban + ";");



            string sql = "INSERT INTO Vendedor (username,password,rating,mbway,iban) VALUES (@username,@password,@rating,@mbway,@iban)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@username", SqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 45).Value = password;
            cmd.Parameters.Add("@rating", SqlDbType.Int).Value = rating;
            cmd.Parameters.Add("@mbway", SqlDbType.VarChar, 45).Value = mbway;
            cmd.Parameters.Add("@iban", SqlDbType.VarChar, 21).Value = iban;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
            


        }
    }
}

