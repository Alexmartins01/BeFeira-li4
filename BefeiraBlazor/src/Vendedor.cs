using System;
using static DAO.DAOVendedor;

namespace VendedorAplication
{
    public class Vendedor
    {
        string email;
        string username;
        string password;
        int rating;
        string mbway;
        string iban;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");


            DAO.DAOVendedor.ReadVendedores();

        }

        public Vendedor(string email, string username, string password, string mbway, string iban)
        {
            this.email = (String)email.Clone();
            this.username = (String)username.Clone();
            this.password = (String)password.Clone();
            this.rating = 0;
            this.mbway = (String)mbway.Clone();
            this.iban = (String)iban.Clone();
        }

        public string get_username()
        {
            return (String)this.username.Clone();
        }



    }

}
