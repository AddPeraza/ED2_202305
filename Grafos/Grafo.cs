using System.Collections.Generic;

namespace Proyecto_Grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ListaLigada> Grafo = new List<ListaLigada>();

            ListaLigada verticeA = new ListaLigada("A");
            ListaLigada verticeB = new ListaLigada("B");
            ListaLigada verticeC = new ListaLigada("C");
            ListaLigada verticeD = new ListaLigada("D");
            ListaLigada verticeE = new ListaLigada("E");
            ListaLigada verticeF = new ListaLigada("F");
            ListaLigada verticeG = new ListaLigada("G");
            ListaLigada verticeH = new ListaLigada("H");
            ListaLigada verticeI = new ListaLigada("I");


            //Adyacencia de los vertices, Nodo A tendra adyacencia con los nodos B,C,F,H y con H sera no dirigido.
            verticeA.Relacionar(verticeB);
            verticeA.Relacionar(verticeC);
            verticeA.Relacionar(verticeF);
            verticeC.Relacionar(verticeD);
            verticeD.Relacionar(verticeA);
            verticeD.Relacionar(verticeB);
            verticeE.Relacionar(verticeA);
            verticeF.Relacionar(verticeC);
            verticeF.Relacionar(verticeA);
            verticeA.Relacionar(verticeH);
            verticeH.Relacionar(verticeA);
            verticeG.Relacionar(verticeH);

            //Agregando los nodos al grafo ya con su adyacencia 
            Grafo.Add(verticeA);
            Grafo.Add(verticeB);
            Grafo.Add(verticeC);
            Grafo.Add(verticeD);
            Grafo.Add(verticeE);
            Grafo.Add(verticeF);
            Grafo.Add(verticeG);
            Grafo.Add(verticeH);
            Grafo.Add(verticeI);


        }
    }
}
