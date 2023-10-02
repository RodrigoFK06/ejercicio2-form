using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ejercicio2_form
{
    public partial class Form1 : Form
    {
        private ListaEnlazada lista;

        public Form1()
        {
            InitializeComponent();
            lista = new ListaEnlazada();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar la lista con algunos valores
            lista.Insertar(90);
            lista.Insertar(80);
            lista.Insertar(60);
            lista.Insertar(40);
            lista.Insertar(20);

            ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            Nodo actual = lista.ObtenerCabeza();
            while (actual != null)
            {
                listBox1.Items.Add(actual.Valor);
                actual = actual.Siguiente;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int posicionEliminar = int.Parse(txtPosicion.Text);
                lista.EliminarEnPosicion(posicionEliminar);
                ActualizarListBox();
                txtPosicion.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Entrada no válida. Debe ingresar un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularMediaGeometrica_Click_1(object sender, EventArgs e)
        {
            double mediaGeometrica = lista.CalcularMediaGeometrica();
            MessageBox.Show("Media Geométrica: " + mediaGeometrica, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValoresMenoresAlPromedio_Click_1(object sender, EventArgs e)
        {
            List<double> valoresMenoresAlPromedio = lista.ObtenerValoresMenoresAlPromedio();
            string mensaje = "Valores menores al promedio: ";
            foreach (var valor in valoresMenoresAlPromedio)
            {
                mensaje += valor + " ";
            }
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = lista.CalcularPromedio();
            MessageBox.Show("Promedio: " + promedio, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}