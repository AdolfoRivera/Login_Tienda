namespace Login_Tienda
{
    partial class Bitacoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacoras));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bucar_usuario = new System.Windows.Forms.TextBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_mostrara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.button_suma = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_total_entr_y_sal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha_ent_y_sal = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(427, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textBox_bucar_usuario
            // 
            this.textBox_bucar_usuario.Location = new System.Drawing.Point(69, 63);
            this.textBox_bucar_usuario.Name = "textBox_bucar_usuario";
            this.textBox_bucar_usuario.Size = new System.Drawing.Size(224, 20);
            this.textBox_bucar_usuario.TabIndex = 2;
            this.textBox_bucar_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_bucar_usuario_KeyPress);
            this.textBox_bucar_usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_fecha.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(69, 19);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker_fecha.TabIndex = 3;
            this.dateTimePicker_fecha.ValueChanged += new System.EventHandler(this.dateTimePicker_fecha_ValueChanged);
            this.dateTimePicker_fecha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_fecha_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // button_mostrara
            // 
            this.button_mostrara.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mostrara.Location = new System.Drawing.Point(804, 0);
            this.button_mostrara.Name = "button_mostrara";
            this.button_mostrara.Size = new System.Drawing.Size(87, 29);
            this.button_mostrara.TabIndex = 5;
            this.button_mostrara.Text = "Mostrar";
            this.button_mostrara.UseVisualStyleBackColor = true;
            this.button_mostrara.Click += new System.EventHandler(this.button_mostrara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(77, 314);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_total.TabIndex = 7;
            // 
            // button_suma
            // 
            this.button_suma.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suma.Location = new System.Drawing.Point(229, 16);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(87, 29);
            this.button_suma.TabIndex = 8;
            this.button_suma.Text = "suma";
            this.button_suma.UseVisualStyleBackColor = true;
            this.button_suma.Click += new System.EventHandler(this.button_suma_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(446, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.Size = new System.Drawing.Size(435, 210);
            this.dataGridView2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // textBox_total_entr_y_sal
            // 
            this.textBox_total_entr_y_sal.Enabled = false;
            this.textBox_total_entr_y_sal.Location = new System.Drawing.Point(512, 314);
            this.textBox_total_entr_y_sal.Name = "textBox_total_entr_y_sal";
            this.textBox_total_entr_y_sal.Size = new System.Drawing.Size(100, 20);
            this.textBox_total_entr_y_sal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker_fecha_ent_y_sal
            // 
            this.dateTimePicker_fecha_ent_y_sal.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_fecha_ent_y_sal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_fecha_ent_y_sal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fecha_ent_y_sal.Location = new System.Drawing.Point(502, 19);
            this.dateTimePicker_fecha_ent_y_sal.Name = "dateTimePicker_fecha_ent_y_sal";
            this.dateTimePicker_fecha_ent_y_sal.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker_fecha_ent_y_sal.TabIndex = 13;
            this.dateTimePicker_fecha_ent_y_sal.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar";
            // 
            // Bitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(893, 346);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_fecha_ent_y_sal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_total_entr_y_sal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_suma);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_mostrara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.textBox_bucar_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bitacoras";
            this.Load += new System.EventHandler(this.Bitacoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bucar_usuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_mostrara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_total_entr_y_sal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha_ent_y_sal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}