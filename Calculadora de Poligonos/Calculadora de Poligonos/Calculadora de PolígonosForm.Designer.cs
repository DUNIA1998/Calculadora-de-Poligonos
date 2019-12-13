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
            this.PrincipalTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btncalcularPerimetro = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.Alturalabel = new System.Windows.Forms.Label();
            this.Baselabel = new System.Windows.Forms.Label();
            this.Ladolabel = new System.Windows.Forms.Label();
            this.Lado1label = new System.Windows.Forms.Label();
            this.Lado2label = new System.Windows.Forms.Label();
            this.AlturaTextBox = new System.Windows.Forms.TextBox();
            this.BaseTextBox2 = new System.Windows.Forms.TextBox();
            this.LadoTextBox3 = new System.Windows.Forms.TextBox();
            this.Lado1TextBox4 = new System.Windows.Forms.TextBox();
            this.Lado2TextBox5 = new System.Windows.Forms.TextBox();
            this.LadoCLabel = new System.Windows.Forms.Label();
            this.LadoCTextBox = new System.Windows.Forms.TextBox();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.Radiolabel = new System.Windows.Forms.Label();
            this.LargoTextBox = new System.Windows.Forms.TextBox();
            this.Largolabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ancholabel = new System.Windows.Forms.Label();
            this.ApotemaTextBox = new System.Windows.Forms.TextBox();
            this.Apotemalabel = new System.Windows.Forms.Label();
            this.LadoPTextBox = new System.Windows.Forms.TextBox();
            this.LadoPlabel = new System.Windows.Forms.Label();
            this.lblFigura = new System.Windows.Forms.Label();
            this.PrincipalTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            // PrincipalTabControl
            // 
            this.PrincipalTabControl.Controls.Add(this.tabPage1);
            this.PrincipalTabControl.Controls.Add(this.tabPage2);
            this.PrincipalTabControl.Controls.Add(this.tabPage3);
            this.PrincipalTabControl.Controls.Add(this.tabPage4);
            this.PrincipalTabControl.Controls.Add(this.tabPage5);
            this.PrincipalTabControl.Location = new System.Drawing.Point(66, 101);
            this.PrincipalTabControl.Name = "PrincipalTabControl";
            this.PrincipalTabControl.SelectedIndex = 0;
            this.PrincipalTabControl.Size = new System.Drawing.Size(622, 274);
            this.PrincipalTabControl.TabIndex = 1;
            this.PrincipalTabControl.SelectedIndexChanged += new System.EventHandler(this.PrincipalTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lado2TextBox5);
            this.tabPage1.Controls.Add(this.Lado1TextBox4);
            this.tabPage1.Controls.Add(this.LadoTextBox3);
            this.tabPage1.Controls.Add(this.BaseTextBox2);
            this.tabPage1.Controls.Add(this.AlturaTextBox);
            this.tabPage1.Controls.Add(this.Lado2label);
            this.tabPage1.Controls.Add(this.Lado1label);
            this.tabPage1.Controls.Add(this.Ladolabel);
            this.tabPage1.Controls.Add(this.Baselabel);
            this.tabPage1.Controls.Add(this.Alturalabel);
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
            this.tabPage2.Controls.Add(this.LadoCTextBox);
            this.tabPage2.Controls.Add(this.LadoCLabel);
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
            this.tabPage3.Controls.Add(this.RadioTextBox);
            this.tabPage3.Controls.Add(this.Radiolabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(614, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Círculo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.Ancholabel);
            this.tabPage4.Controls.Add(this.LargoTextBox);
            this.tabPage4.Controls.Add(this.Largolabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(614, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rectángulo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.LadoPTextBox);
            this.tabPage5.Controls.Add(this.LadoPlabel);
            this.tabPage5.Controls.Add(this.ApotemaTextBox);
            this.tabPage5.Controls.Add(this.Apotemalabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(614, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pentágono";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
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
            // Alturalabel
            // 
            this.Alturalabel.AutoSize = true;
            this.Alturalabel.Location = new System.Drawing.Point(68, 31);
            this.Alturalabel.Name = "Alturalabel";
            this.Alturalabel.Size = new System.Drawing.Size(75, 13);
            this.Alturalabel.TabIndex = 0;
            this.Alturalabel.Text = "Ingresar Altura";
            // 
            // Baselabel
            // 
            this.Baselabel.AutoSize = true;
            this.Baselabel.Location = new System.Drawing.Point(68, 63);
            this.Baselabel.Name = "Baselabel";
            this.Baselabel.Size = new System.Drawing.Size(69, 13);
            this.Baselabel.TabIndex = 1;
            this.Baselabel.Text = "Ingrese Base";
            // 
            // Ladolabel
            // 
            this.Ladolabel.AutoSize = true;
            this.Ladolabel.Location = new System.Drawing.Point(68, 95);
            this.Ladolabel.Name = "Ladolabel";
            this.Ladolabel.Size = new System.Drawing.Size(82, 13);
            this.Ladolabel.TabIndex = 2;
            this.Ladolabel.Text = "Ingrese el lado1";
            // 
            // Lado1label
            // 
            this.Lado1label.AutoSize = true;
            this.Lado1label.Location = new System.Drawing.Point(68, 122);
            this.Lado1label.Name = "Lado1label";
            this.Lado1label.Size = new System.Drawing.Size(85, 13);
            this.Lado1label.TabIndex = 3;
            this.Lado1label.Text = "Ingrese el lado 2";
            // 
            // Lado2label
            // 
            this.Lado2label.AutoSize = true;
            this.Lado2label.Location = new System.Drawing.Point(68, 150);
            this.Lado2label.Name = "Lado2label";
            this.Lado2label.Size = new System.Drawing.Size(85, 13);
            this.Lado2label.TabIndex = 4;
            this.Lado2label.Text = "Ingrese el lado 3";
            // 
            // AlturaTextBox
            // 
            this.AlturaTextBox.Location = new System.Drawing.Point(168, 31);
            this.AlturaTextBox.Name = "AlturaTextBox";
            this.AlturaTextBox.Size = new System.Drawing.Size(146, 20);
            this.AlturaTextBox.TabIndex = 5;
            this.AlturaTextBox.TextChanged += new System.EventHandler(this.AlturaTextBox_TextChanged);
            this.AlturaTextBox.Leave += new System.EventHandler(this.AlturaTextBox_Leave);
            // 
            // BaseTextBox2
            // 
            this.BaseTextBox2.Location = new System.Drawing.Point(168, 63);
            this.BaseTextBox2.Name = "BaseTextBox2";
            this.BaseTextBox2.Size = new System.Drawing.Size(146, 20);
            this.BaseTextBox2.TabIndex = 6;
            // 
            // LadoTextBox3
            // 
            this.LadoTextBox3.Location = new System.Drawing.Point(168, 95);
            this.LadoTextBox3.Name = "LadoTextBox3";
            this.LadoTextBox3.Size = new System.Drawing.Size(146, 20);
            this.LadoTextBox3.TabIndex = 7;
            // 
            // Lado1TextBox4
            // 
            this.Lado1TextBox4.Location = new System.Drawing.Point(168, 122);
            this.Lado1TextBox4.Name = "Lado1TextBox4";
            this.Lado1TextBox4.Size = new System.Drawing.Size(146, 20);
            this.Lado1TextBox4.TabIndex = 8;
            // 
            // Lado2TextBox5
            // 
            this.Lado2TextBox5.Location = new System.Drawing.Point(168, 150);
            this.Lado2TextBox5.Name = "Lado2TextBox5";
            this.Lado2TextBox5.Size = new System.Drawing.Size(146, 20);
            this.Lado2TextBox5.TabIndex = 9;
            // 
            // LadoCLabel
            // 
            this.LadoCLabel.AutoSize = true;
            this.LadoCLabel.Location = new System.Drawing.Point(64, 33);
            this.LadoCLabel.Name = "LadoCLabel";
            this.LadoCLabel.Size = new System.Drawing.Size(76, 13);
            this.LadoCLabel.TabIndex = 0;
            this.LadoCLabel.Text = "Ingrese el lado";
            this.LadoCLabel.Click += new System.EventHandler(this.LadoCLabel_Click);
            // 
            // LadoCTextBox
            // 
            this.LadoCTextBox.Location = new System.Drawing.Point(172, 33);
            this.LadoCTextBox.Name = "LadoCTextBox";
            this.LadoCTextBox.Size = new System.Drawing.Size(144, 20);
            this.LadoCTextBox.TabIndex = 1;
            this.LadoCTextBox.TextChanged += new System.EventHandler(this.LadoCTextBox_TextChanged);
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(175, 35);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(144, 20);
            this.RadioTextBox.TabIndex = 3;
            // 
            // Radiolabel
            // 
            this.Radiolabel.AutoSize = true;
            this.Radiolabel.Location = new System.Drawing.Point(67, 35);
            this.Radiolabel.Name = "Radiolabel";
            this.Radiolabel.Size = new System.Drawing.Size(79, 13);
            this.Radiolabel.TabIndex = 2;
            this.Radiolabel.Text = "Ingrese el radio";
            // 
            // LargoTextBox
            // 
            this.LargoTextBox.Location = new System.Drawing.Point(183, 41);
            this.LargoTextBox.Name = "LargoTextBox";
            this.LargoTextBox.Size = new System.Drawing.Size(144, 20);
            this.LargoTextBox.TabIndex = 3;
            // 
            // Largolabel
            // 
            this.Largolabel.AutoSize = true;
            this.Largolabel.Location = new System.Drawing.Point(75, 41);
            this.Largolabel.Name = "Largolabel";
            this.Largolabel.Size = new System.Drawing.Size(79, 13);
            this.Largolabel.TabIndex = 2;
            this.Largolabel.Text = "Ingrese el largo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Ancholabel
            // 
            this.Ancholabel.AutoSize = true;
            this.Ancholabel.Location = new System.Drawing.Point(75, 94);
            this.Ancholabel.Name = "Ancholabel";
            this.Ancholabel.Size = new System.Drawing.Size(86, 13);
            this.Ancholabel.TabIndex = 4;
            this.Ancholabel.Text = "Ingrese el ancho";
            // 
            // ApotemaTextBox
            // 
            this.ApotemaTextBox.Location = new System.Drawing.Point(163, 78);
            this.ApotemaTextBox.Name = "ApotemaTextBox";
            this.ApotemaTextBox.Size = new System.Drawing.Size(144, 20);
            this.ApotemaTextBox.TabIndex = 3;
            // 
            // Apotemalabel
            // 
            this.Apotemalabel.AutoSize = true;
            this.Apotemalabel.Location = new System.Drawing.Point(55, 78);
            this.Apotemalabel.Name = "Apotemalabel";
            this.Apotemalabel.Size = new System.Drawing.Size(98, 13);
            this.Apotemalabel.TabIndex = 2;
            this.Apotemalabel.Text = "Ingrese la Apotema";
            // 
            // LadoPTextBox
            // 
            this.LadoPTextBox.Location = new System.Drawing.Point(163, 37);
            this.LadoPTextBox.Name = "LadoPTextBox";
            this.LadoPTextBox.Size = new System.Drawing.Size(144, 20);
            this.LadoPTextBox.TabIndex = 5;
            // 
            // LadoPlabel
            // 
            this.LadoPlabel.AutoSize = true;
            this.LadoPlabel.Location = new System.Drawing.Point(55, 37);
            this.LadoPlabel.Name = "LadoPlabel";
            this.LadoPlabel.Size = new System.Drawing.Size(76, 13);
            this.LadoPlabel.TabIndex = 4;
            this.LadoPlabel.Text = "Ingrese el lado";
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(67, 390);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(35, 13);
            this.lblFigura.TabIndex = 6;
            this.lblFigura.Text = "label1";
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btncalcularPerimetro);
            this.Controls.Add(this.PrincipalTabControl);
            this.Controls.Add(this.TituloLabel);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora de Polígonos";
            this.Load += new System.EventHandler(this.btnPerimetro_Load);
            this.PrincipalTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TabControl PrincipalTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btncalcularPerimetro;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.TextBox Lado2TextBox5;
        private System.Windows.Forms.TextBox Lado1TextBox4;
        private System.Windows.Forms.TextBox LadoTextBox3;
        private System.Windows.Forms.TextBox BaseTextBox2;
        private System.Windows.Forms.TextBox AlturaTextBox;
        private System.Windows.Forms.Label Lado2label;
        private System.Windows.Forms.Label Lado1label;
        private System.Windows.Forms.Label Ladolabel;
        private System.Windows.Forms.Label Baselabel;
        private System.Windows.Forms.Label Alturalabel;
        private System.Windows.Forms.TextBox LadoCTextBox;
        private System.Windows.Forms.Label LadoCLabel;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.Label Radiolabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Ancholabel;
        private System.Windows.Forms.TextBox LargoTextBox;
        private System.Windows.Forms.Label Largolabel;
        private System.Windows.Forms.TextBox LadoPTextBox;
        private System.Windows.Forms.Label LadoPlabel;
        private System.Windows.Forms.TextBox ApotemaTextBox;
        private System.Windows.Forms.Label Apotemalabel;
        private System.Windows.Forms.Label lblFigura;
    }
}

