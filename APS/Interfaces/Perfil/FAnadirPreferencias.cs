﻿using APS.Mapeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APS.Mapeo.Actividad;

namespace APS.Interfaces
{
    public partial class FAnadirPreferencias : Form
    {

        Usuario user;

        public FAnadirPreferencias(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            cargarTipoActividad();
            cargarCompetencias();
            cargarGrados();
            cargarAsignaturas();
        }

        private void cargarTipoActividad()
        {
            if (user.Rol.NombreRol.Equals("Estudiante"))
            {
                comboTipo.Items.Add("Formación");
                comboTipo.Items.Add("Investigación");
            }
        }

        private void cargarCompetencias()
        {
            foreach(Competencia c in Competencia.ListaCompetencias())
            {
                listCompetencias.Items.Add(c);
            }
            listCompetencias.DisplayMember = "nombreComp";
        }

        private void cargarGrados()
        {
            foreach(Grado g in user.Grados)
            {
                comboGrado.Items.Add(g);
            }
            comboGrado.DisplayMember = "nombreGrado";
        }

        private void cargarAsignaturas()
        {
            foreach(Asignatura a in user.Asignaturas)
            {
                comboAsig.Items.Add(a);
            }
            comboAsig.DisplayMember = "nombreAsig";
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            Preferencia p = null;
            try
            {
                Asignatura a = (Asignatura)comboAsig.SelectedItem;
                Grado g = (Grado)comboGrado.SelectedItem;

                p = new Preferencia(textNombreComp.Text, user);
                if(!comboGrado.Text.Equals("")) p.Grado = g;
                if(!comboAsig.Text.Equals("")) p.Asignatura = a;

                TipoActividadE resTipo;
                TurnoE resTurno;

                Enum.TryParse<TurnoE>(comboTurno.Text, true, out resTurno);
                if(!comboTurno.Text.Equals("")) p.Turno = resTurno;

                Enum.TryParse<TipoActividadE>(comboTipo.Text, true, out resTipo);
                if(!comboTipo.Text.Equals("")) p.TipoActividad = resTipo;


                if (comboHoras.Text != "") p.HorasPosibles = int.Parse(comboHoras.Text);

                foreach (Competencia c in listCompetencias.SelectedItems)
                {
                    p.AddCompetencia(c);
                }

                user.AddPreferencia(p);
                MessageBox.Show("Preferencia insertada con éxito");
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (p != null) p.RemovePreferencia();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAnadirPreferencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wePassDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.wePassDataSet.Grados);

        }

        private void comboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grado g = (Grado) comboGrado.SelectedItem;
            cargarAsignaturas(g);
        }

        private void cargarAsignaturas(Grado g)
        {
            comboAsig.Items.Clear();
            foreach(Asignatura a in Asignatura.ListaAsignaturas(g))
            {
                if(user.Asignaturas.Contains(a)) comboAsig.Items.Add(a);
            }
            comboAsig.DisplayMember = "nombreAsig";
        }
    }
}
