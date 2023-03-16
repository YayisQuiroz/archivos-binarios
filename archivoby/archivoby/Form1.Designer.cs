namespace archivoby
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guardar = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.NOM = new System.Windows.Forms.TextBox();
            this.EDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(432, 27);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(82, 29);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(431, 72);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(83, 34);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(187, 36);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(123, 20);
            this.NOM.TabIndex = 3;
            // 
            // EDD
            // 
            this.EDD.Location = new System.Drawing.Point(187, 80);
            this.EDD.Name = "EDD";
            this.EDD.Size = new System.Drawing.Size(134, 20);
            this.EDD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EDAD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDD);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.TextBox EDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

