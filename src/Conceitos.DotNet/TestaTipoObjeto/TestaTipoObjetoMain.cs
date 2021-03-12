using System;

namespace Conceitos.DotNet.TestaTipoObjeto
{
    public class TestaTipoObjetoMain
    {
        public static void MainTeste(string[] args)
        {
            object teste = "teste";
            if (teste.GetType() == typeof(string))
            {
                Console.WriteLine("É uma string");
            }
            else
            {
                Console.WriteLine("Não é string");
            }
        }
    }
}