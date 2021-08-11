
namespace Forms
{
    partial class FrmPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPendientes));
            this.rtbPendientes = new System.Windows.Forms.RichTextBox();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbPendientes
            // 
            this.rtbPendientes.Location = new System.Drawing.Point(13, 13);
            this.rtbPendientes.Name = "rtbPendientes";
            this.rtbPendientes.ReadOnly = true;
            this.rtbPendientes.Size = new System.Drawing.Size(573, 189);
            this.rtbPendientes.TabIndex = 0;
            this.rtbPendientes.Text = "";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.BackColor = System.Drawing.Color.Transparent;
            this.lblPendientes.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPendientes.Location = new System.Drawing.Point(220, 205);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(162, 31);
            this.lblPendientes.TabIndex = 1;
            this.lblPendientes.Text = "Pendientes";
            // 
            // FrmPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 408);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.rtbPendientes);
            this.MaximizeBox = false;
            this.Name = "FrmPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendientes";
            this.Load += new System.EventHandler(this.FrmPendientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPendientes;
        private System.Windows.Forms.Label lblPendientes;
    }
}