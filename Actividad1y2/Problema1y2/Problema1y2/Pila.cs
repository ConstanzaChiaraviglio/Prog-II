using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1y2
{
    public class Pila : ICollection
    {
        object[] elementos;
        int contador;
        public Pila (int tamaño)
        {
            elementos = new object[tamaño];
            contador = 0;
        }
        public bool añadir(object obj)
        {
            if(elementos.Length <= contador)
            {
                return false;
            }
            
            elementos[contador] = obj;
            contador++;
            return true;
        }

        public bool estaVacia()
        {
            if(contador != 0)
            {
                return false;
            }
            return true;
        }

        public object extraer()
        {
            if (estaVacia())
            {
                return "No hay ningun elemento para extraer.";/// o return null
            }
            contador--;
            object elemento = elementos[elementos.Length -1];
            return elemento;
            
          
        }

        public object Cantidad()
        {
            return contador;
        }
        public object primero()
        {
            return elementos[contador -1];
        }

        
    }
}
