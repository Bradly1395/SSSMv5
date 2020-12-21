using RecursoHumano;
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
using Excel = Microsoft.Office.Interop.Excel;
using SSSM.Models;

namespace SSSM
{
    public partial class PantallaPrincipal : Form
    {
        int type = 1;
        public PantallaPrincipal()
        {
            InitializeComponent();
 
            
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(gridTrabajos.Rows[gridTrabajos.CurrentRow.Index].Cells[2].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }

        }

        private int? GetIdEncargo()
        {
            try
            {
                return int.Parse(gridEncargos.Rows[gridEncargos.CurrentRow.Index].Cells[2].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refrescar()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = (from d in db.Trabajo
                           join c in db.TipoTrabajo on d.TipoTrabajo equals c.IDTipo
                           join b in db.Cliente on d.Cliente equals b.IDCliente
                           join a in db.Usuario on d.Usuario equals a.ID
                          where d.Usuario == Properties.Settings.Default.UserID & d.Estado=="Activo"
                          select new 
                          {
                              ID=d.IDTrabajo,
                              TipoTrabajo=c.Descripcion1,
                              d.Descripcion,
                              d.Valor,
                              Cliente = b.Nombre,
                              d.FechaEntrada,
                              d.FechaSalida,
                              d.Estado
                          }).Take(5).ToList();
                gridTrabajos.DataSource = lst.ToList();
            }
            gridTrabajos.Columns[0].DisplayIndex = 9;
            gridTrabajos.Columns[1].DisplayIndex = 9;

            gridTrabajos.Columns[0].Width = 65; //EDITAR
            gridTrabajos.Columns[1].Width = 75; //ELIMINAR
            gridTrabajos.Columns[2].Width = 60; //ID
            gridTrabajos.Columns[3].Width = 120; //TIPOTRABAJO
            gridTrabajos.Columns[4].Width = 135; //DESCRIPCION
            gridTrabajos.Columns[5].Width = 50; //VALOR
            gridTrabajos.Columns[6].Width = 120; //CLIENTE
            gridTrabajos.Columns[7].Width = 115; //FECHAENTRADA
            gridTrabajos.Columns[8].Width = 115; //FECHASALIDA
            gridTrabajos.Columns[9].Width = 65; //ESTADO
        }

        private void refrescarEncargos()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = (from a in db.Encargo
                           join c in db.TipoTrabajo on a.TipoTrabajo equals c.IDTipo
                           join b in db.Usuario on a.Encargado equals b.ID
                           where a.Encargado == Properties.Settings.Default.UserID & a.Estado == "Activo"
                           select new
                           {
                               ID = a.IDEncargo,
                               TipoTrabajo = c.Descripcion1,
                               a.Observacion,
                               a.Valor,
                               Cliente = a.NombreCliente,
                               a.NumeroDeTelefono,
                               a.FechaEntrada,
                               a.Estado
                           }).Take(5).ToList();
                gridEncargos.DataSource = lst.ToList();
            }
            gridEncargos.Columns[0].DisplayIndex =9;
            gridEncargos.Columns[1].DisplayIndex = 9;

            gridEncargos.Columns[0].Width = 65; //EDITAR
            gridEncargos.Columns[1].Width = 75; //ELIMINAR
            gridEncargos.Columns[2].Width = 60; //ID
            gridEncargos.Columns[3].Width = 120; //TIPOTRABAJO
            gridEncargos.Columns[4].Width = 135; //DESCRIPCION
            gridEncargos.Columns[5].Width = 50; //VALOR
            gridEncargos.Columns[6].Width = 120; //CLIENTE
            gridEncargos.Columns[7].Width = 115; //NUMERODETELEFONO
            gridEncargos.Columns[8].Width = 115; //FECHAENTRADA
            gridEncargos.Columns[9].Width = 65; //ESTADO
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabControlTE.SelectedIndex = 0;

            bienvenido.Text = "BIENVENIDO(A) " + Properties.Settings.Default.UserName.ToUpper();

            if (Properties.Settings.Default.UserAdmin=="Administrador")
            {
                btnUsers.Visible = true;
                btnParam.Visible = true;
                buttonDB.Visible = true;
            }

            refrescar();
            refrescarEncargos();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Parametros par = new Parametros();
            par.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            passDB x = new passDB();
            x.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporte rer = new Reporte(type);
            rer.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login emp = new Login();
            emp.FormClosed += (s, args) => this.Close();
            emp.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelectorEdit sel = new SelectorEdit();
            sel.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea reiniciar la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea reiniciar la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CrearPedido c = new CrearPedido();
            c.ShowDialog();
            refrescarEncargos();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CrearTrabajo c = new CrearTrabajo();
            c.ShowDialog();
            refrescar();
        }

        private void gridTrabajos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridTrabajos.Columns[0].Index)//EDITAR
            {
                int? id = GetId();
                if (id != null)
                {
                    CrearTrabajo oFrmTabla = new CrearTrabajo(id);
                    oFrmTabla.tipox = gridTrabajos.CurrentRow.Cells[3].Value.ToString();//TODO FIX THIS --WORKS
                    oFrmTabla.clientex = gridTrabajos.CurrentRow.Cells[6].Value.ToString();//TODO FIX THIS --WORKS
                    oFrmTabla.finalizarBtn.Visible = true;
                    //MessageBox.Show(oFrmTabla.clientex + " "+ oFrmTabla.tipox); ***FOR TESTING
                    oFrmTabla.ShowDialog();
                    refrescar();
                }
            }
            if (e.ColumnIndex == gridTrabajos.Columns[1].Index)//ELIMINAR
            {
                int? id = GetId();
                DialogResult dialogResult = MessageBox.Show("Desea borrar " + id.ToString(), "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SSSMEntities db = new SSSMEntities())
                    {
                        Trabajo oTabla = db.Trabajo.Find(id);
                        db.Trabajo.Remove(oTabla);
                        db.SaveChanges();
                    }
                }
            }

            refrescar();
        }

        private void gridEncargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridEncargos.Columns[0].Index)//EDITAR
            {
                int? id = GetIdEncargo();
                if (id != null)
                {
                    CrearPedido oFrmTabla = new CrearPedido(id);
                    oFrmTabla.tipox = gridEncargos.CurrentRow.Cells[3].Value.ToString();//TODO FIX THIS --WORKS
                    //oFrmTabla.clientex = gridEncargos.CurrentRow.Cells[6].Value.ToString();
                    oFrmTabla.finalizarBtn.Visible = true;
                    //MessageBox.Show(oFrmTabla.clientex + " "+ oFrmTabla.tipox); ***FOR TESTING
                    oFrmTabla.ShowDialog();
                    refrescar();
                }
            }
            if (e.ColumnIndex == gridEncargos.Columns[1].Index)//ELIMINAR
            {
                int? id = GetIdEncargo();
                DialogResult dialogResult = MessageBox.Show("Desea borrar " + id.ToString(), "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SSSMEntities db = new SSSMEntities())
                    {
                        Encargo oTabla = db.Encargo.Find(id);
                        db.Encargo.Remove(oTabla);
                        db.SaveChanges();
                    }
                }
            }

            refrescarEncargos();
        }
    }
}
