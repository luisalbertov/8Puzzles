using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class Nodo
    {
        public int[,] Conjunto = new int[3, 3];

        public Nodo(int[,] Conjunto)
        {
            this.Conjunto = Conjunto;
        }

        public Nodo()
        {
        }

        public List<Nodo> ObtenerNodosHijos(Nodo nodo)
        {
            List<Nodo> hijos = new List<Nodo>();
            Nodo aux = new Nodo();
            aux = MoverArriba(nodo);
            if (aux != null)
            {
                hijos.Add(aux);
            }
            aux = MoverAbajo(nodo);
            if (aux != null)
            {
                hijos.Add(aux);
            }
            aux = MoverDer(nodo);
            if (aux != null)
            {
                hijos.Add(aux);
            }
            aux = MoverIzq(nodo);
            if (aux != null)
            {
                hijos.Add(aux);
            }
            return hijos;
        }
        public Nodo MoverIzq(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux = new int [3,3];
            int aux;
            Nodo nuevo = new Nodo();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (nodo.Conjunto[i, j] == 0)
                    {
                        if (j > 0)
                        {
                            NodoAux(nodo.Conjunto, ConjuntoAux);
                            aux = ConjuntoAux[i, j - 1];
                            ConjuntoAux[i, j - 1] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                            return nuevo;
                        }
                    }
                }
            }
            return null;
        }
        public Nodo MoverDer(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux = new int[3, 3];
            int aux;
            Nodo nuevo = new Nodo();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (nodo.Conjunto[i, j] == 0)
                    {
                        if (j < 2)
                        {
                            NodoAux(nodo.Conjunto, ConjuntoAux);
                            aux = ConjuntoAux[i, j + 1];
                            ConjuntoAux[i, j + 1] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                            return nuevo;
                        }
                    }
                }
            }
            return null;
        }
        public Nodo MoverArriba(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux = new int[3, 3];
            int aux;
            Nodo nuevo = new Nodo();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (nodo.Conjunto[i, j] == 0)
                    {
                        if (i > 0)
                        {
                            NodoAux(nodo.Conjunto, ConjuntoAux);
                            aux = ConjuntoAux[i - 1, j];
                            ConjuntoAux[i - 1, j] = ConjuntoAux[i, j];
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                            return nuevo;
                        }
                    }
                }
            }
            return null;
        }
        public Nodo MoverAbajo(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux = new int[3, 3];
            int aux;
            Nodo nuevo = new Nodo();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (nodo.Conjunto[i, j] == 0)
                    {
                        if (i < 2)
                        {
                            NodoAux(nodo.Conjunto, ConjuntoAux);
                            aux = ConjuntoAux[i + 1, j];
                            ConjuntoAux[i + 1, j] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                            return nuevo;
                        }
                    }
                }
            }
            return null;
        }
        public void NodoAux(int [,] original, int[,] copia)
        {
            for (int i = 0; i < 3; i++)
            {  
                for (int j = 0; j < 3; j++)
                {
                    copia[i, j] = original[i, j];
                }
            }
        }
        public void ImprimirConjunto (Nodo nodo)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("  "+ nodo.Conjunto[i, j]);
                }
            }
            Console.WriteLine();
        }
        public bool CompararNodos (Nodo nodo1, Nodo nodo2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (nodo1.Conjunto[i,j]!=nodo2.Conjunto[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
