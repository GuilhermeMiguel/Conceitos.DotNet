using System;
using System.Collections.Generic;
using System.Linq;

namespace Conceitos.DotNet.LinqLambda
{
    public class LinqLambdaExemploMain
    {      
         /*
            Na aplicação eu tenho varios metodos main, MainTeste é um main desativado
        */

        public static void MainTeste(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("São José");
            cidades.Add("Videira");
            cidades.Add("Joaçaba");
            cidades.Add("Florianópolis");

            Console.WriteLine(BuscarPrimeiroComForeach(cidades, "São Paulo"));
            Console.WriteLine(BuscarPrimeiroComLinq(cidades, "São Paulo"));
            Console.WriteLine(BuscarPrimeiroComLinqLambda(cidades, "São Paulo"));
            //Console.ReadKey();
        }

        public static string BuscarPrimeiroComForeach(List<String> lista, string termo)
        {
            foreach(string item in lista)
            {
                if(item.Equals(termo)){
                    return item;
                }
            }

            return null;
        }

        public static string BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Equals(termo) select item).First();
        }

        public static string BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }
    }
}