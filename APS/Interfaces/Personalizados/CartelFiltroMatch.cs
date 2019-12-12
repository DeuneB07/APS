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
    public partial class CartelFiltroMatch : UserControl
    {

        private Usuario usr;

        public CartelFiltroMatch(Usuario usr)
        {
            InitializeComponent();
            this.usr = usr;
            cargarPreferencias();
        }

        private void cargarPreferencias()
        {
            foreach(Preferencia p in usr.Preferencias)
            {
                cPreferencia.Items.Add(p);
            }
            cPreferencia.DisplayMember = "nombrePreferencia"; // grado.nombreGrado // asig.nombreAsig";
        }
    }
}