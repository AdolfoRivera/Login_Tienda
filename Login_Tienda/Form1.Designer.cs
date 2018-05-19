namespace Login_Tienda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_aseptar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.checkBox_mostrar_contraseña = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_rejistrarse = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_porciento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // button_aseptar
            // 
            this.button_aseptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_aseptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_aseptar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aseptar.Location = new System.Drawing.Point(103, 141);
            this.button_aseptar.Name = "button_aseptar";
            this.button_aseptar.Size = new System.Drawing.Size(89, 32);
            this.button_aseptar.TabIndex = 2;
            this.button_aseptar.Text = "Aceptar";
            this.button_aseptar.UseVisualStyleBackColor = false;
            this.button_aseptar.Click += new System.EventHandler(this.button_aseptar_Click);
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_salir.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.Location = new System.Drawing.Point(281, 141);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(96, 32);
            this.button_salir.TabIndex = 3;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_usuario.Location = new System.Drawing.Point(145, 60);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(223, 26);
            this.textBox_usuario.TabIndex = 5;
            this.textBox_usuario.Text = "Nombre";
            this.textBox_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_usuario.Enter += new System.EventHandler(this.textBox_usuario_Enter);
            this.textBox_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_usuario_KeyPress);
            this.textBox_usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_usuario_KeyUp);
            this.textBox_usuario.Leave += new System.EventHandler(this.textBox_usuario_Leave);
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contraseña.Location = new System.Drawing.Point(191, 108);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.Size = new System.Drawing.Size(177, 23);
            this.textBox_contraseña.TabIndex = 6;
            this.textBox_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_contraseña.UseSystemPasswordChar = true;
            this.textBox_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contraseña_KeyPress);
            this.textBox_contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_contraseña_KeyUp);
            // 
            // checkBox_mostrar_contraseña
            // 
            this.checkBox_mostrar_contraseña.AutoSize = true;
            this.checkBox_mostrar_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_mostrar_contraseña.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mostrar_contraseña.Location = new System.Drawing.Point(380, 114);
            this.checkBox_mostrar_contraseña.MaximumSize = new System.Drawing.Size(0, 20);
            this.checkBox_mostrar_contraseña.MinimumSize = new System.Drawing.Size(30, 20);
            this.checkBox_mostrar_contraseña.Name = "checkBox_mostrar_contraseña";
            this.checkBox_mostrar_contraseña.Size = new System.Drawing.Size(82, 20);
            this.checkBox_mostrar_contraseña.TabIndex = 7;
            this.checkBox_mostrar_contraseña.Text = "Mostrar";
            this.checkBox_mostrar_contraseña.UseVisualStyleBackColor = false;
            this.checkBox_mostrar_contraseña.CheckedChanged += new System.EventHandler(this.checkBox_mostrar_contraseña_CheckedChanged);
            this.checkBox_mostrar_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox_mostrar_contraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.MinimumSize = new System.Drawing.Size(493, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Abarrotes El Abra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(1, 30);
            this.label4.MinimumSize = new System.Drawing.Size(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 190);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(1, 215);
            this.label5.MinimumSize = new System.Drawing.Size(495, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(483, 30);
            this.label6.MinimumSize = new System.Drawing.Size(10, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 190);
            this.label6.TabIndex = 11;
            // 
            // button_rejistrarse
            // 
            this.button_rejistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_rejistrarse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rejistrarse.BackgroundImage")));
            this.button_rejistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_rejistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rejistrarse.Location = new System.Drawing.Point(441, 31);
            this.button_rejistrarse.Name = "button_rejistrarse";
            this.button_rejistrarse.Size = new System.Drawing.Size(41, 40);
            this.button_rejistrarse.TabIndex = 4;
            this.button_rejistrarse.UseVisualStyleBackColor = false;
            this.button_rejistrarse.Click += new System.EventHandler(this.button_rejistrarse_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(471, 10);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(191, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 25);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lb_porciento
            // 
            this.lb_porciento.AutoSize = true;
            this.lb_porciento.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porciento.Location = new System.Drawing.Point(228, 190);
            this.lb_porciento.Name = "lb_porciento";
            this.lb_porciento.Size = new System.Drawing.Size(27, 20);
            this.lb_porciento.TabIndex = 15;
            this.lb_porciento.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 227);
            this.Controls.Add(this.lb_porciento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_mostrar_contraseña);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.button_rejistrarse);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_aseptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_aseptar;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.CheckBox checkBox_mostrar_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button_rejistrarse;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_porciento;
    }
}

