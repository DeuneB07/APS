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

        //
        //CARGAS
        //
        private void cargarMensajesRecibidos()
        {
            envRec = 1;
            panelMensajes.Controls.Clear();
            panelMensajes.RowCount = 1;
            panelMensajes.AutoScroll = false;
            panel1.AutoScroll = false;
            panel1.AutoScroll = true;


            List<Mensaje> mensajes = Mensaje.ListaMensajesRecibidos(user);
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
                bResponder.Click += (sender, EventArgs) => { bResponder_Click(sender, EventArgs, msg); };
                bEliminar.Click += (sender, EventArgs) => { bEliminarRecibido_Click(sender, EventArgs, msg); };
                c++;
            }

        }

        private void cargarMensajesEnviados()
        {
            envRec = 0;
            panelMensajes.Controls.Clear();
            panelMensajes.RowCount = 1;
            panelMensajes.AutoScroll = false;
            panel1.AutoScroll = false;
            panel1.AutoScroll = true;

            List<Mensaje> mensajes = Mensaje.ListaMensajesEnviados(user);
            CartelMensajes[] carMensajes = new CartelMensajes[mensajes.Count];

            int c = 0;
            foreach (Mensaje msg in mensajes)
            {
                carMensajes[c] = new CartelMensajes(msg);
                panelMensajes.Controls.Add(carMensajes[c], 0, c);
                panelMensajes.RowCount = panelMensajes.RowCount + 1;

                //BOTONES GESTOR
                Panel panel = (Panel)carMensajes[c].Controls.Find("panel1", false)[0];
                Button bResponder = (Button)panel.Controls.Find("bResponder", false)[0];
                Button bEliminar = (Button)panel.Controls.Find("bEliminar", false)[0];
                PictureBox pictNovedad = (PictureBox)panel.Controls.Find("pictNovedad", false)[0];
                pictNovedad.Visible = false;

                //PROGRAMACIÓN BOTONES
                bResponder.Visible = false;
                bEliminar.Click += (sender, EventArgs) => { bEliminarEnviado_Click(sender, EventArgs, msg); };
                c++;
            }
        }

        //
        //BOTONES CARTEL
        //
        private void bResponder_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {
            NuevoMensaje newMsg = new NuevoMensaje(user, msg.Emisor);
            newMsg.tAsunto.Text = msg.Asunto;
            newMsg.tAsunto.Enabled = false;
            newMsg.ShowDialog();
            if (envRec == 0) cargarMensajesEnviados();
            else cargarMensajesRecibidos(); //Se pueden enviar mensajes a uno mismo
        }

        private void bEliminarRecibido_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {

            msg.BorradoReceptor = true;
            msg.Leido = true;
            user.RemoveMensajeRecibido(msg);

            if (msg.BorradoEmisor == true) msg.BorraMensaje();
            /*if (msg.Emisor.Equals(msg.Receptor))
            {
                user.RemoveMensajeEnviado(msg);
                msg.BorraMensaje();
            }*/

            cargarMensajesRecibidos();

        }

        private void bEliminarEnviado_Click(object sender, EventArgs eventArgs, Mensaje msg)
        {
            try
            {
                msg.BorradoEmisor = true;
                user.RemoveMensajeEnviado(msg);

                if (msg.BorradoReceptor == true) msg.BorraMensaje();
                /*if (msg.Emisor.Equals(msg.Receptor))
                {
                    user.RemoveMensajeRecibido(msg);
                    msg.BorraMensaje();
                }*/

                cargarMensajesEnviados();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        //
        //REDACTAR
        //
        private void pictCont1_Click(object sender, EventArgs e)
        {
            NuevoMensaje newMsg = new NuevoMensaje(user, null);
            newMsg.ShowDialog();
            if (envRec == 0) cargarMensajesEnviados();
        }

        private void pictEscribir_Click(object sender, EventArgs e)
        {
            NuevoMensaje newMsg = new NuevoMensaje(user, null);
            newMsg.ShowDialog();
            if (envRec == 0) cargarMensajesEnviados();
        }

        //
        //ENVIADOS
        //
        private void pictCont2_Click(object sender, EventArgs e)
        {
            if(envRec == 1) cargarMensajesEnviados();
        }

        private void pictEnviados_Click(object sender, EventArgs e)
        {
            if (envRec == 1) cargarMensajesEnviados();
        }

        //
        //RECIBIDOS
        //
        private void pictCont3_Click(object sender, EventArgs e)
        {
            if(envRec == 0) cargarMensajesRecibidos();
        }

        private void pictRecibidos_Click(object sender, EventArgs e)
        {
            if (envRec == 0) cargarMensajesRecibidos();
        }

        //
        //SALIR
        //
        private void bSalir_Click(object sender, EventArgs e)
        {
            foreach(Mensaje m in user.MensajesRecibidos) m.Leido = true;
            this.Close();
        }

        private void BandejaMensajes_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Mensaje m in user.MensajesRecibidos) m.Leido = true;
        }
    }
}
