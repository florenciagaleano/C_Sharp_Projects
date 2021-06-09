
namespace Forms
{
    partial class FrmPedidoPorMenor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoPorMenor));
            this.label1 = new System.Windows.Forms.Label();
            this.optLabial = new System.Windows.Forms.RadioButton();
            this.optRimel = new System.Windows.Forms.RadioButton();
            this.optBase = new System.Windows.Forms.RadioButton();
            this.pnlProductoSeleccionado = new System.Windows.Forms.Panel();
            this.cmbLabial = new System.Windows.Forms.ComboBox();
            this.cmbEfecto = new System.Windows.Forms.ComboBox();
            this.nudBase = new System.Windows.Forms.NumericUpDown();
            this.cmbColorLabial = new System.Windows.Forms.ComboBox();
            this.cmbColorRimel = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlProductoSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido";
            // 
            // optLabial
            // 
            this.optLabial.AutoSize = true;
            this.optLabial.BackColor = System.Drawing.Color.Transparent;
            this.optLabial.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLabial.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.optLabial.Location = new System.Drawing.Point(4, 16);
            this.optLabial.Name = "optLabial";
            this.optLabial.Size = new System.Drawing.Size(74, 25);
            this.optLabial.TabIndex = 2;
            this.optLabial.Text = "Labial";
            this.optLabial.UseVisualStyleBackColor = false;
            this.optLabial.CheckedChanged += new System.EventHandler(this.optLabial_CheckedChanged);
            // 
            // optRimel
            // 
            this.optRimel.AutoSize = true;
            this.optRimel.BackColor = System.Drawing.Color.Transparent;
            this.optRimel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRimel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.optRimel.Location = new System.Drawing.Point(3, 59);
            this.optRimel.Name = "optRimel";
            this.optRimel.Size = new System.Drawing.Size(72, 25);
            this.optRimel.TabIndex = 3;
            this.optRimel.Text = "Rimel";
            this.optRimel.UseVisualStyleBackColor = false;
            this.optRimel.CheckedChanged += new System.EventHandler(this.optRimel_CheckedChanged);
            // 
            // optBase
            // 
            this.optBase.AutoSize = true;
            this.optBase.BackColor = System.Drawing.Color.Transparent;
            this.optBase.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBase.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.optBase.Location = new System.Drawing.Point(4, 102);
            this.optBase.Name = "optBase";
            this.optBase.Size = new System.Drawing.Size(63, 25);
            this.optBase.TabIndex = 4;
            this.optBase.Text = "Base";
            this.optBase.UseVisualStyleBackColor = false;
            this.optBase.CheckedChanged += new System.EventHandler(this.optBase_CheckedChanged);
            // 
            // pnlProductoSeleccionado
            // 
            this.pnlProductoSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.pnlProductoSeleccionado.Controls.Add(this.optLabial);
            this.pnlProductoSeleccionado.Controls.Add(this.optBase);
            this.pnlProductoSeleccionado.Controls.Add(this.optRimel);
            this.pnlProductoSeleccionado.Location = new System.Drawing.Point(12, 58);
            this.pnlProductoSeleccionado.Name = "pnlProductoSeleccionado";
            this.pnlProductoSeleccionado.Size = new System.Drawing.Size(84, 138);
            this.pnlProductoSeleccionado.TabIndex = 5;
            // 
            // cmbLabial
            // 
            this.cmbLabial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabial.FormattingEnabled = true;
            this.cmbLabial.Location = new System.Drawing.Point(274, 74);
            this.cmbLabial.Name = "cmbLabial";
            this.cmbLabial.Size = new System.Drawing.Size(144, 21);
            this.cmbLabial.TabIndex = 14;
            // 
            // cmbEfecto
            // 
            this.cmbEfecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEfecto.Location = new System.Drawing.Point(274, 120);
            this.cmbEfecto.Name = "cmbEfecto";
            this.cmbEfecto.Size = new System.Drawing.Size(144, 21);
            this.cmbEfecto.TabIndex = 13;
            // 
            // nudBase
            // 
            this.nudBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBase.Location = new System.Drawing.Point(115, 159);
            this.nudBase.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.nudBase.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudBase.Name = "nudBase";
            this.nudBase.Size = new System.Drawing.Size(62, 26);
            this.nudBase.TabIndex = 12;
            this.nudBase.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cmbColorLabial
            // 
            this.cmbColorLabial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorLabial.FormattingEnabled = true;
            this.cmbColorLabial.Location = new System.Drawing.Point(115, 74);
            this.cmbColorLabial.Name = "cmbColorLabial";
            this.cmbColorLabial.Size = new System.Drawing.Size(139, 21);
            this.cmbColorLabial.TabIndex = 11;
            // 
            // cmbColorRimel
            // 
            this.cmbColorRimel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorRimel.Location = new System.Drawing.Point(115, 121);
            this.cmbColorRimel.Name = "cmbColorRimel";
            this.cmbColorRimel.Size = new System.Drawing.Size(139, 21);
            this.cmbColorRimel.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(12, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(406, 40);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormPedidoPorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(577, 260);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbLabial);
            this.Controls.Add(this.cmbEfecto);
            this.Controls.Add(this.nudBase);
            this.Controls.Add(this.cmbColorLabial);
            this.Controls.Add(this.cmbColorRimel);
            this.Controls.Add(this.pnlProductoSeleccionado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPedidoPorMenor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedidoPorMenor_Load);
            this.pnlProductoSeleccionado.ResumeLayout(false);
            this.pnlProductoSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optLabial;
        private System.Windows.Forms.RadioButton optRimel;
        private System.Windows.Forms.RadioButton optBase;
        private System.Windows.Forms.Panel pnlProductoSeleccionado;
        private System.Windows.Forms.ComboBox cmbLabial;
        private System.Windows.Forms.ComboBox cmbEfecto;
        private System.Windows.Forms.NumericUpDown nudBase;
        private System.Windows.Forms.ComboBox cmbColorLabial;
        private System.Windows.Forms.ComboBox cmbColorRimel;
        private System.Windows.Forms.Button btnAgregar;
    }
}