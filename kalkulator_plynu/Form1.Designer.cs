namespace kalkulator_plynu
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(459, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(276, 159);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "obliczyć wynik";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 34);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 5;
            label1.Text = "pojemność naczynia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 141);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 6;
            label2.Text = "procentowa zawartość substancji";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 86);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "liczba sztuk naczyń";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(276, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 34);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 10;
            label4.Text = "łączna objętość płynu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 84);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 11;
            label5.Text = "objętość czystej substancji";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(459, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 34);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 13;
            label6.Text = "wybierz naczynie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 86);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 14;
            label7.Text = "wybierz roztwor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
    }
}
