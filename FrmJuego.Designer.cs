namespace WinFormPersonas
{
    partial class FrmJuego
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstMuñecos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnComer = new System.Windows.Forms.Button();
            this.TxtJugarSegs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del  muñeco:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(281, 20);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstMuñecos
            // 
            this.lstMuñecos.FormattingEnabled = true;
            this.lstMuñecos.Location = new System.Drawing.Point(26, 49);
            this.lstMuñecos.Name = "lstMuñecos";
            this.lstMuñecos.Size = new System.Drawing.Size(249, 108);
            this.lstMuñecos.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(281, 49);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(281, 78);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "&Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnComer
            // 
            this.btnComer.Location = new System.Drawing.Point(281, 107);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(75, 23);
            this.btnComer.TabIndex = 7;
            this.btnComer.Text = "&Comer";
            this.btnComer.UseVisualStyleBackColor = true;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // TxtJugarSegs
            // 
            this.TxtJugarSegs.Location = new System.Drawing.Point(362, 78);
            this.TxtJugarSegs.Name = "TxtJugarSegs";
            this.TxtJugarSegs.Size = new System.Drawing.Size(37, 20);
            this.TxtJugarSegs.TabIndex = 8;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 170);
            this.ControlBox = false;
            this.Controls.Add(this.TxtJugarSegs);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstMuñecos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 209);
            this.Name = "FrmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstMuñecos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.TextBox TxtJugarSegs;
    }
}

