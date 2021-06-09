using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;
using Fabricacion;

namespace Forms
{
    public partial class FrmPedidoPorMenor : Form
    {
        Fabrica fabrica;
        public FrmPedidoPorMenor(Fabrica fabrica)
        {
            InitializeComponent();
            PonerVisibleDeControlesEnFalse();
            this.fabrica = fabrica;
        }

        private void PonerVisibleDeControlesEnFalse()
        {
            this.cmbEfecto.Visible = false;
            this.cmbColorLabial.Visible = false;
            this.cmbColorRimel.Visible = false;
            this.cmbLabial.Visible = false;
            this.nudBase.Visible = false;
        }

        private void optLabial_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optLabial.Checked)
            {
                this.cmbColorLabial.Visible = true;
                this.cmbLabial.Visible = true;
            }
        }

        private void optRimel_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optRimel.Checked)
            {
                this.cmbEfecto.Visible = true;
                this.cmbColorRimel.Visible = true;
            }
        }

        private void optBase_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optBase.Checked)
            {
                this.nudBase.Visible = true;
            }
        }

        private void FormPedidoPorMenor_Load(object sender, EventArgs e)
        {
            this.cmbColorLabial.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbColorRimel.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbEfecto.DataSource = Enum.GetValues(typeof(Rimel.Efecto));
            this.cmbLabial.DataSource = Enum.GetValues(typeof(Labial.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.optBase.Checked)
            {
                this.fabrica.Productos.Add(new Base((int)this.nudBase.Value));
                MessageBox.Show("Base agregada al pedido");
            }
            else if(this.optLabial.Checked)
            {
                this.fabrica.Productos.Add(new Labial((ConsoleColor)this.cmbColorLabial.SelectedValue,(Labial.Tipo)this.cmbLabial.SelectedValue));
                MessageBox.Show("Labial agregado al pedido");
            }
            else if(this.optRimel.Checked)
            {
                this.fabrica.Productos.Add(new Rimel((Rimel.Efecto)this.cmbEfecto.SelectedItem,(ConsoleColor)this.cmbColorRimel.SelectedItem));
                MessageBox.Show("Rimel agregado al pedido");
            }
            else
            {
                MessageBox.Show("Debe seleccionar algún producto!");
            }

        }
    }
}
