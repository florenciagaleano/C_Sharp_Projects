
namespace Forms
{
    partial class FrmPedidoPorMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoPorMayor));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRimel = new System.Windows.Forms.Label();
            this.lblLabial = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbColorRimel = new System.Windows.Forms.ComboBox();
            this.cmbColorLabial = new System.Windows.Forms.ComboBox();
            this.nudBase = new System.Windows.Forms.NumericUpDown();
            this.cmbEfecto = new System.Windows.Forms.ComboBox();
            this.cmbLabial = new System.Windows.Forms.ComboBox();
            this.nudCantR = new System.Windows.Forms.NumericUpDown();
            this.nudCantL = new System.Windows.Forms.NumericUpDown();
            this.nudCantB = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // lblRimel
            // 
            this.lblRimel.AutoSize = true;
            this.lblRimel.BackColor = System.Drawing.Color.Transparent;
            this.lblRimel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRimel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblRimel.Location = new System.Drawing.Point(123, 93);
            this.lblRimel.Name = "lblRimel";
            this.lblRimel.Size = new System.Drawing.Size(59, 23);
            this.lblRimel.TabIndex = 1;
            this.lblRimel.Text = "Rimel";
            // 
            // lblLabial
            // 
            this.lblLabial.AutoSize = true;
            this.lblLabial.BackColor = System.Drawing.Color.Transparent;
            this.lblLabial.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabial.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblLabial.Location = new System.Drawing.Point(123, 154);
            this.lblLabial.Name = "lblLabial";
            this.lblLabial.Size = new System.Drawing.Size(62, 23);
            this.lblLabial.TabIndex = 2;
            this.lblLabial.Text = "Labial";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.BackColor = System.Drawing.Color.Transparent;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblBase.Location = new System.Drawing.Point(123, 214);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(50, 23);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Base";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(12, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(598, 40);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbColorRimel
            // 
            this.cmbColorRimel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorRimel.Location = new System.Drawing.Point(232, 93);
            this.cmbColorRimel.Name = "cmbColorRimel";
            this.cmbColorRimel.Size = new System.Drawing.Size(121, 21);
            this.cmbColorRimel.TabIndex = 5;
            // 
            // cmbColorLabial
            // 
            this.cmbColorLabial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorLabial.FormattingEnabled = true;
            this.cmbColorLabial.Location = new System.Drawing.Point(232, 154);
            this.cmbColorLabial.Name = "cmbColorLabial";
            this.cmbColorLabial.Size = new System.Drawing.Size(121, 21);
            this.cmbColorLabial.TabIndex = 6;
            // 
            // nudBase
            // 
            this.nudBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBase.Location = new System.Drawing.Point(232, 211);
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
            this.nudBase.Size = new System.Drawing.Size(54, 26);
            this.nudBase.TabIndex = 7;
            this.nudBase.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cmbEfecto
            // 
            this.cmbEfecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEfecto.Location = new System.Drawing.Point(371, 93);
            this.cmbEfecto.Name = "cmbEfecto";
            this.cmbEfecto.Size = new System.Drawing.Size(121, 21);
            this.cmbEfecto.TabIndex = 8;
            // 
            // cmbLabial
            // 
            this.cmbLabial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabial.FormattingEnabled = true;
            this.cmbLabial.Location = new System.Drawing.Point(371, 154);
            this.cmbLabial.Name = "cmbLabial";
            this.cmbLabial.Size = new System.Drawing.Size(121, 21);
            this.cmbLabial.TabIndex = 9;
            // 
            // nudCantR
            // 
            this.nudCantR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantR.Location = new System.Drawing.Point(12, 92);
            this.nudCantR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantR.Name = "nudCantR";
            this.nudCantR.Size = new System.Drawing.Size(84, 26);
            this.nudCantR.TabIndex = 10;
            // 
            // nudCantL
            // 
            this.nudCantL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantL.Location = new System.Drawing.Point(12, 153);
            this.nudCantL.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantL.Name = "nudCantL";
            this.nudCantL.Size = new System.Drawing.Size(84, 26);
            this.nudCantL.TabIndex = 11;
            // 
            // nudCantB
            // 
            this.nudCantB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantB.Location = new System.Drawing.Point(12, 213);
            this.nudCantB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantB.Name = "nudCantB";
            this.nudCantB.Size = new System.Drawing.Size(84, 26);
            this.nudCantB.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCantidad.Location = new System.Drawing.Point(8, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 19);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // FormPedidoPorMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 317);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantB);
            this.Controls.Add(this.nudCantL);
            this.Controls.Add(this.nudCantR);
            this.Controls.Add(this.cmbLabial);
            this.Controls.Add(this.cmbEfecto);
            this.Controls.Add(this.nudBase);
            this.Controls.Add(this.cmbColorLabial);
            this.Controls.Add(this.cmbColorRimel);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblLabial);
            this.Controls.Add(this.lblRimel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPedidoPorMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedidoPorMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRimel;
        private System.Windows.Forms.Label lblLabial;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbColorRimel;
        private System.Windows.Forms.ComboBox cmbColorLabial;
        private System.Windows.Forms.NumericUpDown nudBase;
        private System.Windows.Forms.ComboBox cmbEfecto;
        private System.Windows.Forms.ComboBox cmbLabial;
        private System.Windows.Forms.NumericUpDown nudCantR;
        private System.Windows.Forms.NumericUpDown nudCantL;
        private System.Windows.Forms.NumericUpDown nudCantB;
        private System.Windows.Forms.Label lblCantidad;
    }
}