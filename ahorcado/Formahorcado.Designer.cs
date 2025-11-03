namespace ahorcado
{
    partial class Formahorcado
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
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.pbAhorcado = new System.Windows.Forms.PictureBox();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(254, 158);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(44, 16);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "label1";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(254, 193);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(44, 16);
            this.lblErrores.TabIndex = 1;
            this.lblErrores.Text = "label1";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(254, 235);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(44, 16);
            this.lblIntentos.TabIndex = 2;
            this.lblIntentos.Text = "label2";
            // 
            // pbAhorcado
            // 
            this.pbAhorcado.Location = new System.Drawing.Point(257, 12);
            this.pbAhorcado.Name = "pbAhorcado";
            this.pbAhorcado.Size = new System.Drawing.Size(100, 50);
            this.pbAhorcado.TabIndex = 3;
            this.pbAhorcado.TabStop = false;
            // 
            // flpBotones
            // 
            this.flpBotones.Location = new System.Drawing.Point(12, 266);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(608, 194);
            this.flpBotones.TabIndex = 4;
            // 
            // Formahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ahorcado.Properties.Resources._3b56ea8467e63d102d24420119178c23;
            this.ClientSize = new System.Drawing.Size(632, 472);
            this.Controls.Add(this.flpBotones);
            this.Controls.Add(this.pbAhorcado);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblPalabra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formahorcado";
            this.Text = "Formahorcado";
            this.Load += new System.EventHandler(this.Formahorcado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.PictureBox pbAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
    }
}