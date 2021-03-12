using System;

namespace Conceitos.DotNet.ParametrosOpcionais
{
    public class ParametrosOpcionaisMain
    {
            //Dessa forma o array é declarado e já inicializado
        public static void MainTeste(string[] args)
        {

            var numeroEhMaiorQue10 = verificaSeNumeroEhMaiorQue10();

            Console.WriteLine($"Número é maior que 10: {(numeroEhMaiorQue10 ? "Sim" : "Não")}");

            //Em metodos com parametros opcionais eu posso escolher qual parametro desejo passar
            var result = VerificarMaioridadeParametrosOpcionais(idade: 18);     

            //Interpolacao de strings
            Console.WriteLine($"* {result.Item2} é maior de idade: {(result.Item1 ? "Sim" : "Não")}");       
           
        }

        private static Tuple<bool, string> VerificarMaioridadeParametrosOpcionais(int idade = 0, string nome = "Sem nome"){
            
            if(idade >= 18)
                return new Tuple<bool, string>(true, nome);

            return new Tuple<bool, string>(false, nome);;
        }

        private static bool verificaSeNumeroEhMaiorQue10(int numero = 5)
        {
            if(numero > 10)
                return true;

            return false;
        }
    }
}