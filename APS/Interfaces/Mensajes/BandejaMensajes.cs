﻿using APS.Interfaces.Mensajes;
using APS.Interfaces.Personalizados;
using APS.Mapeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces.Perfil
{
    public partial class BandejaMensajes : Form
    {
        Usuario user;
        int envRec; // 0 para enviados -- 1 para recibidos

        public BandejaMensajes(Usuario user)
        {
            this.user = user;

            InitializeComponent();

            cargarMensajesRecibidos();
        }

        private void cargarMensajesRecibidos()
        {
            envRec = 1;
            panelMensajes.Controls.Clear();
            panelMensajes.RowCount = 1;
            panelMensajes.AutoScroll = false;
            panelMensajes.AutoScroll = true;
            

            List<Mensaje> mensajes = Mensaje.ListaMensajesRecibidos(user);
            CartelMensajes[] carMensajes = new CartelMensajes[mensajes.Count];

            int c = 0;
            foreach (Mensaje msg in mensajes)
            {
                Console.WriteLine(msg.ToString());
                carMensajes[c] = new CartelMensajes(msg);
                panelMensajes.Controls.Add(carMensajes[c], 0, c);
                panelMensajes.RowCount = panelMensajes.RowCount + 1;
                carMensajes[c].Location = new Point(carMensajes[c].Location.X, (carMensajes[c].Size.Height * c));

                //BOTONES GESTOR
                Panel panel = (Panel)carMensajes[c].Controls.Find("panel1", false)[0];
                Button bResponder = (Button)panel.Controls.Find("bResponder", false)[0];
                Button bEliminar = (Button)panel.Controls.Find("bEliminar", false)[0];

                //PROGRAMACIÓN BOTONES
                bResponder.Click += (sender, EventArgs) => { bResponder_Click(sender, EventArgs, msg); };
                bEliminar.Click += (sender, EventArgs) => { bEliminarRecibido_Click(sender, EventArgs, msg); };
                c++;
            }

        }

        private void bEliminarRecibido_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {
            user.RemoveMensaje(msg);
        }

        private void bResponder_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {
            NuevoMensaje newMsg = new NuevoMensaje(user, msg.Emisor);
            newMsg.ShowDialog();
            if (envRec == 0) cargarMensajesEnviados();
        }

        private void cargarMensajesEnviados()
        {
            envRec = 0;
            panelMensajes.Controls.Clear();
            panelMensajes.RowCount = 1;
            panelMensajes.AutoScroll = false;
            panelMensajes.AutoScroll = true;

            List<Mensaje> mensajes = Mensaje.ListaMensajesEnviados(user);
            CartelMensajes[] carMensajes = new CartelMensajes[mensajes.Count];

            int c = 0;
            foreach (Mensaje msg in mensajes)
            {
                carMensajes[c] = new CartelMensajes(msg);
                panelMensajes.Controls.Add(carMensajes[c], 0, c);
                panelMensajes.RowCount = panelMensajes.RowCount + 1;
                carMensajes[c].Location = new Point(carMensajes[c].Location.X, (carMensajes[c].Size.Height * c));

                //BOTONES GESTOR
                Panel panel = (Panel)carMensajes[c].Controls.Find("panel1", false)[0];
                Button bResponder = (Button)panel.Controls.Find("bResponder", false)[0];
                Button bEliminar = (Button)panel.Controls.Find("bEliminar", false)[0];

                //PROGRAMACIÓN BOTONES
                bResponder.Visible = false;
                bEliminar.Click += (sender, EventArgs) => { bEliminarEnviado_Click(sender, EventArgs, msg); };
                c++;
            }
        }

        private void bEliminarEnviado_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {
            user.RemoveMensaje(msg);
        }

        private void pictCont2_Click(object sender, EventArgs e) //Enviados
        {
            if(envRec == 1) cargarMensajesEnviados();
        }

        private void pictCont3_Click(object sender, EventArgs e) //Recibidos
        {
            if(envRec == 0) cargarMensajesRecibidos();
        }

        private void pictCont1_Click(object sender, EventArgs e) //Redactar
        {
            NuevoMensaje newMsg = new NuevoMensaje(user, null);
            newMsg.ShowDialog();
            if (envRec == 0) cargarMensajesEnviados();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
