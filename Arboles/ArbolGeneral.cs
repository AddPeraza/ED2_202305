﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolGeneral
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarNodo(string dato, Nodo nodoPadre)
        {
            if (nodoPadre == null)
            {
                throw new Exception("No se a especificado padre");
            }

            if(nodoPadre.Hijo == null)
            {
                nodoPadre.Hijo = new Nodo(dato);
                return nodoPadre.Hijo;
            }
            else
            {
                Nodo nodoActual = nodoPadre.Hijo;
                while(nodoActual.Hermano != null)
                {
                    nodoActual = nodoActual.Hermano;
                }
                nodoActual.Hermano = new Nodo(dato);
                return nodoActual.Hermano;
            }
        }

        public string ObtenerArbol(Nodo nodoInicial = null)
        {
            if (nodoInicial == null)
            {
                nodoInicial = raiz;
            }

            int posicion = 0;
            string datos = string.Empty;

            Recorrer(nodoInicial, ref posicion, ref datos);
            return datos;
        }

        private void Recorrer(Nodo nodoInicial, ref int posicion, ref string datos)
        {
            if(nodoInicial != null)
            {
                string dato = nodoInicial.Dato;
                int cantidadGuiones = dato.Length + posicion;
                datos += $"{nodoInicial.Dato.PadLeft(cantidadGuiones,'-')}\n";

                if(nodoInicial.Hijo != null)
                {
                    posicion++;
                    Recorrer(nodoInicial.Hijo , ref posicion, ref datos);
                    posicion--;
                }

                if(nodoInicial.Hermano != null && posicion != 0)
                {
                    Recorrer(nodoInicial.Hermano , ref posicion, ref datos);
                }
            }
        }
    }
}
