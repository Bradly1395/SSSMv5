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
    public partial class CrearTrabajo : MetroFramework.Forms.MetroForm
    {
        int idAtencion;
        int idCliente;
        public string clientex;
        public string tipox;
        public int? id;
        Trabajo oTabla = null;
        public CrearTrabajo(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void cargaDatos()
        {
            cargarCombox();
            using (SSSMEntities db = new SSSMEntities())
            {
                oTabla = db.Trabajo.Find(id);
                descripcion.Text = oTabla.Descripcion;
                valor.Text = oTabla.Valor.ToString();
                atencionCmb.Text = tipox; //WORKING
                clientecmb.Text = clientex; // WORKING
            }
        }

        void cargarCombox()
        {
            /*COMBOBOX CLIENTE START */
            SSSMEntities entities = new SSSMEntities();
            List<Cliente> cliente = (from Cliente in entities.Cliente
                                     select Cliente).OrderBy(c => c.Nombre).ToList();

            clientecmb.DataSource = cliente;
            clientecmb.DisplayMember = "Nombre";
            clientecmb.ValueMember = "IDCliente";
            /*COMBOBOX CLIENTE END */

            /*COMBOBOX START */
            SSSMEntities atencion = new SSSMEntities();
            List<TipoTrabajo> tipoT = (from TipoTrabajo in atencion.TipoTrabajo
                                       select TipoTrabajo).OrderBy(c => c.Descripcion1).ToList();

            atencionCmb.DataSource = tipoT;
            atencionCmb.DisplayMember = "Descripcion1";
            atencionCmb.ValueMember = "IDTipo";
            /*COMBOBOX END */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();

            cargarCombox();
            if (id != null)
            {
                cargaDatos();
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
                    oTabla = new Trabajo();

                //REFACTOR THIS---
                var lst = from a in db.Cliente
                          where a.Nombre == clientecmb.Text
                          select a;
                Cliente tabla = lst.FirstOrDefault<Cliente>();
                if (tabla != null) 
                    idCliente = tabla.IDCliente;
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
                    db.Trabajo.Add(oTabla);
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

        private void atencionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string costo = "";

            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = from a in db.TipoTrabajo
                           where a.Descripcion1 == atencionCmb.Text
                           select a;
                TipoTrabajo tabla = lst.FirstOrDefault<TipoTrabajo>();
                if (tabla != null)
                {
                    costo = tabla.Precio.ToString();
                    idAtencion = tabla.IDTipo;
                }
                    
            }

            this.valor.Text = costo;

        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea finalizar el trabajo? ", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SSSMEntities db = new SSSMEntities())
                {
                    //REFACTOR THIS---
                    var lst = from a in db.Cliente
                              where a.Nombre == clientecmb.Text
                              select a;
                    Cliente tabla = lst.FirstOrDefault<Cliente>();
                    if (tabla != null)
                        idCliente = tabla.IDCliente;
                    //END---

                    oTabla.Descripcion = descripcion.Text;
                    oTabla.Valor = Convert.ToInt32(valor.Text);
                    oTabla.TipoTrabajo = idAtencion;
                    oTabla.Usuario = Properties.Settings.Default.UserID;
                    oTabla.Cliente = idCliente;

                    var date = db.Database.SqlQuery<DateTime>("select getDate()");
                    oTabla.Estado = "Entregado";
                    oTabla.FechaSalida = date.AsEnumerable().First();
                    db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    this.Close();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atencionCmb.Text = tipox; //FIX ME
            clientecmb.Text = clientex; // FIX ME
        }
    }
}
