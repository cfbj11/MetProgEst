namespace Ejercicio1
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbNombre2 = new System.Windows.Forms.ComboBox();
            this.btnNombre2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(108, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbNombre.Location = new System.Drawing.Point(201, 58);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(296, 22);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // cmbNombres
            // 
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(201, 153);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(296, 24);
            this.cmbNombres.TabIndex = 3;
            this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.cmbNombres_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Ejercicio1.Properties.Resources.agregar_usuario;
            this.btnAgregar.Location = new System.Drawing.Point(544, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 295);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNombre2
            // 
            this.cmbNombre2.FormattingEnabled = true;
            this.cmbNombre2.Location = new System.Drawing.Point(201, 259);
            this.cmbNombre2.Name = "cmbNombre2";
            this.cmbNombre2.Size = new System.Drawing.Size(296, 24);
            this.cmbNombre2.TabIndex = 4;
            // 
            // btnNombre2
            // 
            this.btnNombre2.Location = new System.Drawing.Point(201, 213);
            this.btnNombre2.Name = "btnNombre2";
            this.btnNombre2.Size = new System.Drawing.Size(296, 23);
            this.btnNombre2.TabIndex = 5;
            this.btnNombre2.Text = "Mover todos los elementos";
            this.btnNombre2.UseVisualStyleBackColor = true;
            this.btnNombre2.Click += new System.EventHandler(this.btnNombre2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNombre2);
            this.Controls.Add(this.cmbNombre2);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.ComboBox cmbNombre2;
        private System.Windows.Forms.Button btnNombre2;
    }
}

