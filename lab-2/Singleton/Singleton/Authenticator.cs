using System;

public class Authenticator
{
    private static Authenticator instance;
    private static readonly object lockObject = new object();

    private Authenticator() { }

    public static Authenticator GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new Authenticator();
            }
            return instance;
        }
    }

    public bool AuthenticateUser(string username, string password)
    {
        UserData userData = RetrieveUserData(username);
        if (userData != null)
        {
            if (userData.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public UserData RetrieveUserData(string username)
    {
        if (username == "admin")
        {
            return new UserData { Username = "admin", Password = "admin123" };
        }
        else
        {
            return null;
        }
    }

    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}