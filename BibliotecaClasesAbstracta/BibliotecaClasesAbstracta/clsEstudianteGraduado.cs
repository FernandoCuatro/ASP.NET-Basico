using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClasesAbstracta
{
    public class clsEstudianteGraduado : IRequisitosGraduados
    {
        // Se declaran los miembros declarados en la interfaz
        public string RegistrarTarjetaProfesional()
        {
            // Aqui va todo el procedimiento una ves la validacion exista en la DBs
           return "El estudiante ya reistro su targeta profesional";
        }
        public string RegistrarDiplomado()
        {
            return "El estudiante ya se inscribio en el Diploma Posgradual";
        }
    }
}