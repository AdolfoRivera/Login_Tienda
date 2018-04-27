namespace Login_Tienda
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.button_ventas = new System.Windows.Forms.Button();
            this.button_clientes = new System.Windows.Forms.Button();
            this.button_productos = new System.Windows.Forms.Button();
            this.button4_inventario = new System.Windows.Forms.Button();
            this.button_confoguracion = new System.Windows.Forms.Button();
            this.button6_corte = new System.Windows.Forms.Button();
            this.button_administrador = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_regersar_2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.venta2 = new System.Windows.Forms.Button();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_h = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_hora_actual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.MinimumSize = new System.Drawing.Size(1400, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 70);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abarrotes El Abra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Punto De Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1068, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Le atiende:";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.AliceBlue;
            this.label_usuario.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(1182, 13);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(50, 22);
            this.label_usuario.TabIndex = 9;
            this.label_usuario.Text = "?????";
            this.label_usuario.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_ventas
            // 
            this.button_ventas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ventas.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ventas.Location = new System.Drawing.Point(4, 77);
            this.button_ventas.Name = "button_ventas";
            this.button_ventas.Size = new System.Drawing.Size(97, 35);
            this.button_ventas.TabIndex = 10;
            this.button_ventas.Text = "Ventas";
            this.button_ventas.UseVisualStyleBackColor = true;
            this.button_ventas.Click += new System.EventHandler(this.button_ventas_Click);
            // 
            // button_clientes
            // 
            this.button_clientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_clientes.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clientes.Location = new System.Drawing.Point(211, 77);
            this.button_clientes.Name = "button_clientes";
            this.button_clientes.Size = new System.Drawing.Size(97, 35);
            this.button_clientes.TabIndex = 11;
            this.button_clientes.Text = "Clientes";
            this.button_clientes.UseVisualStyleBackColor = true;
            this.button_clientes.Click += new System.EventHandler(this.button_clientes_Click);
            // 
            // button_productos
            // 
            this.button_productos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_productos.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_productos.Location = new System.Drawing.Point(107, 77);
            this.button_productos.Name = "button_productos";
            this.button_productos.Size = new System.Drawing.Size(97, 35);
            this.button_productos.TabIndex = 12;
            this.button_productos.Text = "Productos";
            this.button_productos.UseVisualStyleBackColor = true;
            this.button_productos.Click += new System.EventHandler(this.button_productos_Click);
            // 
            // button4_inventario
            // 
            this.button4_inventario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4_inventario.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_inventario.Location = new System.Drawing.Point(314, 77);
            this.button4_inventario.Name = "button4_inventario";
            this.button4_inventario.Size = new System.Drawing.Size(97, 35);
            this.button4_inventario.TabIndex = 13;
            this.button4_inventario.Text = "Inventario";
            this.button4_inventario.UseVisualStyleBackColor = true;
            // 
            // button_confoguracion
            // 
            this.button_confoguracion.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confoguracion.Location = new System.Drawing.Point(417, 77);
            this.button_confoguracion.Name = "button_confoguracion";
            this.button_confoguracion.Size = new System.Drawing.Size(103, 35);
            this.button_confoguracion.TabIndex = 14;
            this.button_confoguracion.Text = "Configuracion";
            this.button_confoguracion.UseVisualStyleBackColor = true;
            // 
            // button6_corte
            // 
            this.button6_corte.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6_corte.Location = new System.Drawing.Point(526, 77);
            this.button6_corte.Name = "button6_corte";
            this.button6_corte.Size = new System.Drawing.Size(97, 35);
            this.button6_corte.TabIndex = 15;
            this.button6_corte.Text = "Corte";
            this.button6_corte.UseVisualStyleBackColor = true;
            // 
            // button_administrador
            // 
            this.button_administrador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_administrador.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_administrador.Location = new System.Drawing.Point(1189, 43);
            this.button_administrador.Name = "button_administrador";
            this.button_administrador.Size = new System.Drawing.Size(107, 23);
            this.button_administrador.TabIndex = 17;
            this.button_administrador.Text = "Administrador";
            this.button_administrador.UseVisualStyleBackColor = true;
            this.button_administrador.Click += new System.EventHandler(this.button_administrador_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_contenedor.BackgroundImage")));
            this.panel_contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_contenedor.Location = new System.Drawing.Point(-2, 118);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1362, 596);
            this.panel_contenedor.TabIndex = 39;
            // 
            // button_salir
            // 
            this.button_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_salir.BackgroundImage")));
            this.button_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_salir.Location = new System.Drawing.Point(1318, 74);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(28, 27);
            this.button_salir.TabIndex = 16;
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // button_regersar_2
            // 
            this.button_regersar_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_regersar_2.BackgroundImage")));
            this.button_regersar_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_regersar_2.Location = new System.Drawing.Point(1308, 10);
            this.button_regersar_2.Name = "button_regersar_2";
            this.button_regersar_2.Size = new System.Drawing.Size(28, 23);
            this.button_regersar_2.TabIndex = 7;
            this.button_regersar_2.UseVisualStyleBackColor = true;
            this.button_regersar_2.Click += new System.EventHandler(this.button_regersar_2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_Tienda.Properties.Resources.CAJA;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // venta2
            // 
            this.venta2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta2.Location = new System.Drawing.Point(629, 77);
            this.venta2.Name = "venta2";
            this.venta2.Size = new System.Drawing.Size(97, 35);
            this.venta2.TabIndex = 40;
            this.venta2.Text = "Ventas 2";
            this.venta2.UseVisualStyleBackColor = true;
            this.venta2.Click += new System.EventHandler(this.venta2_Click);
            // 
            // button_minimizar
            // 
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_minimizar.Location = new System.Drawing.Point(1221, 78);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(75, 23);
            this.button_minimizar.TabIndex = 41;
            this.button_minimizar.Text = "Minimizar";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abarrotes El Abra";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.BackColor = System.Drawing.Color.AliceBlue;
            this.label_h.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h.Location = new System.Drawing.Point(430, 22);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(160, 28);
            this.label_h.TabIndex = 42;
            this.label_h.Text = "Fecha y hora:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_hora_actual
            // 
            this.label_hora_actual.AutoSize = true;
            this.label_hora_actual.BackColor = System.Drawing.Color.AliceBlue;
            this.label_hora_actual.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora_actual.Location = new System.Drawing.Point(588, 22);
            this.label_hora_actual.Name = "label_hora_actual";
            this.label_hora_actual.Size = new System.Drawing.Size(68, 28);
            this.label_hora_actual.TabIndex = 43;
            this.label_hora_actual.Text = "Hora";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1364, 711);
            this.Controls.Add(this.label_hora_actual);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.button_minimizar);
            this.Controls.Add(this.venta2);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.button_administrador);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button6_corte);
            this.Controls.Add(this.button_confoguracion);
            this.Controls.Add(this.button4_inventario);
            this.Controls.Add(this.button_productos);
            this.Controls.Add(this.button_clientes);
            this.Controls.Add(this.button_ventas);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_regersar_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 43);
            this.Name = "menu";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.Resize += new System.EventHandler(this.menu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_regersar_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ventas;
        private System.Windows.Forms.Button button_clientes;
        private System.Windows.Forms.Button button_productos;
        private System.Windows.Forms.Button button4_inventario;
        private System.Windows.Forms.Button button_confoguracion;
        private System.Windows.Forms.Button button6_corte;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_administrador;
        private System.Windows.Forms.Button venta2;
        public System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label_hora_actual;
    }
}