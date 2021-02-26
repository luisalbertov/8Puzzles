using System;
using System.Collections.Generic;
using System.Text;

namespace _8Puzzles
{
    public class Grafo
    {
        Dictionary<Nodo, List<Nodo>> nodos;

        public Grafo(Dictionary<Nodo, List<Nodo>> nodos)
        {
            this.nodos = nodos;
        }
        public List<Nodo> ObtenerNodosAdyacentes(Nodo llave)
        {
            return nodos[llave];
        }
    }
}
