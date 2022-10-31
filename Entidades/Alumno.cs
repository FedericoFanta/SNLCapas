using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Alumno:Persona //alumno hereda de persona si pongo :clase
    {
        #region constructores
        public Alumno(string nombre, string apellido, string legajo) : base(nombre, apellido) //se pone en el constructor hijo y es para llamar al constructor padre
        {
            Nombre=nombre;
            Apellido=apellido;
            Legajo=legajo;
        }
        #endregion

        #region propiedades
        /*
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        */
        public string Legajo { get; set; }
        #endregion
    }
}
