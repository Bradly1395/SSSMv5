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
    public partial class CrearPedido : MetroFramework.Forms.MetroForm
    {
        int idAtencion;
        public string tipox;
        public int? id;
        Encargo oTabla = null;
        public CrearPedido()
        {
            InitializeComponent();
        }

        public int counter;
        public int diasV;
        private void vacaciones_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)//GUARDAR
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                if (id == null)
                    oTabla = new Encargo();

                //REFACTOR THIS---
                //var lst = from a in db.Cliente
                //          where a.Nombre == clientecmb.Text
                //          select a;
                //Cliente tabla = lst.FirstOrDefault<Cliente>();
                //if (tabla != null)
                //    idCliente = tabla.IDCliente;
                //END---

                oTabla.Descripcion = descripcion.Text;
                oTabla.Valor = Convert.ToInt32(valor.Text);
                oTabla.TipoTrabajo = idAtencion;
                oTabla.Usuario = Properties.Settings.Default.UserID;
                oTabla.Estado = "Activo";
                oTabla.Cliente = idCliente;

                if (id == null)
                {
                    var date = db.Database.SqlQuery<DateTime>("select getDate()");
                    oTabla.FechaEntrada = date.AsEnumerable().First();
                    db.Encargo.Add(oTabla);
                }
                else
                {
                    var date = db.Database.SqlQuery<DateTime>("select getDate()");
                    oTabla.FechaSalida = date.AsEnumerable().First();
                    db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void costo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(abono.Text) || string.IsNullOrWhiteSpace(costo.Text))
            {
                saldo.Text = "0.00";
            }
            else
            {
                saldo.Text = Convert.ToString(Convert.ToInt32(costo.Text) - Convert.ToInt32(abono.Text));
            }
        }

        private void abono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(abono.Text) || string.IsNullOrWhiteSpace(costo.Text))
            {
                saldo.Text = "0.00";
            }
            else
            {
                saldo.Text = Convert.ToString(Convert.ToInt32(costo.Text) - Convert.ToInt32(abono.Text));
            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)//FINALIZAR
        {

        }
    }
}
