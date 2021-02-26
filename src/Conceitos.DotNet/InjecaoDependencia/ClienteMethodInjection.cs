using Conceitos.DotNet.InjecaoDependencia.Services;

namespace Conceitos.DotNet.InjecaoDependencia
{
    public class ClienteMethodInjection
    {
        /*
            Method Injection
        */
        
        /*
            Dessa maneira eu recebo a instancia da classe, que implementa a interface, como parametro no metodo

            var enviaEmailService = new EnviaEmailService();
            ClienteMethodInjection cliente = new ClienteMethodInjection();

            cliente.EnviaEmail(..., enviaEmailService);
        */
        public void EnviaEmailMethodInjection(string email, string titulo, string mensagem, IServicoEmail servicoEmail)
        {
            servicoEmail.EnviaEmail(email, titulo, mensagem);
        }
    }
}