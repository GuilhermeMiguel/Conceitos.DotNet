using System;
using System.Linq;

namespace Conceitos.DotNet.RestOperator
{
    public class RestOperatorMain
    {
        

        public static void MainTeste(string[] args)
        {
            Console.WriteLine("Soma 3 números: " + SomaValores(1, 5, 6));
            
            Console.WriteLine("Soma 10 números: " + SomaValores(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }


        //No c# diferentemente do java e js eu preciso explicitar que estou trabalhando com um array
        public static int SomaValores(params int[] numeros)
        {
            //Soma os numeros do array 
            return numeros.Sum();
        }
    }
}