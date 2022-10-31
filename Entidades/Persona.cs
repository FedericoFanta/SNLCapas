using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona //comun entre las 3 clases/entidades
        
    {
        public Persona() { } // constructor por defecto
        public Persona (string nombre, string apellido) // constructor con parametros
        {
            Nombre=nombre;
            Apellido=apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
