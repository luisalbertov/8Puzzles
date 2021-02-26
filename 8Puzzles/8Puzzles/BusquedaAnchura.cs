using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class BusquedaAnchura
    {
        /*public Nodo BusquedadeAnchura(Nodo inicial, Nodo objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            Visitados.Add(inicial);
            cola.Enqueue(inicial);

            while (cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                Console.WriteLine("Procesando: " + v.Conjunto);
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
        }*/
    }
}
