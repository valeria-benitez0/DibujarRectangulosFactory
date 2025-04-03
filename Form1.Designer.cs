namespace DibujarRectangulosFactory
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelDibujo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(98, 43);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(98, 89);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(98, 138);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(98, 200);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(152, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear Rectángulo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.Black;
            this.picColor.Location = new System.Drawing.Point(98, 270);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(100, 50);
            this.picColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picColor.TabIndex = 4;
            this.picColor.TabStop = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Location = new System.Drawing.Point(464, 76);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(200, 100);
            this.panelDibujo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panelDibujo;
    }
}

