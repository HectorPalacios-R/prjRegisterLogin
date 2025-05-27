using System;
using System.Security.Cryptography.X509Certificates;

public class User
{
	public User(string username, string password)
	{
        Username = username;
        Password = password;
    }
    public User() { }
    public string Username { get; set; }
    public string Password { get; set; }

}
