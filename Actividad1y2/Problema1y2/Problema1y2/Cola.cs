using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Problema1y2
{
    public class Cola : ICollection
    {
        List<object> elementos;//object va con minuscula

        public Cola()
        {
            elementos = new List<object>();
        }

        public bool añadir(object obj)
        {
            
            elementos.Add(obj);
            return true;
        }

        public bool estaVacia()
        {
            if (elementos.Count != 0)
            {
                return false;
            }
            return true;
        }

        public object extraer()
        {
            if (estaVacia())
            {
                return "No hay ningun elemento para extraer.";
            }
            object elemento = elementos[0];
            elementos.RemoveAt(0);
            return elemento;
        }

        public object primero()
        {
            if(elementos.Count == 0)
            {
                return "No hay elementos";
            }
            return elementos[0];
        }

        public object Cantidad()
        {
            return elementos.Count;
        }
    }
}
