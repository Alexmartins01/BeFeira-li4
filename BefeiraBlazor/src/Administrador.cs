using System;

namespace admin
{
	public class Administrador
	{
		int idAdministrador;
		string username;
		string password;

		public Administrador(int idAdministrador, string username, string password)
		{
			this.idAdministrador = idAdministrador;
			this.username = (String)username.Clone();
			this.password = (String)password.Clone();

		}

		public int getidAdministrador()
		{
			return this.idAdministrador;
		}
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string pass)
        {
             this.password = pass;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setidAdmin(int id)
        {
            this.idAdministrador = id;
        }


    }


}
