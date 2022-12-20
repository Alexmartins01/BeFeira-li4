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
using static Carrinho.Carrinho;


namespace DAO
{
    public class DAOCarrinho
    {
        public static void ReadCarrinho()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Carrinho", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3]));
            }


            cnn.Close();


        }

        



        public static bool AddCarrinho(Carrinho.Carrinho c)
        {

            if (c == null) { return false; }

            int idCarrinho = c.getIdCarrinho();
            int idCliente = c.getIdCliente();
            int idStand = c.getIdStand();
            double total = c.getTotal();





            string sql = "INSERT INTO Carrinho (idCarrinho,idCliente,idStand,total) VALUES (@idCarrinho,@idCliente,@idStand,@total)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@idCarrinho", SqlDbType.Int).Value = idCarrinho;
            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
            cmd.Parameters.Add("@idStand", SqlDbType.Decimal, (6,2)).Value = idStand;
            cmd.Parameters.Add("@total", SqlDbType.Int).Value = total;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;



        }
    }
}


