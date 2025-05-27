using System;

public class UserDetails
{
	private static List<User> users = new List<User>();
	public static void AddUser(User user)
    {
        if (user != null && !string.IsNullOrEmpty(user.Username) && !string.IsNullOrEmpty(user.Password))
        {
            users.Add(user);
        }
    }
    public static Boolean IsUserValid(User user)
    {
        return users.Any(u => u.Username == user.Username && u.Password == user.Password);
    }
    public static List<User> GetUsers()
	{
        return users;
	}
}
