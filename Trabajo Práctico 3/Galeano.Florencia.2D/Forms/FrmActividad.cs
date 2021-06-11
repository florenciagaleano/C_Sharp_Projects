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
        /// Cuando se clickea en Ver se muestra la info de los productos seleccionados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVer_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";//borro loq ue había cargado de antes
            this.richTextBox1.Text = InfoAMostrar();
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
            this.fabrica.GuardarActividadTxt(this.richTextBox1.Text);
        }
    }
}
