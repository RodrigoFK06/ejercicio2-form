using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_form
{
    public class trabajo_en_equipo
    {
        /*

        

        public void EliminarEnPosicion(int posicion)
        {
            if (posicion <= 0 || cabeza == null)
            {
                Console.WriteLine("Posición no válida. No se ha eliminado ningún nodo.");
                return;
            }

            if (posicion == 1)
            {
                cabeza = cabeza.Siguiente;
                return;
            }

            Nodo actual = cabeza;
            int contador = 1;

            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Siguiente;
                contador++;
            }

            if (actual == null || actual.Siguiente == null)
            {
                Console.WriteLine("Posición no válida. No se ha eliminado ningún nodo.");
                return;
            }

            actual.Siguiente = actual.Siguiente.Siguiente;
        }

        public double CalcularMediaGeometrica()
        {
            if (cabeza == null)
                return 0;

            double producto = 1;
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                producto *= actual.Valor;
                actual = actual.Siguiente;
                contador++;
            }

            return Math.Pow(producto, 1.0 / contador);
        }

        */
    }
}
