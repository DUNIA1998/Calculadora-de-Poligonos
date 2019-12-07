namespace Calculadora_de_Poligonos
{
    partial class CalculadoraForm
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PrincipaltabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btncalcularPerimetro = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.PrincipaltabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TituloLabel.Location = new System.Drawing.Point(326, 30);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(129, 13);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Calculadora de Polígonos";
            this.TituloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrincipaltabControl1
            // 
            this.PrincipaltabControl1.Controls.Add(this.tabPage1);
            this.PrincipaltabControl1.Controls.Add(this.tabPage2);
            this.PrincipaltabControl1.Controls.Add(this.tabPage3);
            this.PrincipaltabControl1.Controls.Add(this.tabPage4);
            this.PrincipaltabControl1.Controls.Add(this.tabPage5);
            this.PrincipaltabControl1.Location = new System.Drawing.Point(65, 101);
            this.PrincipaltabControl1.Name = "PrincipaltabControl1";
            this.PrincipaltabControl1.SelectedIndex = 0;
            this.PrincipaltabControl1.Size = new System.Drawing.Size(622, 274);
            this.PrincipaltabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triangulo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(614, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Círculo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(614, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rectángulo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(614, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pentágono";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btncalcularPerimetro
            // 
            this.btncalcularPerimetro.Location = new System.Drawing.Point(150, 406);
            this.btncalcularPerimetro.Name = "btncalcularPerimetro";
            this.btncalcularPerimetro.Size = new System.Drawing.Size(142, 23);
            this.btncalcularPerimetro.TabIndex = 2;
            this.btncalcularPerimetro.Text = "Calcular Perímetro";
            this.btncalcularPerimetro.UseVisualStyleBackColor = true;
            this.btncalcularPerimetro.Click += new System.EventHandler(this.btncalcularPerimetro_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(474, 406);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(149, 23);
            this.btnCalcularArea.TabIndex = 3;
            this.btnCalcularArea.Text = "Calcular Área";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btncalcularPerimetro);
            this.Controls.Add(this.PrincipaltabControl1);
            this.Controls.Add(this.TituloLabel);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora de Polígonos";
            this.Load += new System.EventHandler(this.btnPerimetro_Load);
            this.PrincipaltabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TabControl PrincipaltabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btncalcularPerimetro;
        private System.Windows.Forms.Button btnCalcularArea;
    }
}

