using System;

namespace Login
{
    class person
    {
        public string name;
        public string password;
        public string email;
    }

    class Programa
    {
        static void Main()
        {
            person user = new person();
            user.name = Console.ReadLine();
            user.password = Console.ReadLine();
            user.email = Console.ReadLine();
        }
    }
}