
namespace Forms
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.btnVerActividad = new System.Windows.Forms.Button();
            this.btnProcesosFabrica = new System.Windows.Forms.Button();
            this.btnVerPendientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTitulo.Location = new System.Drawing.Point(168, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Make Up Factory";
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnHacerPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHacerPedido.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPedido.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnHacerPedido.Location = new System.Drawing.Point(99, 103);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Size = new System.Drawing.Size(426, 48);
            this.btnHacerPedido.TabIndex = 7;
            this.btnHacerPedido.Text = "Hacer Pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = false;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            this.btnHacerPedido.MouseLeave += new System.EventHandler(this.btnHacerPedido_MouseLeave);
            this.btnHacerPedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHacerPedido_MouseMove);
            // 
            // btnVerActividad
            // 
            this.btnVerActividad.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerActividad.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerActividad.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerActividad.Location = new System.Drawing.Point(99, 274);
            this.btnVerActividad.Name = "btnVerActividad";
            this.btnVerActividad.Size = new System.Drawing.Size(426, 48);
            this.btnVerActividad.TabIndex = 8;
            this.btnVerActividad.Text = "Actividad detallada";
            this.btnVerActividad.UseVisualStyleBackColor = false;
            this.btnVerActividad.Click += new System.EventHandler(this.btnVerActividad_Click);
            this.btnVerActividad.MouseLeave += new System.EventHandler(this.btnConsultarJornadas_MouseLeave);
            this.btnVerActividad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnConsultarJornadas_MouseMove);
            // 
            // btnProcesosFabrica
            // 
            this.btnProcesosFabrica.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnProcesosFabrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesosFabrica.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosFabrica.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnProcesosFabrica.Location = new System.Drawing.Point(99, 166);
            this.btnProcesosFabrica.Name = "btnProcesosFabrica";
            this.btnProcesosFabrica.Size = new System.Drawing.Size(426, 48);
            this.btnProcesosFabrica.TabIndex = 9;
            this.btnProcesosFabrica.Text = "Procesos de la fábrica";
            this.btnProcesosFabrica.UseVisualStyleBackColor = false;
            this.btnProcesosFabrica.Click += new System.EventHandler(this.btnProcesosFabrica_Click);
            this.btnProcesosFabrica.MouseLeave += new System.EventHandler(this.btnProcesosFabrica_MouseLeave);
            this.btnProcesosFabrica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProcesosFabrica_MouseMove);
            // 
            // btnVerPendientes
            // 
            this.btnVerPendientes.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPendientes.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPendientes.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerPendientes.Location = new System.Drawing.Point(99, 220);
            this.btnVerPendientes.Name = "btnVerPendientes";
            this.btnVerPendientes.Size = new System.Drawing.Size(426, 48);
            this.btnVerPendientes.TabIndex = 10;
            this.btnVerPendientes.Text = "Ver pendientes";
            this.btnVerPendientes.UseVisualStyleBackColor = false;
            this.btnVerPendientes.Click += new System.EventHandler(this.btnVerPendientes_Click);
            this.btnVerPendientes.MouseLeave += new System.EventHandler(this.btnVerPendientes_MouseLeave);
            this.btnVerPendientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVerPendientes_MouseMove);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 417);
            this.Controls.Add(this.btnVerPendientes);
            this.Controls.Add(this.btnProcesosFabrica);
            this.Controls.Add(this.btnVerActividad);
            this.Controls.Add(this.btnHacerPedido);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHacerPedido;
        private System.Windows.Forms.Button btnVerActividad;
        private System.Windows.Forms.Button btnProcesosFabrica;
        private System.Windows.Forms.Button btnVerPendientes;
    }
}

