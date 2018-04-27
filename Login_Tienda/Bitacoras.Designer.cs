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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bucar_usuario = new System.Windows.Forms.TextBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_mostrara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.button_suma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Name = "dataGridView1";
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
            this.textBox_bucar_usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.CustomFormat = "dd-MM-yyyy";
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
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // button_mostrara
            // 
            this.button_mostrara.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mostrara.Location = new System.Drawing.Point(336, 57);
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
            this.label3.Location = new System.Drawing.Point(246, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(310, 317);
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
            // Bitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 346);
            this.Controls.Add(this.button_suma);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_mostrara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.textBox_bucar_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bitacoras";
            this.Text = "Bitacoras";
            this.Load += new System.EventHandler(this.Bitacoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}