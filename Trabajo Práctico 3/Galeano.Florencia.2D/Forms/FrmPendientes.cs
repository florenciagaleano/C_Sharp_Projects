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

namespace Forms
{
    public partial class FrmPendientes : Form
    {
        Fabrica fabrica;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="f">Fabrica</param>
        public FrmPendientes(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        /// <summary>
        /// Se carga la info del archivo pendientes al RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPendientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.rtbPendientes.Text = fabrica.LeerPendientesXml();
            }catch(ArchivoException)
            {
                //MessageBox.Show(ex.Message);
                this.Close();
                MessageBox.Show("Parece que no hay pendientes aún","PENDIENTES",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
