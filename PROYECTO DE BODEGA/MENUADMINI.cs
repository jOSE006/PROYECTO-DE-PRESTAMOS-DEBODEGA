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
    public partial class MENUADMINI : Form
    {
        private conexiones f = new conexiones();
        public MENUADMINI()
        {
            InitializeComponent();
        }

   

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void MENUADMINI_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= \Users\Jose Leal\Documents\Visual Studio 2015\Projects\PROYECTO DE BODEGA\Database1bodega1.mdb");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           string del;
            del = "DELETE FROM herramientas WHERE id_de_herramienta='" + id.Text + "'";
            f.operaciones(dataGridView1, del);
            f.consultas(dataGridView1, "SELECT * FROM herramientas WHERE tipo_herramienta='" + comboBox1.Text + "'");
        }
        int posY = 0;
        int posx = 0;
        private void MENUADMINI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posY);
            }
        }

        private void ag_Click(object sender, EventArgs e)
        {
            string sql;
            con.Open();
            sql = "INSERT INTO herramientas(id_de_herramienta, nombre, tipo_herramienta) VALUES(@id_de_herramienta, @nombre, @tipo_herramienta)";
            f.cmd = new OleDbCommand(sql, con);

            f.cmd.Parameters.AddWithValue("@id_de_herramienta", id.Text);
            f.cmd.Parameters.AddWithValue("@nombre", nom.Text);
            f.cmd.Parameters.AddWithValue("@tipo_herramienta", comboBox1.Text);
         

            f.cmd.ExecuteNonQuery();
            con.Close();

            f.consultas(dataGridView1, "SELECT * FROM herramientas WHERE id_de_herramienta='" + id.Text + "'");
        }
       
        private void ins_Click(object sender, EventArgs e)
        {

        }
        private void busc_Click(object sender, EventArgs e)
        {
            string bus;
            bus = "SELECT * FROM herramientas WHERE id_de_herramienta='" + id.Text + "'";
            f.consultas(dataGridView1, bus);
        }

        private void ver_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM herramientas";
            f.consultas(dataGridView1, bus2);
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            string bus3;
            bus3 = "SELECT * FROM herramientas WHERE tipo_herramienta ='" + comboBox1.Text + "'";
            f.consultas(dataGridView1, bus3);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Control_de_Heramientas_de_Bodega().Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inventario().Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
       new Inventario ().Show();
        }
    }
}
