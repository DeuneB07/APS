using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.JSON
{
    class UsuarioJSON
    {
        private String categoryName;
        private List<CursoJSON> courses;
        private String nombre;
        private String primerApellido;
        private String segundoApellido;
        private String situation;
        private String userEmail;

        public UsuarioJSON() { }

        public String CategoryName {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public List<CursoJSON> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public String SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public String Situation
        {
            get { return situation; }
            set { situation = value; }
        }

        public String UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public override String ToString()
        {
            return situation + " " + categoryName + ": " + userEmail + ", " + nombre + " " + primerApellido + " " + segundoApellido + "; Asignaturas: " + string.Join(", ", courses);
        }
    }
}
