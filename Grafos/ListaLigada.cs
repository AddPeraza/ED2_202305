namespace Proyecto_Grafos
{
    internal class ListaLigada
    {
        Nodo nodoInicial;
        public ListaLigada(string valor)
        {
            nodoInicial = new Nodo(valor);
        }
        public void Agregar(string valor)
        {
            Nodo nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            nodoActual.Siguiente = new Nodo(valor);
        }

        public void Relacionar(ListaLigada vertice)
        {
            Agregar(vertice.nodoInicial.Valor);
        }
    }
}
