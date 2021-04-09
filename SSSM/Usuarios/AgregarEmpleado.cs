using SSSM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    public partial class AgregarEmpleado : MetroFramework.Forms.MetroForm
    {
        
        public AgregarEmpleado()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            string tipo;
            if (radUser.Checked)
                tipo = "Usuario";
            else
                tipo = "Administrador";

            string passEncrypt = Mantenimiento.Encrypt(pass.Text);

            using (SSSMEntities db = new SSSMEntities())
            {
                Usuario oTabla = new Usuario();

                oTabla.Nombre = nombre.Text;
                oTabla.Clave = passEncrypt;
                oTabla.Usuario1 = usuario.Text;
                oTabla.TipoUsuario = tipo;
                oTabla.Estado = "CambiarClave";

                db.Usuario.Add(oTabla);
                db.SaveChanges();

                this.Close();
            }

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloLetras(e);
        }
    }
}
