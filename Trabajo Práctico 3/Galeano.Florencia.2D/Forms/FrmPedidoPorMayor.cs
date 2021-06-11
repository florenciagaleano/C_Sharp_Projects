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
    public partial class FrmPedidoPorMayor : Form
    {
        Fabrica fabrica;

        /// <summary>
        /// Constructor de Form
        /// </summary>
        /// <param name="fabrica">Fábrica en cuya lista de productos se agregarán los productos</param>
        public FrmPedidoPorMayor(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        /// <summary>
        /// Cuando se carga el formulario se cargan los valores determinados en las ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedidoPorMayor_Load(object sender, EventArgs e)
        {
            //foreach (System.Reflection.PropertyInfo prop in typeof(ConsoleColor).GetProperties())
            //{
            //    if (prop.PropertyType.FullName == "System.Drawing.Color")
            //    {
            //        this.cmbColorLabial.Items.Add(prop.ToString());
            //        this.cmbColorRimel.Items.Add(prop.ToString());
            //    }
            //}
            this.cmbColorLabial.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbColorRimel.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.cmbEfecto.DataSource =  Enum.GetValues(typeof(Rimel.Efecto));
            this.cmbLabial.DataSource = Enum.GetValues(typeof(Labial.Tipo));
        }

        /// <summary>
        /// Cuando se clickea el botónAgregar los producto seleccionados se agregan a la lista de productos de fábrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Labial labial = new Labial((ConsoleColor)this.cmbColorLabial.SelectedItem, (Labial.Tipo)this.cmbLabial.SelectedItem);//tira excepcion de que es null arreglar!!!!!!
            Rimel rimel = new Rimel((Rimel.Efecto)this.cmbEfecto.SelectedItem,(ConsoleColor)this.cmbColorRimel.SelectedItem);
            Base unaBase = new Base((int)this.nudBase.Value);

            fabrica.HacerPedido(labial, (int)this.nudCantL.Value);
            fabrica.HacerPedido(rimel, (int)this.nudCantR.Value);
            fabrica.HacerPedido(unaBase, (int)this.nudCantB.Value);

            MessageBox.Show("Pedido realizado con exito!", "PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
