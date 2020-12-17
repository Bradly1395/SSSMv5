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
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        
        public Clientes()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = from d in db.Cliente
                          select d;
                gridClientes.DataSource = lst.ToList();
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

        } 

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void regresarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregaruserbtn_Click(object sender, EventArgs e)
        {
            AgregarCliente ag = new AgregarCliente();
            ag.ShowDialog();
            refrescar();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(gridClientes.Rows[gridClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }

        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarCliente oFrmTabla = new AgregarCliente(id);
                oFrmTabla.ShowDialog();
                refrescar();
            }
        }
    }
}
