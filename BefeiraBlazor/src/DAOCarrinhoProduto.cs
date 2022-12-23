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
using static CarrinhoProd.CarrinhoProduto;


namespace DAO
{
    public class DAOCarrinhoProduto
    {
        public static void ReadCarrinhoProduto()
        {

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from CarrinhoProduto", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2};{3};{4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
            }


            cnn.Close();


        }





        public static bool AddCarrinhoProduto(CarrinhoProd.CarrinhoProduto c)
        {

            if (c == null) { return false; }

            int idCarrinho = c.getIdCarrinho();
            int idProduto = c.getIdProduto();
            int quantidade = c.getQuantidade();
            float preco = c.getPreco();
            float taxa = c.getTaxa();





            string sql = "INSERT INTO Carrinho (idCarrinho,idProduto,quantidade,preco,taxa) VALUES (@idCarrinho,@idProduto,@quantidade,@preco,@taxa)";

            string con = @"Data Source=DESKTOP-VM78M9T;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@idCarrinho", SqlDbType.Int).Value = idCarrinho;
            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = quantidade;
            cmd.Parameters.Add("@preco", SqlDbType.Float).Value = preco;
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = taxa;



            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;



        }
    }
}



