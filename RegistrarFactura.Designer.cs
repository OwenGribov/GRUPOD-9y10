namespace GRUPOD_9y10
{
    partial class RegistrarFactura
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS FACTURA";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 60);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 60);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 190);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Factura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 190);
            label4.Name = "label4";
            label4.Size = new Size(185, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Vencimiemto de Factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 319);
            label5.Name = "label5";
            label5.Size = new Size(186, 15);
            label5.TabIndex = 4;
            label5.Text = "Importe Total de Factura (con IVA)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 319);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado de Factura";
            // 
            // button1
            // 
            button1.Location = new Point(327, 444);
            button1.Name = "button1";
            button1.Size = new Size(269, 57);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR FACTURA";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(526, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(526, 231);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(526, 359);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 23);
            comboBox2.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 585);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Alta de Facturas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ImageList imageList1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
    }
}