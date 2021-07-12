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
using Excepciones;
using Productos;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Threading;

namespace Forms
{
    public partial class FrmFabricar : Form
    {
        private Fabrica fabrica;
        private bool flag;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmFabricar(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            flag = false;
        }

        /// <summary>
        /// Al apretar este botón se inicia el proceso de fabricación
        /// También se recorre la lista de productos de la fábrica y se suscribe al método que actualiza los estados
        /// al evento InformarEstado para que se pueda ir visualizando el proceso de fabricación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricaar_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                foreach (Producto producto in this.fabrica.Productos)
                {
                    if(producto.EstadoActual != Producto.Estado.Entregado)
                    {
                        this.listViewProductos.Items.Add(producto.Informe()).BackColor = Color.Red;
                        producto.InformarEstado += this.producto_CambiarEstados;
                        Fabrica.Fabricar(producto, this.fabrica);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya no hay tiempo para seguir fabricando productos por hoy");
            }
        }

        /// <summary>
        /// Cambia el color y texto de los items de la ViewList de acuerdo al estado del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void producto_CambiarEstados(object sender, EventArgs e)
        {

            if (this.InvokeRequired)
            {
                Producto.DelegadoEstado d = new Producto.DelegadoEstado(producto_CambiarEstados);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                for(int i=0; i<fabrica.Productos.Count;i++)
                {
                    switch (this.fabrica.Productos[i].EstadoActual)
                    {
                        case Producto.Estado.Nuevo:
                            this.listViewProductos.Items[i].BackColor = Color.Red;
                            this.listViewProductos.Items[i].Text = this.fabrica.Productos[i].Informe();
                            break;
                        case Producto.Estado.Fabricado:
                            this.listViewProductos.Items[i].BackColor = Color.Orange;
                            this.listViewProductos.Items[i].Text = this.fabrica.Productos[i].Informe();
                            break;
                        case Producto.Estado.Envasado:
                            this.listViewProductos.Items[i].BackColor = Color.Yellow;
                            this.listViewProductos.Items[i].Text = this.fabrica.Productos[i].Informe();
                            break;
                        case Producto.Estado.Entregado:
                            this.listViewProductos.Items[i].BackColor = Color.LightGreen;
                            this.listViewProductos.Items[i].Text = this.fabrica.Productos[i].Informe();
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        /// <summary>
        /// Se cambia el color del botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricaar_MouseMove(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.FromArgb(182, 149, 192);
        }

        /// <summary>
        /// Se vuelve a cambiar el color del botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricaar_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(255,255,255);
        }

        private void FrmFabricar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fabrica.CerrarFabrica(this.fabrica);
        }
    }
}
