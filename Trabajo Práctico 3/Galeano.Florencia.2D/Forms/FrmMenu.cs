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
    public partial class FrmMenu : Form
    {
        Fabrica fabrica;
        public FrmMenu()
        {
            InitializeComponent();
            this.fabrica = new Fabrica(50);//la fabrica tiene 50 trabajadores
        }
        /*********************************************************************/
        /*Métodos creados para que al pararse en un botón el color cambie*/
        private void btnHacerPedido_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnHacerPedido.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void btnHacerPedido_MouseLeave(object sender, EventArgs e)
        {
            this.btnHacerPedido.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnProcesosFabrica_MouseLeave(object sender, EventArgs e)
        {
            this.btnProcesosFabrica.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnProcesosFabrica_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnProcesosFabrica.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void btnConsultarJornadas_MouseLeave(object sender, EventArgs e)
        {
            this.btnVerActividad.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnConsultarJornadas_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnVerActividad.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void btnVerPendientes_MouseLeave(object sender, EventArgs e)
        {
            this.btnVerPendientes.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnVerPendientes_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnVerPendientes.BackColor = Color.FromArgb(255, 192, 203);
        }
        /************************************************************************/

        /// <summary>
        /// Si se decide hacer pedido por mayor se abre Form de pedido por mayor y sino el de pedido por menor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Desea hacer un pedido por mayor?","PEDIDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                new FrmPedidoPorMayor(fabrica).ShowDialog();
            }else
            {
                new FrmPedidoPorMenor(this.fabrica).ShowDialog();
            }
        }

        /// <summary>
        /// Al cliclear en Procesos de fbábrica se abre FrmFabricar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcesosFabrica_Click(object sender, EventArgs e)
        {
            new FrmFabricar(this.fabrica).ShowDialog();
        }

        /// <summary>
        /// Al cliclear en Ver pendientes se abre FrmPendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            new FrmPendientes(this.fabrica).ShowDialog();
        }

        /// <summary>
        /// Al clickear en Actividad detallada se abre un nuevo Form que muestra la actividad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerActividad_Click(object sender, EventArgs e)
        {
            new FrmActividad(this.fabrica).ShowDialog();
        }
    }
}
