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
    public class DAOProduto
    {
        public static void ReadProdutos()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Administrador", cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{3};{4};{5};{6};", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]));
            }


            cnn.Close();


        }

        


        public static bool AddProduto(User.Produto p)
        {

            if (p == null) { return false; }

            int idStand = p.get_idStand();
            double preco = p.get_preco();
            int promocao = p.get_promocao();
            int stock = p.get_stock();
            int categoria = p.get_categoria();
            int rating = p.get_rating();



            string sql = "INSERT INTO Admin (idStand,preco,promocao,stock,rating,categoria) VALUES (@idStand,@preco,@promocao,@stock,@rating,@categoria)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@idStand", SqlDbType.Int).Value = idStand;
            cmd.Parameters.Add("@preco", SqlDbType.Decimal, (6,2)).Value = preco;
            cmd.Parameters.Add("@promocao", SqlDbType.Int).Value = promocao;
            cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
            cmd.Parameters.Add("@rating", SqlDbType.Int).Value = rating;
            cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = categoria;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;



        }
    }
}
