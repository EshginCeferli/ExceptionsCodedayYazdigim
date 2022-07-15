using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Login
{
    public class Authentification : Exception
    {
        public static string Mail = "esqinceferli@mail.ru";
        public static string Password = "esqin12345";
        public Authentification(string message) : base(message)
        {

        }
        
    }
}
