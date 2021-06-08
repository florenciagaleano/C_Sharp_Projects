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
    public partial class FormMenu : Form
    {
        Fabrica fabrica;
        public FormMenu()
        {
            InitializeComponent();
        }

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
            this.btnConsultarJornadas.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnConsultarJornadas_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnConsultarJornadas.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void btnVerPendientes_MouseLeave(object sender, EventArgs e)
        {
            this.btnVerPendientes.BackColor = Color.FromArgb(219, 112, 147);
        }

        private void btnVerPendientes_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnVerPendientes.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Desea hacer un pedido por mayor?","PEDIDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                new FormPedidoPorMayor(fabrica).ShowDialog();
            }else
            {
                new FormPedidoPorMenor().ShowDialog();
            }
        }
    }
}
