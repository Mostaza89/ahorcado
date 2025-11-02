namespace ahorcado
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbpalabra = new System.Windows.Forms.Label();
            this.bniniciar = new System.Windows.Forms.Button();
            this.bnopciones = new System.Windows.Forms.Button();
            this.bnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Blackadder ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(210, 9);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(368, 123);
            this.lbtitulo.TabIndex = 1;
            this.lbtitulo.Text = "Ahorcado";
            // 
            // lbpalabra
            // 
            this.lbpalabra.AutoSize = true;
            this.lbpalabra.Font = new System.Drawing.Font("Blackadder ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpalabra.Location = new System.Drawing.Point(619, 44);
            this.lbpalabra.Name = "lbpalabra";
            this.lbpalabra.Size = new System.Drawing.Size(117, 48);
            this.lbpalabra.TabIndex = 2;
            this.lbpalabra.Text = "Palabra";
            this.lbpalabra.Click += new System.EventHandler(this.lbpalabra_Click);
            // 
            // bniniciar
            // 
            this.bniniciar.Font = new System.Drawing.Font("Blackadder ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bniniciar.Location = new System.Drawing.Point(319, 169);
            this.bniniciar.Name = "bniniciar";
            this.bniniciar.Size = new System.Drawing.Size(145, 52);
            this.bniniciar.TabIndex = 3;
            this.bniniciar.Text = "Iniciar";
            this.bniniciar.UseVisualStyleBackColor = true;
            this.bniniciar.Click += new System.EventHandler(this.bniniciar_Click);
            // 
            // bnopciones
            // 
            this.bnopciones.Font = new System.Drawing.Font("Blackadder ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnopciones.Location = new System.Drawing.Point(319, 248);
            this.bnopciones.Name = "bnopciones";
            this.bnopciones.Size = new System.Drawing.Size(145, 52);
            this.bnopciones.TabIndex = 4;
            this.bnopciones.Text = "Opciones";
            this.bnopciones.UseVisualStyleBackColor = true;
            this.bnopciones.Click += new System.EventHandler(this.bnopciones_Click);
            // 
            // bnsalir
            // 
            this.bnsalir.Font = new System.Drawing.Font("Blackadder ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnsalir.Location = new System.Drawing.Point(319, 333);
            this.bnsalir.Name = "bnsalir";
            this.bnsalir.Size = new System.Drawing.Size(145, 52);
            this.bnsalir.TabIndex = 6;
            this.bnsalir.Text = "Salir";
            this.bnsalir.UseVisualStyleBackColor = true;
            this.bnsalir.Click += new System.EventHandler(this.bnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ahorcado.Properties.Resources.cf93d1d7cfae0b2a30e5eb1739bfc64e;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnsalir);
            this.Controls.Add(this.bnopciones);
            this.Controls.Add(this.bniniciar);
            this.Controls.Add(this.lbpalabra);
            this.Controls.Add(this.lbtitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbpalabra;
        private System.Windows.Forms.Button bniniciar;
        private System.Windows.Forms.Button bnopciones;
        private System.Windows.Forms.Button bnsalir;
    }
}

