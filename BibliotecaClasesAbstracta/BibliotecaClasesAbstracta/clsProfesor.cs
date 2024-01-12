using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClasesAbstracta
{
    // La declaramos como clase abstracta
    public abstract class clsProfesor : clsPersona
    {   
        // Modificamos el metodo accesor
        protected string profesion;
        protected string diu;
        protected string nombreMaestria;

        public abstract string PpProfesion { get; set; }
        public abstract string PpDiu { get;set; }
        public abstract string PpNombreMaestria { get; set; }

        // Las clases que deriven de la clase abastracta, deberan usar el abstracto

        // Toda clase abstracta obliga a hacer un metodo abstracto
        public abstract double AspiracionSalarial();


    }
}