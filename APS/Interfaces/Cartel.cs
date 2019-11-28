﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces
{
    public partial class Cartel : UserControl
    {
        public Cartel()
        {
            InitializeComponent();
        }

        #region Properties
        private string _title;
        private string _description;
        private Image _icon;

        [Category("Custom Props")]
        public string Titulo
        {
            get { return _title; }
            set { _title = value; labelTitulo.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lDescripcion.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImagenActividad
        {
            get { return _icon; }
            set { _icon = value; pict.Image = value; }
        }

        #endregion
    }
}
