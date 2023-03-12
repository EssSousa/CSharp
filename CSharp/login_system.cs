using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Login
{
    public static class Global
    {
        public static string name;
    }

    public class Usuario
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario(string nomeUsuario, string senha)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }


    class Programa
    { 

        static void registar()
        {


            Usuario user = new Usuario("Sousa", "12345678");
            Console.Write(user.NomeUsuario);
            Console.Write(user.Senha);

            string Nomeusuario = user.NomeUsuario;
            string Senha = user.Senha;
        }
        static void Main()
        {
            registar();
        }
    }
}