using System;

public class Cliente {
	string email;
	string username;
	string password;

	public Cliente(string email, string username, string password) {
		this.email = (String)email.Clone();
		this.password = (String)password.Clone();
		this.username = (String)username.Clone();
	}

	
}
