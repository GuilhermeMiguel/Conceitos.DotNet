using Conceitos.DotNet.InjecaoDependencia.Services;

namespace Conceitos.DotNet.InjecaoDependencia
{
    public class ChamaClienteMain
    {

        /*
                Injeção de dependencia torna o acoplamento entre classes menor

            É muito utilizada em frameworks 

            É otima para testes unitarios, pois eu trabalho com interfaces, e cada interface pode ter diversas implementações
                * Como o List que tem ArrayList, LinkedList

            

            Porém torna o código mais complexo, principalmente para quem esta em processo de aprendizagem

            E pode levar erros de tempo de compilação para erros em tempo de execução

        */

        public static void Main(string[] args)
        {
            var clienteConstructor = new ClienteConstructorInjection(new EnviaEmailService());

            clienteConstructor.EnviaEmailComConstrutorEInterface(
                "gui.teste@teste.com", 
                "Este é um e-mail de teste ClienteConstructorInjection", 
                "Olá e-mail de teste ClienteConstructorInjection!"
            );

            /* -------------------------------------------------------------------- */

            var enviaEmailService = new EnviaEmailService();
            
            var clienteSetterInjection = new ClienteSetterInjection()
            {
                servicoEmail = enviaEmailService
            };

            clienteSetterInjection.EnviaEmailComSetter(
                "gui.teste@teste.com", 
                "Este é um e-mail de teste ClienteSetterInjection", 
                "Olá e-mail de teste ClienteSetterInjection!"
            );


            /* ------------------------------------------------------------------ */

            var clienteMethodInjection = new ClienteMethodInjection();

            clienteMethodInjection.EnviaEmailMethodInjection(
                "gui.teste@teste.com", 
                "Este é um e-mail de teste ClienteMethodInjection", 
                "Olá e-mail de teste ClienteMethodInjection!", 
                enviaEmailService
            );
        }
    }
}