using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_BODEGA
{
    public partial class deunion : Form
    {
        public deunion()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            new carrito().ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            Hide();
            new PREST().ShowDialog();
        }
        int posY = 0;
        int posx = 0;
        private void deunion_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            new Cautin().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new maquinasoldadoras().ShowDialog();
        }
    }
}
