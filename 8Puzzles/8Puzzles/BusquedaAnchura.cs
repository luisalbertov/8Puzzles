using System;
using System.Collections.Generic;
using System.Linq;
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
            int mov = 0;

            while (cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                Console.WriteLine("\n Movimiento: "+mov);
                mov++;
                v.ImprimirConjunto(v);
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    return v;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                bool entro = false;
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
                    {
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                            entro = true;
                        } 
                    }
                }
                if (entro)
                {
                    Visitados.Add(MejorOpcion);
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
        public Nodo BusquedaAEstrella(Nodo inicial, Nodo objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> Cerrada = new List<Nodo>();
            List<Nodo> Abierta = new List<Nodo>(); 
            Abierta.Add(inicial);
            int mov = 0;

            while (Abierta.Count > 0)
            {
                
                Console.WriteLine("\n Movimiento: " + mov);
                mov++;
                v.ImprimirConjunto(v);
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    return v;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                bool entro = false;
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Cerrada))
                    {
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                            entro = true;
                        }
                    }
                }
                if (entro)
                {
                    Cerrada.Add(MejorOpcion);
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

        public Nodo BusquedadeProfundidad(Nodo inicial, Nodo objetivo)
        {
            Stack<Nodo> pila = new Stack<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            Visitados.Add(inicial);
            pila.Push(inicial);
            int mov = 0;

            while (pila.Count > 0)
            {
                Nodo v = pila.Pop();
                Console.WriteLine("\n Movimiento: " + mov);
                mov++;
                v.ImprimirConjunto(v);
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    return v;
                }
                int compara = 9;
                Nodo MejorOpcion = new Nodo();
                bool entro = false;
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
                    {
                        int resultado = Heuristica(w, objetivo);
                        if (resultado <= compara)
                        {
                            compara = resultado;
                            MejorOpcion = w;
                            entro = true;
                        }
                    }
                }
                if (entro)
                {
                    Visitados.Add(MejorOpcion);
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
        public Nodo BusquedaAnchura(Nodo inicial, Nodo objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> Visitados = new List<Nodo>();
            Visitados.Add(inicial);
            cola.Enqueue(inicial);
            int mov = 0;
            while (cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                Console.WriteLine("\n Movimiento: " + mov);
                mov++;
                v.ImprimirConjunto(v);
                if (v.CompararNodos(v, objetivo))
                {
                    Console.WriteLine("\n Objetivo encontrado!!");
                    return v;
                }
                foreach (var w in v.ObtenerNodosHijos(v))
                {
                    if (!NodosVisitados(w, Visitados))
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
