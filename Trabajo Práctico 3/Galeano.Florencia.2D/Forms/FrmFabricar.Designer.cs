
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
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btnFabricaar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(12, 56);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.ReadOnly = true;
            this.rtbInforme.Size = new System.Drawing.Size(550, 268);
            this.rtbInforme.TabIndex = 0;
            this.rtbInforme.Text = "";
            // 
            // btnFabricaar
            // 
            this.btnFabricaar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricaar.Location = new System.Drawing.Point(13, 13);
            this.btnFabricaar.Name = "btnFabricaar";
            this.btnFabricaar.Size = new System.Drawing.Size(549, 26);
            this.btnFabricaar.TabIndex = 1;
            this.btnFabricaar.Text = "INICIAR PROCESO DE FABRIACIÓN";
            this.btnFabricaar.UseVisualStyleBackColor = true;
            this.btnFabricaar.Click += new System.EventHandler(this.btnFabricaar_Click);
            this.btnFabricaar.MouseLeave += new System.EventHandler(this.btnFabricaar_MouseLeave);
            this.btnFabricaar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFabricaar_MouseMove);
            // 
            // FrmFabricar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 336);
            this.Controls.Add(this.btnFabricaar);
            this.Controls.Add(this.rtbInforme);
            this.Name = "FrmFabricar";
            this.Text = "Fabricar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btnFabricaar;
    }
}