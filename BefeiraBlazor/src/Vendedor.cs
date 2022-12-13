using System;
using static DAO.DAOVendedor;

namespace User
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

            Vendedor v = new Vendedor("1@email.com", "1", "1234", "931234567", "12345678900");

            Console.WriteLine("Hello World");


            //DAO.DAOVendedor.ReadVendedores();

            bool b = DAO.DAOVendedor.AddVendedor(v);

            if (b)
            {
                Console.WriteLine("True");
            }

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

        public Vendedor(string email, string username, string password, string mbway, string iban, int rating)
        {
            this.email = (String)email.Clone();
            this.username = (String)username.Clone();
            this.password = (String)password.Clone();
            this.rating = rating;
            this.mbway = (String)mbway.Clone();
            this.iban = (String)iban.Clone();
        }

        public string get_username()
        {
            return (String)this.username.Clone();
        }

        public string get_email()
        {
            return (String)this.email.Clone();
        }

        public string get_password()
        {
            return (String)this.password.Clone();
        }

        public string get_iban()
        {
            return (String)this.iban.Clone();
        }

        public string get_mbway()
        {
            return (String)this.mbway.Clone();
        }

        public int get_rating()
        {
            return this.rating;
        }



    }

}
