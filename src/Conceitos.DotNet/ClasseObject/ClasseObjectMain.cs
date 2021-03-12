using System;

namespace Conceitos.DotNet.ClasseObject
{
    public class ClasseObjectMain
    {
        public static void MainTeste(string[] args)
        {
            //A lista de object nao funciona, pois se eu estiver lidando com int(no exemplo idades),
            //Ela aceita texto, mas na hora das operacoes gera uma excecao, porém não deveria nem receber texto

            ListaDeObject listaDeIdades = new ListaDeObject();
            
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            listaDeIdades.Adicionar("texto que não poderia ser aceito pelo compilador");

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }
    }
}