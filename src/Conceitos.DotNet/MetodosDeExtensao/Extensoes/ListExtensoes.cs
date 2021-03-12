using System.Collections.Generic;

namespace Conceitos.DotNet.MetodosDeExtensao.Extensoes
{
    public static class ListExtensoes
    {
        //A classe e o metodo devem ser estaticos
        
        //O this quer dizer que esse é o argumento que está sendo estendido
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            }

        }

    }
}