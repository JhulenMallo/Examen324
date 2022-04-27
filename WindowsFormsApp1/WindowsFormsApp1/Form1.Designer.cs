
namespace WindowsFormsApp1
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
            this.textBox1Delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3CI = new System.Windows.Forms.Label();
            this.label3Nombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5depto = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2Adicionar = new System.Windows.Forms.Button();
            this.label3Fecha = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.Size = new System.Drawing.Size(633, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1Delete
            // 
            this.textBox1Delete.Location = new System.Drawing.Point(52, 406);
            this.textBox1Delete.Name = "textBox1Delete";
            this.textBox1Delete.Size = new System.Drawing.Size(100, 22);
            this.textBox1Delete.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.488F);
            this.label1.Location = new System.Drawing.Point(135, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar Persona";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.488F);
            this.label2.Location = new System.Drawing.Point(96, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adicionar o Editar Persona";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label3CI
            // 
            this.label3CI.AutoSize = true;
            this.label3CI.Location = new System.Drawing.Point(52, 85);
            this.label3CI.Name = "label3CI";
            this.label3CI.Size = new System.Drawing.Size(20, 16);
            this.label3CI.TabIndex = 6;
            this.label3CI.Text = "CI";
            // 
            // label3Nombre
            // 
            this.label3Nombre.AutoSize = true;
            this.label3Nombre.Location = new System.Drawing.Point(52, 132);
            this.label3Nombre.Name = "label3Nombre";
            this.label3Nombre.Size = new System.Drawing.Size(118, 16);
            this.label3Nombre.TabIndex = 8;
            this.label3Nombre.Text = "Nombre Completo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label5depto
            // 
            this.label5depto.AutoSize = true;
            this.label5depto.Location = new System.Drawing.Point(52, 236);
            this.label5depto.Name = "label5depto";
            this.label5depto.Size = new System.Drawing.Size(94, 16);
            this.label5depto.TabIndex = 12;
            this.label5depto.Text = "Departamento";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // button2Adicionar
            // 
            this.button2Adicionar.Location = new System.Drawing.Point(67, 300);
            this.button2Adicionar.Name = "button2Adicionar";
            this.button2Adicionar.Size = new System.Drawing.Size(142, 23);
            this.button2Adicionar.TabIndex = 13;
            this.button2Adicionar.Text = "Adicionar Persona";
            this.button2Adicionar.UseVisualStyleBackColor = true;
            this.button2Adicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3Fecha
            // 
            this.label3Fecha.AutoSize = true;
            this.label3Fecha.Location = new System.Drawing.Point(50, 182);
            this.label3Fecha.Name = "label3Fecha";
            this.label3Fecha.Size = new System.Drawing.Size(136, 16);
            this.label3Fecha.TabIndex = 14;
            this.label3Fecha.Text = "Fecha de Nacimiento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Editar Persona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(279, 258);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3Fecha);
            this.Controls.Add(this.button2Adicionar);
            this.Controls.Add(this.label5depto);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3Nombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3CI);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Editar Persona";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3CI;
        private System.Windows.Forms.Label label3Nombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5depto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2Adicionar;
        private System.Windows.Forms.Label label3Fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
    }
}

