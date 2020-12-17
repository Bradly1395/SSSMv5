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
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Nueva Contraseña")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
                txtuser.UseSystemPasswordChar = true;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Nueva Contraseña";
                txtuser.ForeColor = Color.Silver;
                txtuser.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Confirmar Contraseña")
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
                txtpass.Text = "Confirmar Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion

        private void CambiarClave_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) == true || string.IsNullOrWhiteSpace(txtpass.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios.");
            }
            else 
            {
                if (txtuser.Text == txtpass.Text)
                {
                    string passEncrypt = Mantenimiento.Encrypt(txtpass.Text);
                    using (SSSMEntities db = new SSSMEntities())
                    {
                        Usuario otabla = db.Usuario.Find(Properties.Settings.Default.UserID); ;
                        otabla.Clave = passEncrypt;
                        otabla.Estado = "Activo";
                        db.Entry(otabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Se actualizo la contraseña correctamente.");
                        Login log = new Login();
                        log.Show();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Contraseñas no coinciden.");
            }
        }
    }
}
