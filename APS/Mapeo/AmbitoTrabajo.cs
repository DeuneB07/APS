using APS.BD;
using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Mapeo
{
    public class AmbitoTrabajo
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private string ambitoTrabajo;


        public static List<AmbitoTrabajo> ListaAmbitoTrabajo()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<AmbitoTrabajo> lista = new List<AmbitoTrabajo>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_AmbitoTrabajo FROM Ambito_Trabajo;"))
            {
                int id = (int)tupla[0];
                AmbitoTrabajo a = new AmbitoTrabajo(id);
                lista.Add(a);
            }
            return lista;
        }

        public AmbitoTrabajo(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sel = "SELECT * FROM Ambito_Trabajo WHERE ID_AmbitoTrabajo =" + id + ";";
            Object[] tupla = miBD.Select(sel)[0];
            this.id = id;
            this.ambitoTrabajo = tupla[1].ToString();
        }

        public AmbitoTrabajo(string ambitoTrabajo)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string ins = "INSERT INTO Ambito_Trabajo (ambitoTrabajo) VALUES ('" + ambitoTrabajo + "');";
            miBD.Insert(ins);
            this.id = (int)miBD.SelectScalar("SELECT max(ID_AmbitoTrabajo) FROM Ambito_Trabajo;");
            this.ambitoTrabajo = ambitoTrabajo;
        }

        public int ID_AmbitoTrabajo
        {
            get { return id; }
            set
            {
                throw new BDException("Error: ID_TipoTrabajo no se puede cambiar, es autoindexado");
            }
        }

        public string Ambito_Trabajo
        {
            get { return ambitoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Ambito_Trabajo SET ambitoTrabajo='" + value + "' "
                        + "WHERE ID_AmbitoTrabajo=" + this.id + ";";
                miBD.Update(up);
                this.ambitoTrabajo = value;
            }
        }

        public override string ToString()
        {
            return Ambito_Trabajo;
        }

        public override bool Equals(object obj)
        {
            return obj is AmbitoTrabajo && (((AmbitoTrabajo)obj).ID_AmbitoTrabajo.CompareTo(this.ID_AmbitoTrabajo) == 0);
        }

        public override int GetHashCode()
        {
            return ID_AmbitoTrabajo.GetHashCode();
        }

    }
}
