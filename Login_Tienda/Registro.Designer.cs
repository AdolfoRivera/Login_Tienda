namespace Login_Tienda
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.button_aseptar = new System.Windows.Forms.Button();
            this.button_canselar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_nombre.Location = new System.Drawing.Point(106, 38);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(168, 26);
            this.textBox1_nombre.TabIndex = 4;
            this.textBox1_nombre.TextChanged += new System.EventHandler(this.textBox1_nombre_TextChanged);
            this.textBox1_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_nombre_KeyPress);
            this.textBox1_nombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_nombre_Validating);
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(406, 40);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(171, 26);
            this.textBox_apellido.TabIndex = 5;
            this.textBox_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_KeyPress);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(108, 106);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(166, 26);
            this.textBox_telefono.TabIndex = 6;
            this.textBox_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telefono_KeyPress);
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contraseña.Location = new System.Drawing.Point(406, 106);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.Size = new System.Drawing.Size(171, 26);
            this.textBox_contraseña.TabIndex = 7;
            this.textBox_contraseña.UseSystemPasswordChar = true;
            this.textBox_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contraseña_KeyPress);
            this.textBox_contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_contraseña_KeyUp);
            // 
            // button_aseptar
            // 
            this.button_aseptar.BackColor = System.Drawing.Color.Silver;
            this.button_aseptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_aseptar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aseptar.Location = new System.Drawing.Point(130, 164);
            this.button_aseptar.Name = "button_aseptar";
            this.button_aseptar.Size = new System.Drawing.Size(115, 37);
            this.button_aseptar.TabIndex = 8;
            this.button_aseptar.Text = "Aceptar";
            this.button_aseptar.UseVisualStyleBackColor = false;
            this.button_aseptar.Click += new System.EventHandler(this.button_aseptar_Click);
            // 
            // button_canselar
            // 
            this.button_canselar.BackColor = System.Drawing.Color.Silver;
            this.button_canselar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_canselar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_canselar.Location = new System.Drawing.Point(406, 164);
            this.button_canselar.Name = "button_canselar";
            this.button_canselar.Size = new System.Drawing.Size(105, 37);
            this.button_canselar.TabIndex = 9;
            this.button_canselar.Text = "Cerrar";
            this.button_canselar.UseVisualStyleBackColor = false;
            this.button_canselar.Click += new System.EventHandler(this.button_canselar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(620, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(0, 206);
            this.label6.MinimumSize = new System.Drawing.Size(20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(590, 206);
            this.label7.MinimumSize = new System.Drawing.Size(20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 219);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_canselar);
            this.Controls.Add(this.button_aseptar);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox1_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATE";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.Button button_aseptar;
        private System.Windows.Forms.Button button_canselar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}