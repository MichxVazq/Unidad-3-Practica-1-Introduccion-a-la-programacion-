namespace Practica_16
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 38);
            label1.Name = "label1";
            label1.Size = new Size(407, 40);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato un número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 78);
            label2.Name = "label2";
            label2.Size = new Size(394, 40);
            label2.TabIndex = 1;
            label2.Text = "determina si es par o impar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 118);
            label3.Name = "label3";
            label3.Size = new Size(235, 40);
            label3.TabIndex = 2;
            label3.Text = "y divisible por 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(397, 40);
            label4.TabIndex = 3;
            label4.Text = "Ingresa Número Cualquiera";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(424, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 50);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(59, 299);
            button1.Name = "button1";
            button1.Size = new Size(208, 64);
            button1.TabIndex = 5;
            button1.Text = "Determinar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(505, 299);
            button2.Name = "button2";
            button2.Size = new Size(208, 64);
            button2.TabIndex = 6;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
