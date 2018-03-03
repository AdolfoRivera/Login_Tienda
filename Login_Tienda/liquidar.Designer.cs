namespace Login_Tienda
{
    partial class liquidar
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seguro que deseas liquidar el adeudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1, 33);
            this.label2.MinimumSize = new System.Drawing.Size(390, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 13);
            this.label2.TabIndex = 1;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.Location = new System.Drawing.Point(64, 57);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(108, 28);
            this.button_aceptar.TabIndex = 2;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(223, 57);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(108, 28);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // liquidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(382, 97);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "liquidar";
            this.Text = "liquidar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
    }
}