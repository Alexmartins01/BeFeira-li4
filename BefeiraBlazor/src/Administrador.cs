using System;

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
}
