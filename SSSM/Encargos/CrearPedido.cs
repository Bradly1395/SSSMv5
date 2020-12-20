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
            cargarCombox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void cargarCombox()
        {
            /*COMBOBOX START */
            SSSMEntities atencion = new SSSMEntities();
            List<TipoTrabajo> tipoT = (from TipoTrabajo in atencion.TipoTrabajo
                                       select TipoTrabajo).OrderBy(c => c.Descripcion1).ToList();

            atencionCmb.DataSource = tipoT;
            atencionCmb.DisplayMember = "Descripcion1";
            atencionCmb.ValueMember = "IDTipo";
            /*COMBOBOX END */
        }

        private void button4_Click(object sender, EventArgs e)//GUARDAR
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                if (id == null)
                    oTabla = new Encargo();

                //INSERT START
                oTabla.Observacion = descripcion.Text;
                oTabla.Valor = Convert.ToInt32(costo.Text);
                oTabla.Abono = Convert.ToInt32(abono.Text);
                oTabla.TipoTrabajo = idAtencion;
                oTabla.Encargado = Properties.Settings.Default.UserID;
                oTabla.Estado = "Activo";
                oTabla.NombreCliente = cliente.Text;
                oTabla.NumeroDeTelefono = telefono.Text;
                //INSERT END
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

        private void atencionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = from a in db.TipoTrabajo
                          where a.Descripcion1 == atencionCmb.Text
                          select a;
                TipoTrabajo tabla = lst.FirstOrDefault<TipoTrabajo>();
                if (tabla != null)
                {
                    idAtencion = tabla.IDTipo;
                }

            }
        }
    }
}
