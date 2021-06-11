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
        public FrmPendientes(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        private void FrmPendientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.rtbPendientes.Text = fabrica.LeerPendientesXml();
            }catch(ArchivoException ex)
            {
                //MessageBox.Show(ex.Message);
                this.Close();
                MessageBox.Show("Parece que no hay pendientes aún","PENDIENTES",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
