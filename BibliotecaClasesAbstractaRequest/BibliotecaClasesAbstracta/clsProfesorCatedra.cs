using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClasesAbstracta
{
    public class clsProfesorCatedra : clsProfesor
    {
        public override string PpDiu
        {
            get { return diu; }
            set { diu = value; }
        }

        public override string PpNombreMaestria
        {
            get { return nombreMaestria; }
            set { nombreMaestria = value; }
        }

        public override string PpProfesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        // Implementamos los metodos abstractos que son de obligatorio uso

        // Como obligacion se debe implementar el metodo abstracto
        public override double AspiracionSalarial()
        {
            return 2.500;
        }
    }
}