using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaClasesAlumno
{
    public class clsAlumno
    {
        // ENCAPSULAMIENTO DE ATRIBUTOS
        private string IDCarnet;
        private int edad;
        private string nombre;

        // CONSTRUCTOR
        public clsAlumno() {
            PpIDCarnet = "0000";
            PpEdad = 0;
            PpNombre = "N/A";
        }

        // PROPIEDADES | Metodos de acceso
        public string PpIDCarnet {
            get { return IDCarnet; }
            set { IDCarnet = value; }
        }

        public int PpEdad {
            get { return edad; }
            set { edad = value; }
        }

        public string PpNombre {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
