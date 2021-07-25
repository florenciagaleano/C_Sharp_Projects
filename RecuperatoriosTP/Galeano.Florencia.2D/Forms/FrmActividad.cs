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
using Productos;
using Excepciones;

namespace Forms
{
    public partial class FrmActividad : Form
    {
        Fabrica fabrica;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="f">Fabrica cuya actividad se mostrará</param>
        public FrmActividad(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        /// <summary>
        /// Cuando se clickea en Ver se muestra la info de los productos seleccionados y un mensaje que infora la cantidad de entregados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVer_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";//borro lo que había cargado de antes
            this.richTextBox1.Text = InfoAMostrar();

            MessageBox.Show($"Hasta ahora hay fabricados y entregados {this.fabrica.CantidadDeProductosEntregados()} productos");
        }

        /// <summary>
        /// Genera una cadena que concatena la info a mostrar de acuerdo a los CheckBox
        /// </summary>
        /// <returns>La cadena generada</returns>
        private string InfoAMostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in fabrica.Productos)
            {
                if(this.checkBoxBase.Checked && item is Base)
                {
                    sb.Append(item.Informe());
                }else if(this.checkBoxLabial.Checked && item is Labial)
                {
                    sb.Append(item.Informe());
                }else if(this.checkBoxRimel.Checked && item is Rimel)
                {
                    sb.Append(item.Informe());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Se guarda la info mostrada por pantalla en formato de text (PROYECTO->FORMS->BIN->DEBUG)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica.GuardarActividadTxt(this.richTextBox1.Text);
            }catch(ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnVer.BackColor = Color.LightGoldenrodYellow;
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnGuardar.BackColor = Color.LightGoldenrodYellow;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.btnGuardar.BackColor = Color.White;
        }

        private void btnVer_MouseLeave(object sender, EventArgs e)
        {
            this.btnVer.BackColor = Color.White;
        }
    }
}
