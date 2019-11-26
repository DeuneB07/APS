using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Mapeo.PruebasMapeo
{
    class PruebaPermiso
    {
        static void Main2(string[] args)
        {
            Permiso p1 = new Permiso("admin", "PANTALLA1");
            Permiso p2 = new Permiso("admin", "PANTALLA2");
            Permiso p3 = new Permiso("admin", "PANTALLA3");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            p3.Acceso = true;
            p3.Aceptar = true;
            p3.Borrar = true;
            p3.Insertar = true;
            p3.Modificar = true;
            p3.Rechazar = true;
            p3.NombreRol = "gestor";
            p3.Pantalla = "PANTALLAAAA";
            Console.WriteLine(p3);
            p3.NombreRol = "admin";
            p3.Pantalla = "PANTALLA3";

            foreach(Permiso p in Permiso.ListaPermisosRol("admin"))
            {
                Console.WriteLine(p);
            }


        }
    }
}
