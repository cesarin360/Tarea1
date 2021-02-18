namespace tarea1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Leer = new System.Windows.Forms.Button();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.btn_resolver = new System.Windows.Forms.Button();
            this.btn_aleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Leer
            // 
            this.btn_Leer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Leer.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Leer.ForeColor = System.Drawing.Color.Red;
            this.btn_Leer.Location = new System.Drawing.Point(121, 200);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(117, 38);
            this.btn_Leer.TabIndex = 0;
            this.btn_Leer.Text = "Leer";
            this.btn_Leer.UseVisualStyleBackColor = false;
            this.btn_Leer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatriz
            // 
            this.txtMatriz.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMatriz.Location = new System.Drawing.Point(272, 148);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(314, 141);
            this.txtMatriz.TabIndex = 1;
            this.txtMatriz.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // btn_resolver
            // 
            this.btn_resolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resolver.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resolver.ForeColor = System.Drawing.Color.Red;
            this.btn_resolver.Location = new System.Drawing.Point(121, 253);
            this.btn_resolver.Name = "btn_resolver";
            this.btn_resolver.Size = new System.Drawing.Size(117, 36);
            this.btn_resolver.TabIndex = 2;
            this.btn_resolver.Text = "Resolver";
            this.btn_resolver.UseVisualStyleBackColor = false;
            this.btn_resolver.Click += new System.EventHandler(this.btn_resolver_Click);
            // 
            // btn_aleatorio
            // 
            this.btn_aleatorio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_aleatorio.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aleatorio.ForeColor = System.Drawing.Color.Red;
            this.btn_aleatorio.Location = new System.Drawing.Point(121, 148);
            this.btn_aleatorio.Name = "btn_aleatorio";
            this.btn_aleatorio.Size = new System.Drawing.Size(117, 38);
            this.btn_aleatorio.TabIndex = 3;
            this.btn_aleatorio.Text = "Aleatorio";
            this.btn_aleatorio.UseVisualStyleBackColor = false;
            this.btn_aleatorio.Click += new System.EventHandler(this.btn_aleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aleatorio);
            this.Controls.Add(this.btn_resolver);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.btn_Leer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Leer;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button btn_resolver;
        private System.Windows.Forms.Button btn_aleatorio;
    }
}

