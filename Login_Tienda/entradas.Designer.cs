namespace Login_Tienda
{
    partial class entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entradas));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_consepto = new System.Windows.Forms.TextBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_hora = new System.Windows.Forms.TextBox();
            this.textBox_descipcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(12, 51);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(235, 20);
            this.textBox_cantidad.TabIndex = 1;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consepto";
            // 
            // textBox_consepto
            // 
            this.textBox_consepto.Location = new System.Drawing.Point(12, 99);
            this.textBox_consepto.Name = "textBox_consepto";
            this.textBox_consepto.Size = new System.Drawing.Size(235, 20);
            this.textBox_consepto.TabIndex = 3;
            this.textBox_consepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_consepto_KeyPress);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.Location = new System.Drawing.Point(56, 125);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(163, 32);
            this.button_aceptar.TabIndex = 4;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(260, 3);
            this.label3.MinimumSize = new System.Drawing.Size(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 180);
            this.label3.TabIndex = 6;
            // 
            // textBox_hora
            // 
            this.textBox_hora.Location = new System.Drawing.Point(12, 3);
            this.textBox_hora.Name = "textBox_hora";
            this.textBox_hora.Size = new System.Drawing.Size(100, 20);
            this.textBox_hora.TabIndex = 7;
            this.textBox_hora.Visible = false;
            // 
            // textBox_descipcion
            // 
            this.textBox_descipcion.Location = new System.Drawing.Point(147, 3);
            this.textBox_descipcion.Name = "textBox_descipcion";
            this.textBox_descipcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_descipcion.TabIndex = 8;
            this.textBox_descipcion.Text = "Entrada";
            this.textBox_descipcion.Visible = false;
            // 
            // entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(276, 159);
            this.Controls.Add(this.textBox_descipcion);
            this.Controls.Add(this.textBox_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.textBox_consepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.entradas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_consepto;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_hora;
        private System.Windows.Forms.TextBox textBox_descipcion;
    }
}