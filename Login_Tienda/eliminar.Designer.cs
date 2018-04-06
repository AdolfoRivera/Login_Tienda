namespace Login_Tienda
{
    partial class prueba_de_venta
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
            this.BTN_AGREGAR = new System.Windows.Forms.Button();
            this.CANCELAR_VENTA = new System.Windows.Forms.Button();
            this.BTN_PAGAR = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Label();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.IVA = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tiendaDataSet1 = new Login_Tienda.TiendaDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventas_pruebasTableAdapter = new Login_Tienda.TiendaDataSetTableAdapters.ventas_pruebasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_AGREGAR
            // 
            this.BTN_AGREGAR.Location = new System.Drawing.Point(660, 111);
            this.BTN_AGREGAR.Name = "BTN_AGREGAR";
            this.BTN_AGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_AGREGAR.TabIndex = 37;
            this.BTN_AGREGAR.Text = "AGREGAR";
            this.BTN_AGREGAR.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR.Click += new System.EventHandler(this.BTN_AGREGAR_Click);
            // 
            // CANCELAR_VENTA
            // 
            this.CANCELAR_VENTA.Location = new System.Drawing.Point(951, 274);
            this.CANCELAR_VENTA.Name = "CANCELAR_VENTA";
            this.CANCELAR_VENTA.Size = new System.Drawing.Size(94, 38);
            this.CANCELAR_VENTA.TabIndex = 36;
            this.CANCELAR_VENTA.Text = "CANCELAR VENTA";
            this.CANCELAR_VENTA.UseVisualStyleBackColor = true;
            this.CANCELAR_VENTA.Click += new System.EventHandler(this.CANCELAR_VENTA_Click);
            // 
            // BTN_PAGAR
            // 
            this.BTN_PAGAR.Location = new System.Drawing.Point(855, 274);
            this.BTN_PAGAR.Name = "BTN_PAGAR";
            this.BTN_PAGAR.Size = new System.Drawing.Size(89, 38);
            this.BTN_PAGAR.TabIndex = 35;
            this.BTN_PAGAR.Text = "PAGAR";
            this.BTN_PAGAR.UseVisualStyleBackColor = true;
            this.BTN_PAGAR.Click += new System.EventHandler(this.BTN_PAGAR_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(926, 229);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 34;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(866, 232);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(42, 13);
            this.TOTAL.TabIndex = 33;
            this.TOTAL.Text = "TOTAL";
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(926, 185);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(100, 20);
            this.txtiva.TabIndex = 32;
            // 
            // IVA
            // 
            this.IVA.AutoSize = true;
            this.IVA.Location = new System.Drawing.Point(884, 185);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(24, 13);
            this.IVA.TabIndex = 31;
            this.IVA.Text = "IVA";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(926, 141);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "SUBTOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "VENTA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(16, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 205);
            this.dataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CATIDAD";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DESCRIPCION";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "IMPORTE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "SUBTOTAL";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IVA";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(412, 108);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRECIO VENTA";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(264, 108);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(16, 34);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 20;
            this.txtcodigo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtcodigo_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CODIGO";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(138, 108);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 39;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "CANTIDAD";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(686, 34);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(58, 20);
            this.txtexistencia.TabIndex = 40;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(538, 114);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 20);
            this.txtimporte.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "IMPORTE";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(538, 34);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(58, 20);
            this.txtc.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "txtc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "txtexcistencia";
            // 
            // tiendaDataSet1
            // 
            this.tiendaDataSet1.DataSetName = "TiendaDataSet";
            this.tiendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ventas_pruebas";
            this.bindingSource1.DataSource = this.tiendaDataSet1;
            // 
            // ventas_pruebasTableAdapter
            // 
            this.ventas_pruebasTableAdapter.ClearBeforeFill = true;
            // 
            // prueba_de_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 396);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_AGREGAR);
            this.Controls.Add(this.CANCELAR_VENTA);
            this.Controls.Add(this.BTN_PAGAR);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label7);
            this.Name = "prueba_de_venta";
            this.Text = "prueba de venta";
            this.Load += new System.EventHandler(this.eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_AGREGAR;
        private System.Windows.Forms.Button CANCELAR_VENTA;
        private System.Windows.Forms.Button BTN_PAGAR;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private TiendaDataSet tiendaDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TiendaDataSetTableAdapters.ventas_pruebasTableAdapter ventas_pruebasTableAdapter;
    }
}