using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class BusquedaAnchura
    {
        public Nodo BusquedadeAnchura(Nodo inicial, Nodo objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            Visitados.Add(inicial);
            cola.Enqueue(inicial);

            while (cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                Console.WriteLine("Procesando:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(v.Conjunto[i, j]);
                    }

                }
                Console.WriteLine();
                if (v.Conjunto.Equals(objetivo))
                {
                    return v;
                }
                foreach (var w in g.ObtenerNodosAdyacentes(v))
                {
                    if (!Visitados.Contains(w))
                    {
                        Visitados.Add(w);
                        cola.Enqueue(w);
                    }
                }
            }
            return null;
        }
    }
}
