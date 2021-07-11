
namespace Forms
{
    partial class FrmActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividad));
            this.lblJornadas = new System.Windows.Forms.Label();
            this.checkBoxLabial = new System.Windows.Forms.CheckBox();
            this.checkBoxBase = new System.Windows.Forms.CheckBox();
            this.checkBoxRimel = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJornadas
            // 
            this.lblJornadas.AutoSize = true;
            this.lblJornadas.BackColor = System.Drawing.Color.Transparent;
            this.lblJornadas.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornadas.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblJornadas.Location = new System.Drawing.Point(90, 9);
            this.lblJornadas.Name = "lblJornadas";
            this.lblJornadas.Size = new System.Drawing.Size(442, 31);
            this.lblJornadas.TabIndex = 2;
            this.lblJornadas.Text = "Informe de actividad detallado";
            // 
            // checkBoxLabial
            // 
            this.checkBoxLabial.AutoSize = true;
            this.checkBoxLabial.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLabial.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLabial.ForeColor = System.Drawing.Color.Tomato;
            this.checkBoxLabial.Location = new System.Drawing.Point(27, 78);
            this.checkBoxLabial.Name = "checkBoxLabial";
            this.checkBoxLabial.Size = new System.Drawing.Size(100, 35);
            this.checkBoxLabial.TabIndex = 3;
            this.checkBoxLabial.Text = "Labial";
            this.checkBoxLabial.UseVisualStyleBackColor = false;
            // 
            // checkBoxBase
            // 
            this.checkBoxBase.AutoSize = true;
            this.checkBoxBase.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBase.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBase.ForeColor = System.Drawing.Color.Tomato;
            this.checkBoxBase.Location = new System.Drawing.Point(27, 142);
            this.checkBoxBase.Name = "checkBoxBase";
            this.checkBoxBase.Size = new System.Drawing.Size(85, 35);
            this.checkBoxBase.TabIndex = 4;
            this.checkBoxBase.Text = "Base";
            this.checkBoxBase.UseVisualStyleBackColor = false;
            // 
            // checkBoxRimel
            // 
            this.checkBoxRimel.AutoSize = true;
            this.checkBoxRimel.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRimel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRimel.ForeColor = System.Drawing.Color.Tomato;
            this.checkBoxRimel.Location = new System.Drawing.Point(27, 206);
            this.checkBoxRimel.Name = "checkBoxRimel";
            this.checkBoxRimel.Size = new System.Drawing.Size(98, 35);
            this.checkBoxRimel.TabIndex = 5;
            this.checkBoxRimel.Text = "Rimel";
            this.checkBoxRimel.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(166, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(447, 175);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(166, 248);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(447, 35);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver actividad";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            this.btnVer.MouseLeave += new System.EventHandler(this.btnVer_MouseLeave);
            this.btnVer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVer_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(166, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(447, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GuardarActividad";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // FrmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 418);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxRimel);
            this.Controls.Add(this.checkBoxBase);
            this.Controls.Add(this.checkBoxLabial);
            this.Controls.Add(this.lblJornadas);
            this.Name = "FrmActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jornadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJornadas;
        private System.Windows.Forms.CheckBox checkBoxLabial;
        private System.Windows.Forms.CheckBox checkBoxBase;
        private System.Windows.Forms.CheckBox checkBoxRimel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnGuardar;
    }
}