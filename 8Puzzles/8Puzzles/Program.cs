using System;
using System.Collections.Generic;

namespace _8Puzzles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] facil = new int[3, 3] { { 1, 2, 3 }, { 4, 8, 0 }, { 7, 6, 5 } };
            Nodo nodofacil = new Nodo(facil);
            int[,] objetivo = new int[3, 3] { { 1, 2 ,3 }, { 4, 5, 6}, { 7, 8, 0 } };
            Nodo nodoobjetivo = new Nodo(objetivo);

            int[,] facil1 = new int[3, 3] { { 1, 2, 3 }, { 0, 4, 6 }, {7, 5, 8 } };
            Nodo nodofacil1 = new Nodo(facil1);

            int[,] medio = new int[3, 3] { { 1, 3, 2 }, { 4, 5, 3 }, { 7, 8, 0 } };
            Nodo nodomedio = new Nodo(medio);

            Busquedas Anchura = new Busquedas();
            //Anchura.BusquedadeAnchura(nodofacil1, nodoobjetivo);
            //Anchura.BusquedadeProfundidad(nodofacil1, nodoobjetivo);
            List<Nodo> result = new List<Nodo>();
            Anchura.BusquedaAEstrella(nodofacil, nodoobjetivo);
            
        }
    }
}
