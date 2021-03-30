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
                gridClientesX.DataSource = lst.ToList();
            }
            gridClientesX.Columns[0].DisplayIndex = 5;
            gridClientesX.Columns[1].DisplayIndex = 5;

            gridClientesX.Columns[0].Width = 65; //EDITAR
            gridClientesX.Columns[1].Width = 75; //ELIMINAR
            gridClientesX.Columns[2].Width = 70; //IDCliente
            gridClientesX.Columns[3].Width = 275; //Nombre
            gridClientesX.Columns[4].Width = 120; //Identidad
            gridClientesX.Columns[5].Width = 120; //Telefono
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
                return int.Parse(gridClientesX.Rows[gridClientesX.CurrentRow.Index].Cells[2].Value.ToString());
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

        private void gridClientesX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridClientesX.Columns[0].Index)//EDITAR
            {
                int? id = GetId();
                if (id != null)
                {
                    AgregarCliente oFrmTabla = new AgregarCliente(id);
                    oFrmTabla.ShowDialog();
                    refrescar();
                }
            }
            if (e.ColumnIndex == gridClientesX.Columns[1].Index)//ELIMINAR
            {
                int? id = GetId();
                DialogResult dialogResult = MessageBox.Show("Desea borrar " + id.ToString(), "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SSSMEntities db = new SSSMEntities())
                    {
                        Cliente oTabla = db.Cliente.Find(id);
                        db.Cliente.Remove(oTabla);
                        db.SaveChanges();
                    }
                }
            }
            refrescar();
        }
    }
}
