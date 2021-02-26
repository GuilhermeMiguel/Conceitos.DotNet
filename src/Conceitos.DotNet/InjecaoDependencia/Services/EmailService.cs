using System;

namespace Conceitos.DotNet.InjecaoDependencia.Services
{
    public class EmailService
    {
        public bool SendEmail(string email, string titulo, string mensagem)
        {
            Console.WriteLine("Email enviado");
            return true;
        }
    }
}