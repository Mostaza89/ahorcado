namespace ahorcado
{
    partial class Forminiciojuego
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bnpalabra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 384);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 130);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(16, 405);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(286, 44);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Introduce una palabra...";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(16, 450);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(205, 51);
            this.tb1.TabIndex = 6;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // bnpalabra
            // 
            this.bnpalabra.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnpalabra.Location = new System.Drawing.Point(565, 453);
            this.bnpalabra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnpalabra.Name = "bnpalabra";
            this.bnpalabra.Size = new System.Drawing.Size(151, 50);
            this.bnpalabra.TabIndex = 7;
            this.bnpalabra.Text = "Listo..";
            this.bnpalabra.UseVisualStyleBackColor = true;
            this.bnpalabra.Click += new System.EventHandler(this.bnpalabra_Click);
            // 
            // Forminiciojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ahorcado.Properties.Resources.damn;
            this.ClientSize = new System.Drawing.Size(741, 516);
            this.Controls.Add(this.bnpalabra);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Forminiciojuego";
            this.Text = "Forminiciojuego";
            this.Load += new System.EventHandler(this.Forminiciojuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button bnpalabra;
    }
}