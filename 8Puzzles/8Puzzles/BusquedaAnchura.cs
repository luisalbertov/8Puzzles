using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class Busquedas
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
                v.ImprimirConjunto(v);
                if (v.CompararNodos(v, objetivo))
                {
                    return v;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
                    {
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                        }
                    }
                }
                if (MejorOpcion != null)
                {
                    Visitados.Add(MejorOpcion);
                    cola.Enqueue(MejorOpcion);
                }
            }
            return null;
        }
        public int Heuristica(Nodo nodo, Nodo objetivo)
        {
            int contador=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (nodo.Conjunto[i,j]!=objetivo.Conjunto[i,j])
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
        public bool NodosVisitados(Nodo nodo, List<Nodo> visitados)
        {
            foreach (Nodo nodovi in visitados)
            {
                bool compara=nodo.CompararNodos(nodo, nodovi);
                if (compara==true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
