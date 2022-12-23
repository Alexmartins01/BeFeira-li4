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
    public class DAOStand
    {
        public static void ReadStand()
        {

            string con = @"Data Source=DESKTOP-HUGO;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            cnn.Open();
            // fazer cenas

            SqlCommand cmd = new SqlCommand("select * from Stand", cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0};{1};{2}", reader[0], reader[1], reader[2]));
            }


            cnn.Close();

            
        }



        public static bool AddStand(stand.Stand st)
        {

            if (st == null) { return false; }

            int idStand =st.getIdStand();
            int idVendedor = st.getIdVendedor();
            int idFeira = st.getIdFeira();


            Console.WriteLine("Stand:" + idStand + ";" + idVendedor + ";" + idFeira +";");



            string sql = "INSERT INTO Stand (idStand,IdVendedor,idFeira) VALUES (@idStand,@idVendedor,@idFeira)";

            string con = @"Data Source=DESKTOP-HUGO;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@idStand", SqlDbType.Int).Value = idStand;
            cmd.Parameters.Add("@idVendedor", SqlDbType.Int).Value = idVendedor;
            cmd.Parameters.Add("@idFeira", SqlDbType.Int).Value = idFeira;

            List<subcat.SubCategoria> sc = st.getSubCats();

            foreach(subcat.SubCategoria item in sc)
            {
                AddSubCat(item);
            }


            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
            
        }


        public static bool AddSubCat(subcat.SubCategoria sc)
        {

            if (sc == null) { return false; }

            int idStand =sc.getIdStand();
            int idsubCategoria = sc.getIdsubCategoria();
            string descricao = sc.getDescricao();


            string sql = "INSERT INTO SubCategorias (idStand,idsubCategoria,descricao) VALUES (@idStand,@idsubCategoria,@descricao)";

            string con = @"Data Source=DESKTOP-HUGO;Initial Catalog=Befeira;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(con);

            SqlCommand cmd = new SqlCommand(sql, cnn);


            cmd.Parameters.Add("@idStand", SqlDbType.Int).Value = idStand;
            cmd.Parameters.Add("@idsubCategoria", SqlDbType.Int).Value = idsubCategoria;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;


            cnn.Open();


            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
            
        }


    }
}


