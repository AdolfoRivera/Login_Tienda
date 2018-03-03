namespace Login_Tienda
{
    partial class eliminar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_aceptar_eliminar = new System.Windows.Forms.Button();
            this.button_cancelar_eliminacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_aceptar_eliminar
            // 
            this.button_aceptar_eliminar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar_eliminar.Location = new System.Drawing.Point(44, 51);
            this.button_aceptar_eliminar.Name = "button_aceptar_eliminar";
            this.button_aceptar_eliminar.Size = new System.Drawing.Size(116, 32);
            this.button_aceptar_eliminar.TabIndex = 2;
            this.button_aceptar_eliminar.Text = "Aceptar";
            this.button_aceptar_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_cancelar_eliminacion
            // 
            this.button_cancelar_eliminacion.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar_eliminacion.Location = new System.Drawing.Point(204, 51);
            this.button_cancelar_eliminacion.Name = "button_cancelar_eliminacion";
            this.button_cancelar_eliminacion.Size = new System.Drawing.Size(116, 32);
            this.button_cancelar_eliminacion.TabIndex = 3;
            this.button_cancelar_eliminacion.Text = "Cancelar";
            this.button_cancelar_eliminacion.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 95);
            this.Controls.Add(this.button_cancelar_eliminacion);
            this.Controls.Add(this.button_aceptar_eliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "eliminar";
            this.Text = "eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_aceptar_eliminar;
        private System.Windows.Forms.Button button_cancelar_eliminacion;
    }
}