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
            button1 = new Button();
            textBoxIl = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textTotalPl = new TextBox();
            textTotalSub = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboRoztwor = new ComboBox();
            label7 = new Label();
            comboNaczynie = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(262, 102);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "obliczyć wynik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxIl
            // 
            textBoxIl.Location = new Point(78, 156);
            textBoxIl.Name = "textBoxIl";
            textBoxIl.Size = new Size(100, 23);
            textBoxIl.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 138);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "liczba sztuk naczyń";
            // 
            // textTotalPl
            // 
            textTotalPl.Location = new Point(421, 70);
            textTotalPl.Name = "textTotalPl";
            textTotalPl.Size = new Size(100, 23);
            textTotalPl.TabIndex = 8;
            // 
            // textTotalSub
            // 
            textTotalSub.Location = new Point(421, 120);
            textTotalSub.Name = "textTotalSub";
            textTotalSub.Size = new Size(100, 23);
            textTotalSub.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 52);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 10;
            label4.Text = "łączna objętość płynu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 102);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 11;
            label5.Text = "objętość czystej substancji";
            // 
            // comboRoztwor
            // 
            comboRoztwor.FormattingEnabled = true;
            comboRoztwor.Location = new Point(78, 103);
            comboRoztwor.Name = "comboRoztwor";
            comboRoztwor.Size = new Size(121, 23);
            comboRoztwor.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 85);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 14;
            label7.Text = "wybierz roztwor";
            // 
            // comboNaczynie
            // 
            comboNaczynie.FormattingEnabled = true;
            comboNaczynie.Location = new Point(78, 52);
            comboNaczynie.Name = "comboNaczynie";
            comboNaczynie.Size = new Size(121, 23);
            comboNaczynie.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(comboNaczynie);
            Controls.Add(label7);
            Controls.Add(comboRoztwor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textTotalSub);
            Controls.Add(textTotalPl);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxIl);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBoxIl;
        private Label label1;
        private Label label3;
        private TextBox textTotalPl;
        private TextBox textTotalSub;
        private Label label4;
        private Label label5;
        private ComboBox comboRoztwor;
        private Label label7;
        private ComboBox comboNaczynie;
    }
}
