﻿using System;
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
using System.Threading;

namespace Forms
{
    public partial class FrmFabricar : Form
    {
        private Fabrica fabrica;
        private bool flag;
        List<Thread> hiloProductos;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmFabricar(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            flag = false;
            this.hiloProductos = new List<Thread>();
        }

        /// <summary>
        /// Al apretar este botón se inicia el proceso de fabricación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricaar_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                foreach (Producto producto in this.fabrica.Productos)
                {
                    this.listViewProductos.Items.Add(producto.Informe()).BackColor = Color.Red;
                    producto.InformarEstado += this.producto_CambiarEstados;
                    Fabrica.Fabricar(producto, this.fabrica);
                }
            }
            else
            {
                MessageBox.Show("Ya no hay tiempo para seguir fabricando productos por hoy");
            }
        }

        public void producto_CambiarEstados(object sender, EventArgs e)
        {

            if (this.InvokeRequired)
            {
                Producto.DelegadoEstado d = new Producto.DelegadoEstado(producto_CambiarEstados);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                foreach (Producto item in this.fabrica.Productos)
                {
                    switch (item.EstadoActual)
                    {
                        case Producto.Estado.Nuevo:
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].BackColor = Color.Red;
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].Text = item.Informe();
                            break;
                        case Producto.Estado.Fabricado:
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].BackColor = Color.Orange;
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].Text = item.Informe();
                            break;
                        case Producto.Estado.Envasado:
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].BackColor = Color.Yellow;
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].Text = item.Informe();
                            break;
                        case Producto.Estado.Entregado:
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].BackColor = Color.LightGreen;
                            this.listViewProductos.Items[this.listViewProductos.Items.Count - 1].Text = item.Informe();
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

    }
}
