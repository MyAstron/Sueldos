namespace Sueldos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.udLaborado = new System.Windows.Forms.DomainUpDown();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResultLaborado = new System.Windows.Forms.TextBox();
            this.txtResultSueldo = new System.Windows.Forms.TextBox();
            this.txtResultCategoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos del Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 35);
            this.label9.TabIndex = 14;
            this.label9.Text = " Sueldos Plantilla ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Años Laborados:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(109, 76);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(262, 23);
            this.txtEmpleado.TabIndex = 17;
            // 
            // udLaborado
            // 
            this.udLaborado.Location = new System.Drawing.Point(144, 105);
            this.udLaborado.Name = "udLaborado";
            this.udLaborado.Size = new System.Drawing.Size(104, 23);
            this.udLaborado.TabIndex = 18;
            this.udLaborado.Text = "0";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbCategoria.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbCategoria.Location = new System.Drawing.Point(109, 134);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 23);
            this.cmbCategoria.Sorted = true;
            this.cmbCategoria.TabIndex = 19;
            this.cmbCategoria.Text = "- Selecciona -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Categoria:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(279, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(279, 134);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sueldo Total:";
            // 
            // txtResultEmpleado
            // 
            this.txtResultEmpleado.Enabled = false;
            this.txtResultEmpleado.Location = new System.Drawing.Point(110, 197);
            this.txtResultEmpleado.Name = "txtResultEmpleado";
            this.txtResultEmpleado.Size = new System.Drawing.Size(262, 23);
            this.txtResultEmpleado.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Años Laborados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(50, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Horas Laborales Normales";
            // 
            // txtResultLaborado
            // 
            this.txtResultLaborado.Enabled = false;
            this.txtResultLaborado.Location = new System.Drawing.Point(144, 225);
            this.txtResultLaborado.Name = "txtResultLaborado";
            this.txtResultLaborado.Size = new System.Drawing.Size(105, 23);
            this.txtResultLaborado.TabIndex = 29;
            this.txtResultLaborado.Text = "0";
            // 
            // txtResultSueldo
            // 
            this.txtResultSueldo.Enabled = false;
            this.txtResultSueldo.Location = new System.Drawing.Point(149, 255);
            this.txtResultSueldo.Name = "txtResultSueldo";
            this.txtResultSueldo.Size = new System.Drawing.Size(101, 23);
            this.txtResultSueldo.TabIndex = 30;
            // 
            // txtResultCategoria
            // 
            this.txtResultCategoria.Enabled = false;
            this.txtResultCategoria.Location = new System.Drawing.Point(275, 246);
            this.txtResultCategoria.Name = "txtResultCategoria";
            this.txtResultCategoria.Size = new System.Drawing.Size(96, 23);
            this.txtResultCategoria.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(279, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Categoria:";
            // 
            // buttonBindingSource
            // 
            this.buttonBindingSource.DataSource = typeof(System.Windows.Forms.Button);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(124, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Q.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 295);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtResultCategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultSueldo);
            this.Controls.Add(this.txtResultLaborado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.udLaborado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "..:: Suedos ::..";
            ((System.ComponentModel.ISupportInitialize)(this.buttonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label9;
        private Label label2;
        private Label label3;
        private TextBox txtEmpleado;
        private DomainUpDown udLaborado;
        private Label label4;
        private Button btnCalcular;
        private Button btnNuevo;
        private Label label5;
        private TextBox txtResultEmpleado;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtResultLaborado;
        private TextBox txtResultSueldo;
        private TextBox txtResultCategoria;
        private Label label10;
        private BindingSource buttonBindingSource;
        private Label label11;
        private ComboBox cmbCategoria;
    }
}