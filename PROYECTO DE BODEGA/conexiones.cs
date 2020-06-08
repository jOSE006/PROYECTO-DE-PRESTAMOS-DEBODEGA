using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PROYECTO_DE_BODEGA
{
    class conexiones
    {
        public OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= \Users\Jose Leal\Documents\Visual Studio 2015\Projects\PROYECTO DE BODEGA\Database1bodega1.mdb");
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo conectar");
            }
        }
        public void consultas(DataGridView tabla, string sql)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        public void operaciones(DataGridView tabla, string sql)
        {
            con.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }
    }
}
