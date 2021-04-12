using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSSM.Models;

namespace SSSM
{
    public partial class EditarEmpleado : MetroFramework.Forms.MetroForm
    {
        public int? id;
        Usuario oTabla = null;

        public EditarEmpleado(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                cargaDatos();
            }
        }

        private void cargaDatos()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                oTabla = db.Usuario.Find(id);
                nombre.Text = oTabla.Nombre;
                user.Text = oTabla.Usuario1;

                if (oTabla.TipoUsuario == "Usuario")
                    radUser.Checked = true;
                else
                    radAdmin.Checked = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radUser.Checked = true;
            estadoCmb.Items.Add("Activo");
            estadoCmb.Items.Add("Inactivo");
            estadoCmb.Items.Add("CambiarClave");
            estadoCmb.SelectedIndex = 0;
            cargaDatos();
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

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clave = Mantenimiento.Encrypt(pass.Text);
            string puesto;

            if (radUser.Checked)
                puesto = "Usuario";
            else
                puesto = "Administrador";

            using (SSSMEntities db = new SSSMEntities())
            {
                oTabla.Nombre = nombre.Text;
                oTabla.Clave = clave;
                oTabla.Estado = estadoCmb.Text;
                oTabla.TipoUsuario = puesto;

                db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                this.Close();

            }
        }
    }
}
