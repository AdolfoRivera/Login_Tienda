namespace Login_Tienda
{
    partial class buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tecle El Codigo Del Producto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.MinimumSize = new System.Drawing.Size(610, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 20);
            this.label2.TabIndex = 1;
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.Location = new System.Drawing.Point(42, 61);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(524, 20);
            this.textBox_buscar.TabIndex = 2;
            this.textBox_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_buscar_KeyPress);
            this.textBox_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox_buscar.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_buscar_Validating);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_aceptar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.Location = new System.Drawing.Point(24, 381);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(159, 35);
            this.button_aceptar.TabIndex = 4;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(418, 381);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(159, 35);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // datos
            // 
            this.datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datos.Location = new System.Drawing.Point(4, 95);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.RowHeadersVisible = false;
            this.datos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datos.Size = new System.Drawing.Size(607, 269);
            this.datos.TabIndex = 6;
            this.datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_CellClick);
            this.datos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_CellContentDoubleClick);
            this.datos.DoubleClick += new System.EventHandler(this.datos_DoubleClick);
            this.datos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            this.datos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datos_MouseDoubleClick);
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Enabled = false;
            this.textBox_cantidad.Location = new System.Drawing.Point(13, 25);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(30, 20);
            this.textBox_cantidad.TabIndex = 7;
            this.textBox_cantidad.Text = "1";
            this.textBox_cantidad.Visible = false;
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 428);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "buscar";
            this.Load += new System.EventHandler(this.buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancelar;
        public System.Windows.Forms.TextBox textBox_buscar;
        public System.Windows.Forms.Button button_aceptar;
        public System.Windows.Forms.TextBox textBox_cantidad;
        public System.Windows.Forms.DataGridView datos;
    }
}