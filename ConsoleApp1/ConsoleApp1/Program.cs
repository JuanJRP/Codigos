using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userList = new List<string>(){Console.ReadLine()};
            List<string> passwordList = new List<string>() {Console.ReadLine()};
            Registro registro = new Registro();
        }
    }
    public class Registro
    {
        List<string> User = new List<string>();
        List<string> password = new List<string>();
        public void intento(List<string> lista2)
        {
            User = lista2;

            for (int i = 0; i < User.Count; i++)
            {
                Console.WriteLine(User[i]);
                if (User[i] == "juan")
                {
                    Console.WriteLine("putos");
                }
            }
        }
    }
}