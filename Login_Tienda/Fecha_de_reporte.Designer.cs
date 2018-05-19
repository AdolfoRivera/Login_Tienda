namespace Login_Tienda
{
    partial class Fecha_de_reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fecha_de_reporte));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_genrar_reporte = new System.Windows.Forms.Button();
            this.dateTimePicker_fecha_reporte = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // button_genrar_reporte
            // 
            this.button_genrar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_genrar_reporte.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_genrar_reporte.Location = new System.Drawing.Point(198, 11);
            this.button_genrar_reporte.Name = "button_genrar_reporte";
            this.button_genrar_reporte.Size = new System.Drawing.Size(96, 27);
            this.button_genrar_reporte.TabIndex = 3;
            this.button_genrar_reporte.Text = "Generar";
            this.button_genrar_reporte.UseVisualStyleBackColor = true;
            this.button_genrar_reporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_fecha_reporte
            // 
            this.dateTimePicker_fecha_reporte.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_fecha_reporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fecha_reporte.Location = new System.Drawing.Point(76, 12);
            this.dateTimePicker_fecha_reporte.Name = "dateTimePicker_fecha_reporte";
            this.dateTimePicker_fecha_reporte.Size = new System.Drawing.Size(103, 26);
            this.dateTimePicker_fecha_reporte.TabIndex = 4;
            // 
            // Fecha_de_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 48);
            this.Controls.Add(this.dateTimePicker_fecha_reporte);
            this.Controls.Add(this.button_genrar_reporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fecha_de_reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_genrar_reporte;
        public System.Windows.Forms.DateTimePicker dateTimePicker_fecha_reporte;
    }
}