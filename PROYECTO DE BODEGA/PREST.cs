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
    public partial class PREST : Form
    {
        public PREST()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
          Hide();
            new Control_de_Heramientas_de_Bodega().ShowDialog();
        }
        int posY = 0;
        int posx = 0;
        private void PREST_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mecanicas().ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MONTAJE().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SUJECION().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new degolpe().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new detrazo().ShowDialog();
        }

        private void PREST_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new deunion().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new herracorte().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Hide();
            new manuales().ShowDialog();
        }
    }
}
