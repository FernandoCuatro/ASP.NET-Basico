using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClasesAbstracta
{
    public class clsPersona
    {
        // Atributos de la clase
        private string nombre;
        private int edad;
        private string genero;

        // Constructor
        public clsPersona()
        {
            PpEdad = 0;
            PpGenero = "Masculino";
            PpNombre = "N/A";
        }
        
        // Propiedades, metodos accesores. 
        public int PpEdad
        {
            get{ return edad; }
            set{ edad = value; }
        }

        public string PpGenero
        {
            get{ return genero; }
            set{ genero = value; }
        }

        public string PpNombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }

        public void listarDatos()
        {
            throw new System.NotImplementedException();
        }
    }
}