﻿namespace Login_Tienda
{
    partial class enter_cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enter_cobrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_total_a_pagar = new System.Windows.Forms.Label();
            this.radioButton1_efectivo = new System.Windows.Forms.RadioButton();
            this.radioButton_credito = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_pago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_cambio_pago = new System.Windows.Forms.Label();
            this.button_cobrar = new System.Windows.Forms.Button();
            this.button_cobrar_e_imprimir_ticket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nombre_cobrear = new System.Windows.Forms.TextBox();
            this.textBox_fecha_cobrar = new System.Windows.Forms.TextBox();
            this.textBox_total_cobrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.MinimumSize = new System.Drawing.Size(630, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            // 
            // label_total_a_pagar
            // 
            this.label_total_a_pagar.AutoSize = true;
            this.label_total_a_pagar.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_a_pagar.Location = new System.Drawing.Point(86, 155);
            this.label_total_a_pagar.Name = "label_total_a_pagar";
            this.label_total_a_pagar.Size = new System.Drawing.Size(111, 54);
            this.label_total_a_pagar.TabIndex = 2;
            this.label_total_a_pagar.Text = "0.00";
            this.label_total_a_pagar.Click += new System.EventHandler(this.label_total_a_pagar_Click);
            // 
            // radioButton1_efectivo
            // 
            this.radioButton1_efectivo.AutoSize = true;
            this.radioButton1_efectivo.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1_efectivo.Location = new System.Drawing.Point(95, 124);
            this.radioButton1_efectivo.Name = "radioButton1_efectivo";
            this.radioButton1_efectivo.Size = new System.Drawing.Size(106, 28);
            this.radioButton1_efectivo.TabIndex = 3;
            this.radioButton1_efectivo.TabStop = true;
            this.radioButton1_efectivo.Text = "Efectivo";
            this.radioButton1_efectivo.UseVisualStyleBackColor = true;
            // 
            // radioButton_credito
            // 
            this.radioButton_credito.AutoSize = true;
            this.radioButton_credito.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_credito.Location = new System.Drawing.Point(448, 124);
            this.radioButton_credito.Name = "radioButton_credito";
            this.radioButton_credito.Size = new System.Drawing.Size(100, 28);
            this.radioButton_credito.TabIndex = 4;
            this.radioButton_credito.TabStop = true;
            this.radioButton_credito.Text = "Credito";
            this.radioButton_credito.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selecciona al cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pago con:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Su cambio:";
            // 
            // textBox_pago
            // 
            this.textBox_pago.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pago.Location = new System.Drawing.Point(118, 229);
            this.textBox_pago.MaxLength = 5;
            this.textBox_pago.Name = "textBox_pago";
            this.textBox_pago.Size = new System.Drawing.Size(122, 25);
            this.textBox_pago.TabIndex = 9;
            this.textBox_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pago_KeyDown);
            this.textBox_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pago_KeyPress);
            this.textBox_pago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pago_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "$";
            // 
            // label_cambio_pago
            // 
            this.label_cambio_pago.AutoSize = true;
            this.label_cambio_pago.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cambio_pago.Location = new System.Drawing.Point(154, 266);
            this.label_cambio_pago.Name = "label_cambio_pago";
            this.label_cambio_pago.Size = new System.Drawing.Size(67, 32);
            this.label_cambio_pago.TabIndex = 11;
            this.label_cambio_pago.Text = "0.00";
            // 
            // button_cobrar
            // 
            this.button_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_cobrar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cobrar.Location = new System.Drawing.Point(60, 320);
            this.button_cobrar.Name = "button_cobrar";
            this.button_cobrar.Size = new System.Drawing.Size(161, 33);
            this.button_cobrar.TabIndex = 12;
            this.button_cobrar.Text = "Cobrar";
            this.button_cobrar.UseVisualStyleBackColor = true;
            this.button_cobrar.Click += new System.EventHandler(this.button_cobrar_Click);
            // 
            // button_cobrar_e_imprimir_ticket
            // 
            this.button_cobrar_e_imprimir_ticket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_cobrar_e_imprimir_ticket.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cobrar_e_imprimir_ticket.Location = new System.Drawing.Point(30, 359);
            this.button_cobrar_e_imprimir_ticket.Name = "button_cobrar_e_imprimir_ticket";
            this.button_cobrar_e_imprimir_ticket.Size = new System.Drawing.Size(227, 34);
            this.button_cobrar_e_imprimir_ticket.TabIndex = 13;
            this.button_cobrar_e_imprimir_ticket.Text = "Cobrar e imprimir ticket";
            this.button_cobrar_e_imprimir_ticket.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(319, 111);
            this.label3.MinimumSize = new System.Drawing.Size(20, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 355);
            this.label3.TabIndex = 14;
            // 
            // textBox_nombre_cobrear
            // 
            this.textBox_nombre_cobrear.Enabled = false;
            this.textBox_nombre_cobrear.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre_cobrear.Location = new System.Drawing.Point(60, 52);
            this.textBox_nombre_cobrear.Name = "textBox_nombre_cobrear";
            this.textBox_nombre_cobrear.Size = new System.Drawing.Size(122, 25);
            this.textBox_nombre_cobrear.TabIndex = 16;
            // 
            // textBox_fecha_cobrar
            // 
            this.textBox_fecha_cobrar.Enabled = false;
            this.textBox_fecha_cobrar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fecha_cobrar.Location = new System.Drawing.Point(254, 52);
            this.textBox_fecha_cobrar.Name = "textBox_fecha_cobrar";
            this.textBox_fecha_cobrar.Size = new System.Drawing.Size(122, 25);
            this.textBox_fecha_cobrar.TabIndex = 17;
            // 
            // textBox_total_cobrar
            // 
            this.textBox_total_cobrar.Enabled = false;
            this.textBox_total_cobrar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total_cobrar.Location = new System.Drawing.Point(454, 52);
            this.textBox_total_cobrar.Name = "textBox_total_cobrar";
            this.textBox_total_cobrar.Size = new System.Drawing.Size(122, 25);
            this.textBox_total_cobrar.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(4, 91);
            this.label8.MinimumSize = new System.Drawing.Size(630, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(630, 20);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 54);
            this.label9.TabIndex = 20;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 28);
            this.label10.TabIndex = 21;
            this.label10.Text = "Descripcion de venta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(455, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 54);
            this.label11.TabIndex = 22;
            this.label11.Text = "0.00";
            // 
            // enter_cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 394);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_total_cobrar);
            this.Controls.Add(this.textBox_fecha_cobrar);
            this.Controls.Add(this.textBox_nombre_cobrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cobrar_e_imprimir_ticket);
            this.Controls.Add(this.button_cobrar);
            this.Controls.Add(this.label_cambio_pago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_pago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton_credito);
            this.Controls.Add(this.radioButton1_efectivo);
            this.Controls.Add(this.label_total_a_pagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "enter_cobrar";
            this.Load += new System.EventHandler(this.enter_cobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_credito;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label_total_a_pagar;
        public System.Windows.Forms.TextBox textBox_pago;
        public System.Windows.Forms.Label label_cambio_pago;
        public System.Windows.Forms.Button button_cobrar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton radioButton1_efectivo;
        public System.Windows.Forms.Button button_cobrar_e_imprimir_ticket;
        public System.Windows.Forms.TextBox textBox_nombre_cobrear;
        public System.Windows.Forms.TextBox textBox_fecha_cobrar;
        public System.Windows.Forms.TextBox textBox_total_cobrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
    }
}