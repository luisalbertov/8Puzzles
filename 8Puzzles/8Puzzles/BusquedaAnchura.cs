using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzles
{
    public class Busquedas
    {
        public List<Nodo> BusquedadeAnchura(Nodo inicial, Nodo objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            List<Nodo> Camino = new List<Nodo>();
            Visitados.Add(inicial);
            cola.Enqueue(inicial);
            int nodos = 0;
            int mov = 0;
            while (cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    foreach (Nodo item in Camino)
                    {
                        mov++;
                        item.ImprimirConjunto(item);
                    }
                    Console.WriteLine("Cantidad de Nodos: " + nodos);
                    Console.WriteLine("Movimientos: " + mov);
                    return Camino;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                bool entro = false;
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
                    {
                        nodos++;
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                            entro = true;
                            Visitados.Add(MejorOpcion);
                        } 
                    }
                }
                if (entro)
                {
                    Camino.Add(MejorOpcion);
                    cola.Enqueue(MejorOpcion);
                }
                else
                {
                    Console.WriteLine("\n Objetivo no encontrado");
                    return null;
                }
            } 
            return null;
        }
        public List<Nodo> BusquedaAEstrella(Nodo inicial, Nodo objetivo)
        {
            List<Nodo> Cerrada = new List<Nodo>();
            List<Nodo> Abierta = new List<Nodo>();
            List<Nodo> Camino = new List<Nodo>();
            Abierta.Add(inicial);
            inicial = null;
            bool solucion = false;
            int nodos =0;
            int mov = 0;
            while (!solucion&&Abierta.Count()!=0)
            {
                inicial = Abierta.OrderBy(x => x.f).ThenBy(x => x.h).First();

                if (inicial.CompararNodos(inicial, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    foreach (Nodo item in Camino)
                    {
                        mov++;
                        item.ImprimirConjunto(item);
                    }
                    Console.WriteLine("Cantidad de Nodos: " + nodos);
                    Console.WriteLine("Movimientos: " + mov);
                    solucion = true;
                }
                else
                {
                    Abierta.Remove(inicial);
                    Cerrada.Add(inicial);

                    List<Nodo> nuevos = inicial.ObtenerNodosHijos(inicial);
                    foreach (var w in nuevos)
                    {
                        if (!NodosVisitados(w, Cerrada))
                        {
                            w.h = Heuristica(w, objetivo);
                            int nuevog = inicial.g + 1;
                            w.g = nuevog;
                            w.f = nuevog + w.h;
                            nodos++;
                            if (!NodosVisitados(w, Abierta))
                            {
                                Abierta.Add(w);
                                Camino.Add(w);
                            } else if (nuevog < ElementoLista(w, Abierta).g)
                            {
                                Abierta.Remove(ElementoLista(w, Abierta));
                                Abierta.Add(w);
                                Camino.Remove(ElementoLista(w, Abierta));
                                Camino.Add(w);
                            }
                            }
                        }
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
        public Nodo ElementoLista(Nodo nodo, List<Nodo> visitados)
        {
            for (int i = 0; i < visitados.Count; i++)
            {
                if (nodo.CompararNodos(nodo,visitados[i]))
                {
                    return visitados[i];
                }
            }
            return null;
        }

        public List<Nodo> BusquedadeProfundidad(Nodo inicial, Nodo objetivo)
        {
            Stack<Nodo> pila = new Stack<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            List<Nodo> Camino = new List<Nodo>();
            int nodos = 0;
            int mov = 0;
            Visitados.Add(inicial);
            pila.Push(inicial);

            while (pila.Count > 0)
            {
                Nodo v = pila.Pop();
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    foreach (Nodo item in Camino)
                    {
                        mov++;
                        item.ImprimirConjunto(item);
                    }
                    Console.WriteLine("Cantidad de Nodos: " + nodos);
                    Console.WriteLine("Movimientos: " + mov);
                    return Camino;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                bool entro = false;
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
                    {
                        nodos++;
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                            entro = true;
                            Visitados.Add(MejorOpcion);
                        }
                    }
                }
                if (entro)
                {
                    Camino.Add(MejorOpcion);
                    pila.Push(MejorOpcion);
                }
                else
                {
                    Console.WriteLine("\n Objetivo no encontrado");
                    return null;
                }
            }
            return null;
        }
    }
}
