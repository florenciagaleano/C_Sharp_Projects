using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabricacion;

namespace Forms
{
    public partial class FrmFabricar : Form
    {
        private Fabrica fabrica;
        public FrmFabricar(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void btnFabricaar_Click(object sender, EventArgs e)
        {
            Fabrica.IniciarFabricacion(this.fabrica);
            this.rtbInforme.Text = this.fabrica.ToString();
            if(this.fabrica.Jornadas.Count > 1)
            {
                MessageBox.Show("Algunos productos no se llegaron a fabricar hoy, pero se agregaron a la planificación de mañana", "AVISO", MessageBoxButtons.OK);
            }
        }

        private void btnFabricaar_MouseMove(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.FromArgb(182, 149, 192);
        }

        private void btnFabricaar_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(255,255,255);
        }
    }
}
