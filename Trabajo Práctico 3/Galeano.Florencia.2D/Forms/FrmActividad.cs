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
        public FrmActividad(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = InfoAMostrar();
        }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.fabrica.GuardarActividadTxt(this.richTextBox1.Text);
        }
    }
}
