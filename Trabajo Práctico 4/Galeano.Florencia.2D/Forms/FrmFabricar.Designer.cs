
namespace Forms
{
    partial class FrmFabricar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabricar));
            this.btnFabricaar = new System.Windows.Forms.Button();
            this.listViewProductos = new System.Windows.Forms.ListView();
            this.columna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnFabricaar
            // 
            this.btnFabricaar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricaar.Location = new System.Drawing.Point(13, 13);
            this.btnFabricaar.Name = "btnFabricaar";
            this.btnFabricaar.Size = new System.Drawing.Size(549, 26);
            this.btnFabricaar.TabIndex = 1;
            this.btnFabricaar.Text = "INICIAR PROCESO DE FABRICACIÓN";
            this.btnFabricaar.UseVisualStyleBackColor = true;
            this.btnFabricaar.Click += new System.EventHandler(this.btnFabricaar_Click);
            this.btnFabricaar.MouseLeave += new System.EventHandler(this.btnFabricaar_MouseLeave);
            this.btnFabricaar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFabricaar_MouseMove);
            // 
            // listViewProductos
            // 
            this.listViewProductos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna});
            this.listViewProductos.HideSelection = false;
            this.listViewProductos.Location = new System.Drawing.Point(13, 46);
            this.listViewProductos.Name = "listViewProductos";
            this.listViewProductos.Size = new System.Drawing.Size(549, 278);
            this.listViewProductos.TabIndex = 2;
            this.listViewProductos.UseCompatibleStateImageBehavior = false;
            this.listViewProductos.View = System.Windows.Forms.View.Details;
            // 
            // columna
            // 
            this.columna.Text = "";
            this.columna.Width = 300;
            // 
            // FrmFabricar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 336);
            this.Controls.Add(this.listViewProductos);
            this.Controls.Add(this.btnFabricaar);
            this.MaximizeBox = false;
            this.Name = "FrmFabricar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFabricaar;
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.ColumnHeader columna;
    }
}