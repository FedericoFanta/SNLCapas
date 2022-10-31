using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string legajo = txtTitulo.Text;
            Alumno alumno = new Alumno(nombre, apellido, legajo);

            MessageBox.Show($"Nombre: {alumno.Nombre} Apellido: {alumno.Apellido} Titulo: {alumno.Legajo}");
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Director director = new Director("Marcos","Fantacone","Administrativo");

            MessageBox.Show($"Nombre: {director.Nombre} titulo: {director.Titulo}");
        }
    }
}
