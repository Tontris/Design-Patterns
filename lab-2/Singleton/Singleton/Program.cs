using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();

            Console.WriteLine($"auth1 == auth2: {auth1 == auth2}");
        }
    }
}