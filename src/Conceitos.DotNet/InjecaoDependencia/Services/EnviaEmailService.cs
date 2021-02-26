using System;

namespace Conceitos.DotNet.InjecaoDependencia.Services
{
    public class EnviaEmailService : IServicoEmail
    {
        public void EnviaEmail(string email, string titulo, string mensagem)
        {
            Console.WriteLine("------------------------------------------\nEmail enviado na classe EnviaEmailService " + "\nEmail: " + email + "\nTitulo: " + titulo + "\nMensagem: " + mensagem);
        }
    }
}