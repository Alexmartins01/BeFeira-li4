using Carrinho;
using stand;
using System;

namespace client { 

public class Cliente {
	string email;
	string username;
	string password;

	public Cliente(string email, string username, string password) {
		this.email = (String)email.Clone();
		this.password = (String)password.Clone();
		this.username = (String)username.Clone();
	}


        public string getemail()
        {
            return email;
        }

        public string getusername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
      


    }
}
