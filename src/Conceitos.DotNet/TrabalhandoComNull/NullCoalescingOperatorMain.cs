using System;
using System.Collections.Generic;
using System.Linq;

namespace Conceitos.DotNet.TrabalhancoComNull
{
    public class Funcionario  
    {  
        public int id { get; set; }  
        public int idade { get; set; }  
        public string nome { get; set; }  
        public string genero { get; set; }  
    }  

    public class NullCoalescingOperatorMain
    {
        public static void MainTeste(string[] args)
        {

        }
        
        
        
        private static void exemploSimples()
        {
            string nome = null;  

            /*
                    O operador ?? verifica se o que esta a esquer é nullo 
                
                Se for nullo ele pega o valor da direita 

            */
            string meuNome = nome ?? "Vovozona";  
            Console.WriteLine(meuNome);  
            Console.ReadLine();

        }
        

        /*
            
            Exemplo um pouco mais complexo com Link:

        */  

        
        private static void exemploMaisComplexo()
        {
            List<Funcionario> listaFunc = new List<Funcionario>()
            {
                new Funcionario { id = 1, idade = 19, nome = "Robocop", genero = "M" },  
                new Funcionario { id = 2, idade = 20, nome = "Liu Kang", genero = "M" },  
                new Funcionario { id = 3, idade = 23, nome = "Vovozona", genero = "F" }, 
                new Funcionario { id = 4, idade = 3, nome = null, genero = "F" },  
                new Funcionario { id = 5, idade = 24, nome = "Ronaldo", genero = "M" },  
                new Funcionario { id = 6, idade = 28, nome = "Godzilla", genero = "M" }  
            };  
  
            /*
                    Usando o Linq sem lambda

                Nesse exemplo se o nome estiver vazio ele pega a string "Sem nome"
            */
            
            var Data = from func in listaFunc where func.id == 4 select new { nome = func.nome ?? "Sem nome" };  
  
            foreach (var obj in Data)  
            {  
                Console.WriteLine(obj.nome);  
            }  
            Console.ReadLine();  
        }
       

       private static void incrementandoValorAVariavel()
       {
           string variavelQualquer = null;
           var expressao = "hoje";
           
           if (variavelQualquer is null)
                variavelQualquer = expressao;

            /*
                    Vira

                    |
                    |
                    |
                     `-----> 
                Se ela estiver vazia ja incrementa o outro valor 
            */


            variavelQualquer ??= expressao;
       }

       private static void lancandoException()
       {
           string valor = null;
            
            /*
                Se estiver null ele lanca uma Exception
            */ 
           var nome = valor ?? throw new ArgumentNullException(nameof(valor), "Name cannot be null");

           /*
                O nameof pega o nome da variavel
           */
           
       }
    }
}