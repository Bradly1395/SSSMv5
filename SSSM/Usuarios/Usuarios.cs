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
    public partial class Usuarios : MetroFramework.Forms.MetroForm
    {
        
        public Usuarios()
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
                var lst = from d in db.Usuario
                          select d;
                gridUsuarios.DataSource = lst.ToList();
            }
            gridUsuarios.Columns[0].DisplayIndex = 7;
            gridUsuarios.Columns[1].DisplayIndex = 7;

            gridUsuarios.Columns[0].Width = 65; //EDITAR
            gridUsuarios.Columns[1].Width = 75; //ELIMINAR
            //gridUsuarios.Columns[2].Width = 60; //ID
            //gridUsuarios.Columns[3].Width = 120; //TIPOTRABAJO
            //gridUsuarios.Columns[4].Width = 135; //DESCRIPCION
            //gridUsuarios.Columns[5].Width = 50; //VALOR
            //gridUsuarios.Columns[6].Width = 120; //CLIENTE
            //gridUsuarios.Columns[7].Width = 115; //FECHAENTRADA
            //gridUsuarios.Columns[8].Width = 115; //FECHASALIDA
            //gridUsuarios.Columns[9].Width = 65; //ESTADO
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
            AgregarEmpleado ae = new AgregarEmpleado();
            ae.ShowDialog();
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            EditarEmpleado ee = new EditarEmpleado();
            ee.ShowDialog();
        }
    }
}
