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
    public partial class carrito : Form
    {
        private conexiones f = new conexiones();
        public carrito()
        {
            InitializeComponent();
        }

        private void carrito_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= \Users\Jose Leal\Documents\Visual Studio 2015\Projects\PROYECTO DE BODEGA\Database1bodega1.mdb");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM herramientas";
            f.consultas(dataGridView1, bus2);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM carrito";
            f.consultas(dataGridView2, bus2);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string bus3;
            bus3 = "SELECT * FROM herramientas WHERE tipo_herramienta ='" + comboBox1.Text + "'";
            f.consultas(dataGridView1, bus3);
        }

        private void ag_Click(object sender, EventArgs e)
        {
            string sql;
            con.Open();
            sql = "INSERT INTO carrito(id_de_herramienta, nombre, tipo_herramienta) VALUES(@id_de_herramienta, @nombre, @tipo_herramienta)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@id_de_herramienta", id.Text);
            f.cmd.Parameters.AddWithValue("@nombre", nom.Text);
            f.cmd.Parameters.AddWithValue("@tipo_herramienta", comboBox2.Text);

            f.cmd.ExecuteNonQuery();
            con.Close();

            f.consultas(dataGridView2, "SELECT * FROM carrito WHERE id_de_herramienta='" + id.Text + "'");


            string del;
            del = "DELETE FROM herramientas WHERE id_de_herramienta='" + id.Text + "'";
            f.operaciones(dataGridView2, del);
            f.consultas(dataGridView2, "SELECT * FROM herramientas WHERE tipo_herramienta='" + comboBox2.Text + "'");
        }

        private void elimin_Click(object sender, EventArgs e)
        {
            string del;
            del = "DELETE FROM carrito WHERE id_de_herramienta='" + id.Text + "'";
            f.operaciones(dataGridView2, del);
            f.consultas(dataGridView2, "SELECT * FROM carrito WHERE tipo_herramienta='" + comboBox2.Text + "'");

            string sql;
            con.Open();
            sql = "INSERT INTO herramientas(id_de_herramienta, nombre, tipo_herramienta) VALUES(@id_de_herramienta, @nombre, @tipo_herramienta)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@id_de_herramienta", id.Text);
            f.cmd.Parameters.AddWithValue("@nombre", nom.Text);
            f.cmd.Parameters.AddWithValue("@tipo_herramienta", comboBox2.Text);


            f.cmd.ExecuteNonQuery();
            con.Close();

            f.consultas(dataGridView2, "SELECT * FROM herramientas WHERE id_de_herramienta='" + id.Text + "'");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Hide();
            new PREST().ShowDialog();
        }
    }
}
