namespace Formularios
{
    partial class frmPrincipal
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
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(85, 29);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(100, 23);
            this.btnSueldo.TabIndex = 0;
            this.btnSueldo.Text = "Sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(85, 76);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(100, 23);
            this.btnBinario.TabIndex = 1;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(85, 118);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(100, 23);
            this.btnNombre.TabIndex = 2;
            this.btnNombre.Text = "Nombre y edad";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(85, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(85, 161);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(100, 23);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnSueldo);
            this.Name = "frmPrincipal";
            this.Text = "Nombre y edad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalendario;
    }
}