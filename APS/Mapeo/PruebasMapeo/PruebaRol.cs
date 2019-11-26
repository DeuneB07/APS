using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo.PruebasMapeo
{
    class PruebaRol { 

    static void Main2(string[] args) 
        {
            foreach(Rol r in Rol.ListaRoles())
            {
                Console.WriteLine("ROL " + r.NombreRol);
                Console.WriteLine("Acceso Pantalla Pantalla1: " + r.Acceso("PANTALLA1"));
                foreach(Permiso p in r.Permisos)
                {
                    Console.WriteLine("\t" + p);
                }
            }
        }
    }
}
