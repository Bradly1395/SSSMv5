using SSSM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    public partial class AgregarTipoTrabajo : MetroFramework.Forms.MetroForm
    {
        public int? id;
        TipoTrabajo oTabla = null;
        public AgregarTipoTrabajo(int? id = null)
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
                oTabla = db.TipoTrabajo.Find(id);
                nombre.Text = oTabla.Descripcion1;
                costo.Text = oTabla.Precio.ToString();
            }
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
            if (string.IsNullOrWhiteSpace(nombre.Text) == false && string.IsNullOrWhiteSpace(costo.Text) == false)
            {
                using (SSSMEntities db = new SSSMEntities())
                {
                    if (id == null)
                        oTabla = new TipoTrabajo();

                    oTabla.Descripcion1 = nombre.Text;
                    oTabla.Precio = Convert.ToDouble(costo.Text);


                    if (id == null)
                        db.TipoTrabajo.Add(oTabla);
                    else
                    {
                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    this.Close();

                }
            }
            else
                MessageBox.Show("No se permiten espacios en blanco");
        }

        private void costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }
    }
}
