using Conceitos.DotNet.InjecaoDependencia.Services;

namespace Conceitos.DotNet.InjecaoDependencia
{
    public class ClienteSetterInjection
    {
        /*
            Setter Injection
        */

        public IServicoEmail servicoEmail { get; set; }


        /*
                Dessa forma a chamada para o Servico Email se da através de um propriedade
            Ai quando eu instanciar a minha classe atual (ClienteSetterInjection), eu seto essa propriedade

            var enviaEmailService = new EnviaEmailService();
            ClienteSetterInjection cliente = new ClienteSetterInjection()
            {
                servicoEmail = enviaEmailService
            };

            cliente.EnviaEmail(...);
        */
        public void EnviaEmailComSetter(string email, string titulo, string mensagem)
        {
            servicoEmail.EnviaEmail(email, titulo, mensagem);
        }
    }
}