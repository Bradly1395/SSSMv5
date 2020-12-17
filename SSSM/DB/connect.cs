using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSM
{
    class connect
    {

        public string cadenaconexion; //= ("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=hrsf;Integrated Security=True;Trusted_Connection=True;");
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;
        public string x;

        public connect()
        {
            if (SSSM.Properties.Settings.Default.Check)
            {
                cadenaconexion = ("Data Source=" + SSSM.Properties.Settings.Default.DataSource + ";Initial Catalog=" + SSSM.Properties.Settings.Default.Catalog + ";User ID=" + SSSM.Properties.Settings.Default.UserBase + "; Password =" + SSSM.Properties.Settings.Default.PassBase);
            }
            else
            {
                cadenaconexion = ("Data Source=" + SSSM.Properties.Settings.Default.DataSource + ";Initial Catalog=" + SSSM.Properties.Settings.Default.Catalog + ";Integrated Security=True;Trusted_Connection=True;");
            }
            
            this.cnn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }

        public void SetConection(string DataSource, string Catalog, string userbase, string password, bool check)
        {
            if (check)
            {
                SSSM.Properties.Settings.Default.DataSource = DataSource;
                SSSM.Properties.Settings.Default.Catalog = Catalog;
                SSSM.Properties.Settings.Default.PassBase = password;
                SSSM.Properties.Settings.Default.UserBase = userbase;
                SSSM.Properties.Settings.Default.Check = check;
                SSSM.Properties.Settings.Default.Save();

                cadenaconexion = ("Data Source=" + SSSM.Properties.Settings.Default.DataSource + ";Initial Catalog=" + SSSM.Properties.Settings.Default.Catalog + ";User ID=" + SSSM.Properties.Settings.Default.UserBase + "; Password =" + SSSM.Properties.Settings.Default.PassBase);
            }
            else
            {
                SSSM.Properties.Settings.Default.DataSource = DataSource;
                SSSM.Properties.Settings.Default.Catalog = Catalog;
                SSSM.Properties.Settings.Default.Check = check;
                SSSM.Properties.Settings.Default.Save();

                cadenaconexion = ("Data Source=" + SSSM.Properties.Settings.Default.DataSource + ";Initial Catalog=" + SSSM.Properties.Settings.Default.Catalog + ";Integrated Security=True;Trusted_Connection=True;");
            }
            
        }
    }
}
