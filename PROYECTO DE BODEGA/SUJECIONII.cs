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
    public partial class SUJECIONII : Form
    {
        public SUJECIONII()
        {
            InitializeComponent();
        }

        private void SUJECIONII_Load(object sender, EventArgs e)
        {

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

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            Hide();
            new SUJECION().ShowDialog();
        }
        int posY = 0;
        int posx = 0;
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

        private void SUJECIONII_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new electrica().ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new presi ().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new mecanic().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new taladra().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new cangrejo().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new punta().ShowDialog();
        }
    }
}
