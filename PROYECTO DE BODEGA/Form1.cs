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
    public partial class Control_de_Heramientas_de_Bodega : Form
    {
        public Control_de_Heramientas_de_Bodega()
        {
            InitializeComponent();
        }
        int posY = 0;
        int posx = 0;
       

        private void Control_de_Heramientas_de_Bodega_MouseMove(object sender, MouseEventArgs e)
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
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= \Users\Jose Leal\Documents\Visual Studio 2015\Projects\PROYECTO DE BODEGA\Database1bodega1.mdb");
        private void Control_de_Heramientas_de_Bodega_Load_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado a la base de datos");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo conectar con la base de datos");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string usuario = NOMBRETEXT.Text;
            string password = bunifuMetroTextbox2.Text;

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM usuarios WHERE usuario ='" + NOMBRETEXT.Text + "'and contraseña ='" + bunifuMetroTextbox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int contador = dt.Rows.Count;

            if (contador > 0)
            {
                string tipo = dt.Rows[0]["tipo_usuario"].ToString();
                if (tipo == "1")
                {
                    MessageBox.Show("ingresaste como administrador");
                    this.Hide();
                   new  MENUADMINI().Show();
                    


                }
                else if (tipo == "2")
                {
                    MessageBox.Show("Ingresaste como un usuario comprador");
                    this.Hide();
                    new Inventario().Show();
                }

            }
            con.Close();
        }
    }

    }

