﻿using System;
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
    public partial class CartelMensajes : UserControl
    {

        private Mensaje m;

        public CartelMensajes(Mensaje m)
        {
            InitializeComponent();
            this.m = m;

            if (m.Leido) pictNovedad.Visible = false;
            if (m.Asunto != null && !m.Asunto.Equals("")) lShowAsunto.Text = m.Asunto;
            lShowMensaje.Text = m.Texto;
            lShowRemite.Text = m.Emisor.Email;
            lShowDest.Text = m.Receptor.Email;
            lShowFecha.Text = m.Date.ToShortDateString();
        }

    }
}
