using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Personalizados
{
    public partial class CartelHistorial : UserControl
    {

        public CartelHistorial(Mapeo.Historial historial)
        {
            InitializeComponent();
            lblComentario.Text = historial.Comentario;
            lblFecha.Text = historial.Fecha.ToString();
            if(historial.Actividad != null)
            {
                this.bVerTodo.Visible = true;
                this.bVerTodo.Enabled = true;
            }
        }

        #region Properties
        private string _comentario;

        [Category("Custom Props")]
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; lblComentario.Text = value; }
        }

        #endregion

    }
}
