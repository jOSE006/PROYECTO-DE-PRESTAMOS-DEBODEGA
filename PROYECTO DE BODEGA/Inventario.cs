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
    public partial class Inventario : Form
    {
        private conexiones f = new conexiones();
        public Inventario()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Control_de_Heramientas_de_Bodega().Show();
        }
        int posY = 0;
        int posx = 0;
        private void Inventario_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string bus2;
            bus2 = "SELECT * FROM herramientas";
            f.consultas(dataGridView1, bus2);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Hide();
            new PREST().Show();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
