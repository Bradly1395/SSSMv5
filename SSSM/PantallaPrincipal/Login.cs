using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SSSM.Models;

namespace SSSM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion

        private void btnlogin_Click(object sender, EventArgs e)
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                string passEncrypt = Mantenimiento.Encrypt(txtpass.Text);
                var lst = from d in db.Usuario
                          where d.Usuario1 == txtuser.Text
                          && d.Clave == passEncrypt
                          select d;
                if (lst.Count() > 0)
                {
                    Usuario otabla = lst.FirstOrDefault<Usuario>();
                    Properties.Settings.Default.UserID = otabla.ID;
                    switch (otabla.Estado)
                    {
                        case "Activo":
                            Properties.Settings.Default.UserAdmin = otabla.TipoUsuario;
                            Properties.Settings.Default.UserName = otabla.Nombre;
                            this.Hide();
                            PantallaPrincipal frm = new PantallaPrincipal();
                            frm.FormClosed += (s, args) => this.Close();
                            frm.Show();
                            break;
                        case "Inactivo":
                            MessageBox.Show("Usuario Inactivo");
                            break;
                        case "CambiarClave":
                            CambiarClave clave = new CambiarClave();
                            clave.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }

            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(this, new EventArgs());
            }
        }
    }
}
