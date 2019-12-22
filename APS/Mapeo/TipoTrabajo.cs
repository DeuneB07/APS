using APS.BD;
using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Mapeo
{
    public class TipoTrabajo
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private string tipoTrabajo;

        public static List<TipoTrabajo> ListaTipoTrabajo()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<TipoTrabajo> lista = new List<TipoTrabajo>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_TipoTrabajo FROM Tipo_Trabajo;"))
            {
                int id = (int)tupla[0];
                TipoTrabajo t = new TipoTrabajo(id);
                lista.Add(t);
            }
            return lista;
        }

        public TipoTrabajo(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sel = "SELECT * FROM Tipo_Trabajo WHERE ID_TipoTrabajo =" + id + ";";
            Object[] tupla = miBD.Select(sel)[0];
            this.id = id;
            this.tipoTrabajo = tupla[1].ToString();
        }

        public TipoTrabajo(string tipoTrabajo, Boolean b)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sel = "SELECT * FROM Tipo_Trabajo WHERE tipoTrabajo ='" + tipoTrabajo + "';";
            Object[] tupla = miBD.Select(sel)[0];
            this.id = int.Parse(tupla[0].ToString());
            this.tipoTrabajo = tupla[1].ToString();
        }

        public TipoTrabajo(string tipoTrabajo)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string ins = "INSERT INTO Tipo_Trabajo (tipoTrabajo) VALUES ('" + tipoTrabajo + "');";
            miBD.Insert(ins);
            this.id = (int)miBD.SelectScalar("SELECT max(ID_TipoTrabajo) FROM Tipo_Trabajo;");
            this.tipoTrabajo = tipoTrabajo;
        }

        public int ID_TipoTrabajo
        {
            get { return id; }
            set
            {
                throw new BDException("Error: ID_TipoTrabajo no se puede cambiar, es autoindexado");
            }
        }

        public string Tipo_Trabajo
        {
            get { return tipoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Tipo_Trabajo SET tipoTrabajo='" + value + "' "
                        + "WHERE ID_TipoTrabajo=" + this.id + ";";
                miBD.Update(up);
                this.tipoTrabajo = value;
            }
        }

        public override string ToString()
        {
            return tipoTrabajo;
        }

        public override bool Equals(object obj)
        {
            return obj is TipoTrabajo && (((TipoTrabajo)obj).ID_TipoTrabajo.CompareTo(this.ID_TipoTrabajo) == 0);
        }

        public override int GetHashCode()
        {
            return ID_TipoTrabajo.GetHashCode();
        }


    }
}
