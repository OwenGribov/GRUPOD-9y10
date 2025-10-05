namespace GRUPOD_9y10
{
    partial class ConsultarCCT
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
            button1 = new Button();
            lblCliente = new Label();
            txtEmpresa = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 50);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(38, 54);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(90, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Buscar Empresa";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(152, 50);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Location = new Point(30, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 339);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro Factura";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 106);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Cuit Empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Razon Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 192);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "Direccion Empresa";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Registro de Factura";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label lblCliente;
        private TextBox txtEmpresa;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}