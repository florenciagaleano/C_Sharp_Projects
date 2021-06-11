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

        /// <summary>
        /// Constructor de Form
        /// </summary>
        /// <param name="fabrica">Fábrica en cuya lista de productos se agregarán los productos</param>
        public FrmPedidoPorMenor(Fabrica fabrica)
        {
            InitializeComponent();
            PonerVisibleDeControlesEnFalse();
            this.fabrica = fabrica;
        }

        /// <summary>
        /// Método que se encarga de hacer invisibles todos los controles para que el usuario solo vea los delproducto que pide
        /// </summary>
        private void PonerVisibleDeControlesEnFalse()
        {
            this.cmbEfecto.Visible = false;
            this.cmbColorLabial.Visible = false;
            this.cmbColorRimel.Visible = false;
            this.cmbLabial.Visible = false;
            this.nudBase.Visible = false;
        }

        /// <summary>
        /// Solo activa la visibilidad de los controles relacionados con Labial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optLabial_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optLabial.Checked)
            {
                this.cmbColorLabial.Visible = true;
                this.cmbLabial.Visible = true;
            }
        }

        /// <summary>
        /// Solo activa la visibilidad de los controles relacionados con Rimel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optRimel_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optRimel.Checked)
            {
                this.cmbEfecto.Visible = true;
                this.cmbColorRimel.Visible = true;
            }
        }

        /// <summary>
        /// Solo activa la visibilidad de los controles relacionados con Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optBase_CheckedChanged(object sender, EventArgs e)
        {
            PonerVisibleDeControlesEnFalse();
            if (this.optBase.Checked)
            {
                this.nudBase.Visible = true;
            }
        }

        /// <summary>
        /// Cuando se carga el formulario se cargan los valores determinados en los ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedidoPorMenor_Load(object sender, EventArgs e)
        {
            this.cmbColorLabial.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbColorRimel.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbEfecto.DataSource = Enum.GetValues(typeof(Rimel.Efecto));
            this.cmbLabial.DataSource = Enum.GetValues(typeof(Labial.Tipo));
        }

        /// <summary>
        /// Cuando se clickea elboton Agregar los productos de agregan a la lista Productos de la fabrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
