﻿using System;
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

        private int? GetId()
        {
            try
            {
                return int.Parse(gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[2].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }

        }

        private void refrescar()
        {
            using (SSSMEntities db = new SSSMEntities())
            {
                var lst = (from d in db.Usuario
                          select new
                          {
                              ID = d.ID,
                              d.Nombre,
                              Usuario = d.Usuario1,
                              d.TipoUsuario,
                              d.Estado
                          }).ToList();
                gridUsuarios.DataSource = lst.ToList();
            }
            gridUsuarios.Columns[0].DisplayIndex = 6;
            gridUsuarios.Columns[1].DisplayIndex = 6;

            gridUsuarios.Columns[0].Width = 65; //EDITAR
            gridUsuarios.Columns[1].Width = 75; //ELIMINAR
            gridUsuarios.Columns[2].Width = 60; //ID
            gridUsuarios.Columns[3].Width = 150; //NOMBRE
            gridUsuarios.Columns[4].Width = 120; //USUARIO
            gridUsuarios.Columns[6].Width = 70; //ESTADO

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
            refrescar();
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            EditarEmpleado ee = new EditarEmpleado();
            ee.ShowDialog();
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridUsuarios.Columns[0].Index)//EDITAR
            {
                int? id = GetId();
                if (id != null)
                {
                    EditarEmpleado oFrmTabla = new EditarEmpleado(id);
                    oFrmTabla.ShowDialog();
                    refrescar();
                }
            }
            if (e.ColumnIndex == gridUsuarios.Columns[1].Index)//ELIMINAR
            {
                int? id = GetId();
                DialogResult dialogResult = MessageBox.Show("Desea borrar " + id.ToString(), "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SSSMEntities db = new SSSMEntities())
                    {
                        Usuario oTabla = db.Usuario.Find(id);
                        db.Usuario.Remove(oTabla);

                        //LOG START
                        Logs oTabla2 = new Logs();
                        oTabla2.Usuario = Properties.Settings.Default.UserName.ToString();
                        oTabla2.Descripcion = "Eliminar Empleado " + oTabla.Nombre;
                        oTabla2.Elemento = "Empleado";
                        var date = db.Database.SqlQuery<DateTime>("select getDate()");
                        oTabla2.Fecha = date.AsEnumerable().First();
                        db.Logs.Add(oTabla2);
                        //LOG END

                        db.SaveChanges();
                    }
                }
            }
            refrescar();
        }
    }
}
