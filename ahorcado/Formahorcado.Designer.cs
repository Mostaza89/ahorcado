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
            this.lblPalabra.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(77, 122);
            this.lblPalabra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(62, 34);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "label1";
            this.lblPalabra.Click += new System.EventHandler(this.lblPalabra_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.Location = new System.Drawing.Point(77, 182);
            this.lblErrores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(62, 34);
            this.lblErrores.TabIndex = 1;
            this.lblErrores.Text = "label1";
            this.lblErrores.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(75, 245);
            this.lblIntentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(64, 34);
            this.lblIntentos.TabIndex = 2;
            this.lblIntentos.Text = "label2";
            this.lblIntentos.Click += new System.EventHandler(this.lblIntentos_Click);
            // 
            // pbAhorcado
            // 
            this.pbAhorcado.Location = new System.Drawing.Point(332, 166);
            this.pbAhorcado.Margin = new System.Windows.Forms.Padding(2);
            this.pbAhorcado.Name = "pbAhorcado";
            this.pbAhorcado.Size = new System.Drawing.Size(173, 159);
            this.pbAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAhorcado.TabIndex = 3;
            this.pbAhorcado.TabStop = false;
            this.pbAhorcado.Click += new System.EventHandler(this.pbAhorcado_Click);
            // 
            // flpBotones
            // 
            this.flpBotones.Location = new System.Drawing.Point(11, 372);
            this.flpBotones.Margin = new System.Windows.Forms.Padding(2);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(639, 89);
            this.flpBotones.TabIndex = 4;
            this.flpBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBotones_Paint);
            // 
            // Formahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ahorcado.Properties.Resources._3b56ea8467e63d102d24420119178c23;
            this.ClientSize = new System.Drawing.Size(661, 473);
            this.Controls.Add(this.flpBotones);
            this.Controls.Add(this.pbAhorcado);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblPalabra);
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