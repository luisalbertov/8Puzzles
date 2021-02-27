using System;
using System.Collections.Generic;

namespace _8Puzzles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] inicio = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 0 }, { 8, 6, 7 } };
            Nodo nodoinicial = new Nodo(inicio);
            int[,] objetivo = new int[3, 3] { { 1, 2 ,3 }, { 4, 5, 6}, { 7, 8, 0 } };
            Nodo nodoobjetivo = new Nodo(objetivo);

            int i, j;
            nodoinicial.ImprimirConjunto(nodoinicial);
            Console.WriteLine();

            List<Nodo> hijos = nodoinicial.ObtenerNodosHijos(nodoinicial);
            foreach (Nodo item in hijos)
            {
                for (i = 0; i < 3; i++)
                {
                    item.ImprimirConjunto(item);
                }
            }


        }
    }
}
