namespace Formularios
{
    partial class frmOtroTablaMultiplicarYFactorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalculaFactorial = new System.Windows.Forms.Button();
            this.txtResultadoFactorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrse la tabla";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(227, 52);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(100, 20);
            this.txtTabla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0Ingrese entero";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(227, 256);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(393, 52);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular tabla";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(116, 94);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(265, 109);
            this.txtResultado.TabIndex = 6;
            // 
            // btnCalculaFactorial
            // 
            this.btnCalculaFactorial.Location = new System.Drawing.Point(393, 251);
            this.btnCalculaFactorial.Name = "btnCalculaFactorial";
            this.btnCalculaFactorial.Size = new System.Drawing.Size(98, 23);
            this.btnCalculaFactorial.TabIndex = 7;
            this.btnCalculaFactorial.Text = "Calcula Factorial";
            this.btnCalculaFactorial.UseVisualStyleBackColor = true;
            this.btnCalculaFactorial.Click += new System.EventHandler(this.btnCalculaFactorial_Click);
            // 
            // txtResultadoFactorial
            // 
            this.txtResultadoFactorial.Location = new System.Drawing.Point(227, 282);
            this.txtResultadoFactorial.Name = "txtResultadoFactorial";
            this.txtResultadoFactorial.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoFactorial.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // frmOtroTablaMultiplicarYFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultadoFactorial);
            this.Controls.Add(this.btnCalculaFactorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.label1);
            this.Name = "frmOtroTablaMultiplicarYFactorial";
            this.Text = "OtroTablaMultiplicarYFactorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalculaFactorial;
        private System.Windows.Forms.TextBox txtResultadoFactorial;
        private System.Windows.Forms.Label label3;
    }
}