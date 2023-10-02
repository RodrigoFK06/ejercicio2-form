using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_form
{
    public class Nodo
    {
        public double Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(double valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

}
