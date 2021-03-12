using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSSM
{
    public partial class FirstCustomControl : UserControl
    {
        public DateTime f1;
        public DateTime f2;
        public DateTime pro1;
        public DateTime pro2;
        public DateTime datapro;
        public DateTime dateconv;

        public int xd;

        public FirstCustomControl()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            Mantenimiento man = new Mantenimiento();
            try
            {
                man.llenarDoc(docCmb);
                docCmb.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {

            }
        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
            
        }

        private void docCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CrearPedido x = new CrearPedido();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Selector x =  new Selector(this);
        }

        private void selecText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
