using Conceitos.DotNet.InjecaoDependencia.Services;

namespace Conceitos.DotNet.InjecaoDependencia
{
    public class ClienteConstructorInjection
    {
        
        /*
            Constructor Injection
        */
        public ClienteConstructorInjection()
        {}

        private EmailService _service;
        private IServicoEmail _servicoEmail;


        public ClienteConstructorInjection(EmailService service)
        {
            _service = service;
        }

        public ClienteConstructorInjection(IServicoEmail servicoEmail)
        {
            _servicoEmail = servicoEmail;
        }


        /*
            Esse código tem um forte acoplamento com a classe SendEmail, pois depende totalmente dela         


            Estamos supondo que o SendEmail é de uma biblioteca, por exemplo 

        */
        public void EnviaEmail(string email, string titulo, string mensagem)
        {
            var service = new EmailService();
            service.SendEmail(email, titulo, mensagem);
        }



        /*
                Posso fazer uma injeção de dependencia por meio do construtor, mas mesmo assim estamos dependendo da classe
        */
        
        public void EnviaEmailComConstrutor(string email, string titulo, string mensagem)
        {            
            _service.SendEmail(email, titulo, mensagem);
        }


        /*
                Posso fazer uma injeção de dependencia por meio do construtor, dessa vez recebendo uma interface
            
            Dessa forma diminuo o acoplamento

            Assim como dita o SOLID, o correto é dependermos de abstracoes e nao de implementacoes 

        */
        public void EnviaEmailComConstrutorEInterface(string email, string titulo, string mensagem)
        {            
            _servicoEmail.EnviaEmail(email, titulo, mensagem);
        }
    }
}