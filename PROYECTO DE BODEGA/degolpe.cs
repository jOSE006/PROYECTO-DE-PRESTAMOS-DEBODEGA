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
    public partial class degolpe : Form
    {
        public degolpe()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Hide();
            new PREST().ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
      
            new carrito().ShowDialog();
        }
        int posY = 0;
        int posx = 0;
        private void degolpe_MouseMove(object sender, MouseEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new mazo().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new tapicero().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            new DEBOLA().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

            new deperfora().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            new DEUÑA().ShowDialog();
        }
    }
}
