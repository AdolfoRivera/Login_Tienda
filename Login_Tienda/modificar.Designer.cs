namespace Login_Tienda
{
    partial class modificar
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
            this.textBox_codigo_de_barras_modificar = new System.Windows.Forms.TextBox();
            this.button_aceptar_modificacion = new System.Windows.Forms.Button();
            this.button_cancelar_modificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // textBox_codigo_de_barras_modificar
            // 
            this.textBox_codigo_de_barras_modificar.Location = new System.Drawing.Point(83, 23);
            this.textBox_codigo_de_barras_modificar.Name = "textBox_codigo_de_barras_modificar";
            this.textBox_codigo_de_barras_modificar.Size = new System.Drawing.Size(256, 20);
            this.textBox_codigo_de_barras_modificar.TabIndex = 1;
            // 
            // button_aceptar_modificacion
            // 
            this.button_aceptar_modificacion.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar_modificacion.Location = new System.Drawing.Point(37, 58);
            this.button_aceptar_modificacion.Name = "button_aceptar_modificacion";
            this.button_aceptar_modificacion.Size = new System.Drawing.Size(116, 32);
            this.button_aceptar_modificacion.TabIndex = 2;
            this.button_aceptar_modificacion.Text = "Aceptar";
            this.button_aceptar_modificacion.UseVisualStyleBackColor = true;
            // 
            // button_cancelar_modificacion
            // 
            this.button_cancelar_modificacion.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar_modificacion.Location = new System.Drawing.Point(205, 58);
            this.button_cancelar_modificacion.Name = "button_cancelar_modificacion";
            this.button_cancelar_modificacion.Size = new System.Drawing.Size(119, 32);
            this.button_cancelar_modificacion.TabIndex = 3;
            this.button_cancelar_modificacion.Text = "Cancelar";
            this.button_cancelar_modificacion.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 95);
            this.Controls.Add(this.button_cancelar_modificacion);
            this.Controls.Add(this.button_aceptar_modificacion);
            this.Controls.Add(this.textBox_codigo_de_barras_modificar);
            this.Controls.Add(this.label1);
            this.Name = "modificar";
            this.Text = "modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_codigo_de_barras_modificar;
        private System.Windows.Forms.Button button_aceptar_modificacion;
        private System.Windows.Forms.Button button_cancelar_modificacion;
    }
}