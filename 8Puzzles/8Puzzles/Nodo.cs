using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class Nodo
    {
        public int[,] Conjunto = new int[3, 3];
        public List<Nodo> hijos = new List<Nodo>();

        public Nodo(int[,] Conjunto)
        {
            this.Conjunto = Conjunto;
        }

        public Nodo()
        {
        }

        public void ObtenerNodosSucesores(Nodo nodo)
        {
            
            
        }
        public Nodo MoverIzq(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux;
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
                            ConjuntoAux = nodo.Conjunto;
                            aux = ConjuntoAux[i, j - 1];
                            ConjuntoAux[i, j - 1] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                        }
                    }
                }
            }
            return nuevo;
        }
        public Nodo MoverDer(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux;
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
                            ConjuntoAux = nodo.Conjunto;
                            aux = ConjuntoAux[i, j + 1];
                            ConjuntoAux[i, j + 1] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                        }
                    }
                }
            }
            return nuevo;
        }
        public Nodo MoverArriba(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux;
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
                            ConjuntoAux = nodo.Conjunto;
                            aux = ConjuntoAux[i - 1, j];
                            ConjuntoAux[i - 1, j] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                        }
                    }
                }
            }
            return nuevo;
        }
        public Nodo MoverAbajo(Nodo nodo)
        {
            int i, j;
            int[,] ConjuntoAux;
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
                            ConjuntoAux = nodo.Conjunto;
                            aux = ConjuntoAux[i + 1, j];
                            ConjuntoAux[i + 1, j] = 0;
                            ConjuntoAux[i, j] = aux;
                            nuevo = new Nodo(ConjuntoAux);
                        }
                    }
                }
            }
            return nuevo;
        }

    }
}
