using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSSM.Models;

namespace SSSM
{
    public partial class AgregarCliente : MetroFramework.Forms.MetroForm
    {
        public int? id;
        Cliente  oTabla = null;

        public AgregarCliente(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                cargaDatos();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cargaDatos()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                oTabla = db.Cliente.Find(id);
                nombre.Text = oTabla.Nombre;
                identidad.Text = oTabla.Identidad;
                telefono.Text = oTabla.Telefono;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                if (id == null)
                    oTabla = new Cliente();

                oTabla.Nombre = nombre.Text;
                oTabla.Identidad = identidad.Text;
                oTabla.Telefono = telefono.Text;

                if (id == null)
                    db.Cliente.Add(oTabla);
                else
                {
                    db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();

            }
        }

        private void identidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }
    }
}
