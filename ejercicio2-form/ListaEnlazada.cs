using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_form
{
    using System;
    using System.Collections.Generic;

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public void Insertar(double valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
        }

        public double CalcularPromedio()
        {
            if (cabeza == null)
                return 0;

            double suma = 0;
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                suma += actual.Valor;
                actual = actual.Siguiente;
                contador++;
            }

            return suma / contador;
        }

        public List<double> ObtenerValoresMenoresAlPromedio()
        {
            double promedio = CalcularPromedio();
            List<double> valoresMenores = new List<double>();
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Valor < promedio)
                    valoresMenores.Add(actual.Valor);

                actual = actual.Siguiente;
            }

            return valoresMenores;
        }

        public Nodo ObtenerCabeza()
        {
            return cabeza;
        }
    }

}
