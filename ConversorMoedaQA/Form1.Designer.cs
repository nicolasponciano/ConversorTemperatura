namespace ConversorMoedaQA
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
            label1 = new Label();
            label2 = new Label();
            rbFahrenheit = new RadioButton();
            rbKelvin = new RadioButton();
            txtConvertido = new TextBox();
            txtValor = new TextBox();
            panel1 = new Panel();
            rbCelsius = new RadioButton();
            label3 = new Label();
            btnConverter = new Button();
            btnLimpar = new Button();
            btnAlterarTema = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(339, 54);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor em Celsius°C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(350, 201);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 1;
            label2.Text = "Valor Convertido:";
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbFahrenheit.Location = new Point(35, 73);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(108, 23);
            rbFahrenheit.TabIndex = 2;
            rbFahrenheit.TabStop = true;
            rbFahrenheit.Text = "Fahrenheit F°";
            rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            rbKelvin.AutoSize = true;
            rbKelvin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbKelvin.Location = new Point(35, 102);
            rbKelvin.Name = "rbKelvin";
            rbKelvin.Size = new Size(80, 23);
            rbKelvin.TabIndex = 3;
            rbKelvin.TabStop = true;
            rbKelvin.Text = "Kelvin K°";
            rbKelvin.UseVisualStyleBackColor = true;
            // 
            // txtConvertido
            // 
            txtConvertido.Enabled = false;
            txtConvertido.Location = new Point(339, 231);
            txtConvertido.Name = "txtConvertido";
            txtConvertido.Size = new Size(141, 23);
            txtConvertido.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(339, 78);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(141, 23);
            txtValor.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(rbCelsius);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rbFahrenheit);
            panel1.Controls.Add(rbKelvin);
            panel1.Location = new Point(32, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 145);
            panel1.TabIndex = 6;
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbCelsius.Location = new Point(35, 45);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(87, 23);
            rbCelsius.TabIndex = 8;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius C°";
            rbCelsius.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 21);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 7;
            label3.Text = "Valores:";
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConverter.Location = new Point(307, 321);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(95, 33);
            btnConverter.TabIndex = 7;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(146, 321);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 33);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAlterarTema
            // 
            btnAlterarTema.Location = new Point(31, 25);
            btnAlterarTema.Name = "btnAlterarTema";
            btnAlterarTema.Size = new Size(43, 26);
            btnAlterarTema.TabIndex = 10;
            btnAlterarTema.Text = "Tema";
            btnAlterarTema.UseVisualStyleBackColor = true;
            btnAlterarTema.Click += btnAlterarTema_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 392);
            Controls.Add(btnAlterarTema);
            Controls.Add(btnLimpar);
            Controls.Add(btnConverter);
            Controls.Add(txtValor);
            Controls.Add(txtConvertido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rbFahrenheit;
        private RadioButton rbKelvin;
        private TextBox txtConvertido;
        private TextBox txtValor;
        private Panel panel1;
        private Label label3;
        private Button btnConverter;
        private Button btnLimpar;
        private RadioButton rbCelsius;
        private Button btnAlterarTema;
    }
}