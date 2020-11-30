namespace Formularios
{
    partial class frmPartesComputador
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mouse = new System.Windows.Forms.CheckBox();
            this.impresora = new System.Windows.Forms.CheckBox();
            this.camara = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonI7 = new System.Windows.Forms.RadioButton();
            this.radioButtonI5 = new System.Windows.Forms.RadioButton();
            this.radioButtonI3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton500GB = new System.Windows.Forms.RadioButton();
            this.radioButton300GB = new System.Windows.Forms.RadioButton();
            this.radioButton80GB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton12GB = new System.Windows.Forms.RadioButton();
            this.radioButton8GB = new System.Windows.Forms.RadioButton();
            this.radioButton4GB = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(17, 342);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(17, 253);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResultado.Size = new System.Drawing.Size(766, 82);
            this.txtResultado.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mouse);
            this.groupBox4.Controls.Add(this.impresora);
            this.groupBox4.Controls.Add(this.camara);
            this.groupBox4.Location = new System.Drawing.Point(593, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 129);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accedorios";
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Location = new System.Drawing.Point(6, 69);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(92, 17);
            this.mouse.TabIndex = 2;
            this.mouse.Text = "Mouse Gamer";
            this.mouse.UseVisualStyleBackColor = true;
            // 
            // impresora
            // 
            this.impresora.AutoSize = true;
            this.impresora.Location = new System.Drawing.Point(7, 45);
            this.impresora.Name = "impresora";
            this.impresora.Size = new System.Drawing.Size(72, 17);
            this.impresora.TabIndex = 1;
            this.impresora.Text = "Impresora";
            this.impresora.UseVisualStyleBackColor = true;
            // 
            // camara
            // 
            this.camara.AutoSize = true;
            this.camara.Location = new System.Drawing.Point(7, 20);
            this.camara.Name = "camara";
            this.camara.Size = new System.Drawing.Size(62, 17);
            this.camara.TabIndex = 0;
            this.camara.Text = "Camara";
            this.camara.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonI7);
            this.groupBox3.Controls.Add(this.radioButtonI5);
            this.groupBox3.Controls.Add(this.radioButtonI3);
            this.groupBox3.Location = new System.Drawing.Point(420, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 129);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesador";
            // 
            // radioButtonI7
            // 
            this.radioButtonI7.AutoSize = true;
            this.radioButtonI7.Location = new System.Drawing.Point(7, 68);
            this.radioButtonI7.Name = "radioButtonI7";
            this.radioButtonI7.Size = new System.Drawing.Size(100, 17);
            this.radioButtonI7.TabIndex = 2;
            this.radioButtonI7.TabStop = true;
            this.radioButtonI7.Text = "Intel PentiumI(/)";
            this.radioButtonI7.UseVisualStyleBackColor = true;
            // 
            // radioButtonI5
            // 
            this.radioButtonI5.AutoSize = true;
            this.radioButtonI5.Location = new System.Drawing.Point(7, 44);
            this.radioButtonI5.Name = "radioButtonI5";
            this.radioButtonI5.Size = new System.Drawing.Size(104, 17);
            this.radioButtonI5.TabIndex = 1;
            this.radioButtonI5.TabStop = true;
            this.radioButtonI5.Text = "Intel Pentium I(5)";
            this.radioButtonI5.UseVisualStyleBackColor = true;
            // 
            // radioButtonI3
            // 
            this.radioButtonI3.AutoSize = true;
            this.radioButtonI3.Location = new System.Drawing.Point(7, 20);
            this.radioButtonI3.Name = "radioButtonI3";
            this.radioButtonI3.Size = new System.Drawing.Size(104, 17);
            this.radioButtonI3.TabIndex = 0;
            this.radioButtonI3.TabStop = true;
            this.radioButtonI3.Text = "Intel Pentium I(3)";
            this.radioButtonI3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton500GB);
            this.groupBox2.Controls.Add(this.radioButton300GB);
            this.groupBox2.Controls.Add(this.radioButton80GB);
            this.groupBox2.Location = new System.Drawing.Point(230, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disco Duro";
            // 
            // radioButton500GB
            // 
            this.radioButton500GB.AutoSize = true;
            this.radioButton500GB.Location = new System.Drawing.Point(7, 68);
            this.radioButton500GB.Name = "radioButton500GB";
            this.radioButton500GB.Size = new System.Drawing.Size(123, 17);
            this.radioButton500GB.TabIndex = 2;
            this.radioButton500GB.TabStop = true;
            this.radioButton500GB.Text = "500 GB Disco Solido";
            this.radioButton500GB.UseVisualStyleBackColor = true;
            // 
            // radioButton300GB
            // 
            this.radioButton300GB.AutoSize = true;
            this.radioButton300GB.Location = new System.Drawing.Point(7, 44);
            this.radioButton300GB.Name = "radioButton300GB";
            this.radioButton300GB.Size = new System.Drawing.Size(123, 17);
            this.radioButton300GB.TabIndex = 1;
            this.radioButton300GB.TabStop = true;
            this.radioButton300GB.Text = "300 GB Disco Solido";
            this.radioButton300GB.UseVisualStyleBackColor = true;
            // 
            // radioButton80GB
            // 
            this.radioButton80GB.AutoSize = true;
            this.radioButton80GB.Location = new System.Drawing.Point(7, 20);
            this.radioButton80GB.Name = "radioButton80GB";
            this.radioButton80GB.Size = new System.Drawing.Size(117, 17);
            this.radioButton80GB.TabIndex = 0;
            this.radioButton80GB.TabStop = true;
            this.radioButton80GB.Text = "80 GB Disco Solido";
            this.radioButton80GB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton12GB);
            this.groupBox1.Controls.Add(this.radioButton8GB);
            this.groupBox1.Controls.Add(this.radioButton4GB);
            this.groupBox1.Location = new System.Drawing.Point(17, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memoria RAM";
            // 
            // radioButton12GB
            // 
            this.radioButton12GB.AutoSize = true;
            this.radioButton12GB.Location = new System.Drawing.Point(6, 67);
            this.radioButton12GB.Name = "radioButton12GB";
            this.radioButton12GB.Size = new System.Drawing.Size(55, 17);
            this.radioButton12GB.TabIndex = 2;
            this.radioButton12GB.TabStop = true;
            this.radioButton12GB.Text = "12 GB";
            this.radioButton12GB.UseVisualStyleBackColor = true;
            // 
            // radioButton8GB
            // 
            this.radioButton8GB.AutoSize = true;
            this.radioButton8GB.Location = new System.Drawing.Point(7, 44);
            this.radioButton8GB.Name = "radioButton8GB";
            this.radioButton8GB.Size = new System.Drawing.Size(49, 17);
            this.radioButton8GB.TabIndex = 1;
            this.radioButton8GB.TabStop = true;
            this.radioButton8GB.Text = "8 GB";
            this.radioButton8GB.UseVisualStyleBackColor = true;
            // 
            // radioButton4GB
            // 
            this.radioButton4GB.AutoSize = true;
            this.radioButton4GB.Location = new System.Drawing.Point(7, 20);
            this.radioButton4GB.Name = "radioButton4GB";
            this.radioButton4GB.Size = new System.Drawing.Size(49, 17);
            this.radioButton4GB.TabIndex = 0;
            this.radioButton4GB.TabStop = true;
            this.radioButton4GB.Text = "4 GB";
            this.radioButton4GB.UseVisualStyleBackColor = true;
            // 
            // frmPartesComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPartesComputador";
            this.Text = "frmPartesComputador";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox mouse;
        private System.Windows.Forms.CheckBox impresora;
        private System.Windows.Forms.CheckBox camara;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonI7;
        private System.Windows.Forms.RadioButton radioButtonI5;
        private System.Windows.Forms.RadioButton radioButtonI3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton500GB;
        private System.Windows.Forms.RadioButton radioButton300GB;
        private System.Windows.Forms.RadioButton radioButton80GB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton12GB;
        private System.Windows.Forms.RadioButton radioButton8GB;
        private System.Windows.Forms.RadioButton radioButton4GB;
    }
}