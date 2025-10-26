// Updated designer code with improved layout and styling
using System.Windows.Forms;
using System.Drawing;

namespace kalkulator_plynu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonOblicz;
        private TextBox textBoxIl;
        private Label labelPojemnosc;
        private Label labelIlosc;
        private TextBox textTotalPl;
        private TextBox textTotalSub;
        private Label labelTotalPl;
        private Label labelTotalSub;
        private ComboBox comboRoztwor;
        private ComboBox comboNaczynie;
        private Label labelWyborRoztwor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOblicz = new Button();
            this.textBoxIl = new TextBox();
            this.labelPojemnosc = new Label();
            this.labelIlosc = new Label();
            this.textTotalPl = new TextBox();
            this.textTotalSub = new TextBox();
            this.labelTotalPl = new Label();
            this.labelTotalSub = new Label();
            this.comboRoztwor = new ComboBox();
            this.comboNaczynie = new ComboBox();
            this.labelWyborRoztwor = new Label();
            this.SuspendLayout();

            // Form Settings
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Płynu";
            this.BackColor = Color.WhiteSmoke;

            // Button Oblicz
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonOblicz.Size = new Size(120, 40);
            this.buttonOblicz.Location = new Point(320, 220);
            this.buttonOblicz.BackColor = Color.LightSkyBlue;
            this.buttonOblicz.FlatStyle = FlatStyle.Flat;
            this.buttonOblicz.Click += new System.EventHandler(this.button1_Click);

            // ComboBox Naczynie
            this.comboNaczynie.Location = new Point(50, 70);
            this.comboNaczynie.Size = new Size(150, 28);
            this.comboNaczynie.DropDownStyle = ComboBoxStyle.DropDownList;

            // Label Pojemnosc
            this.labelPojemnosc.Text = "Pojemność naczynia";
            this.labelPojemnosc.Location = new Point(50, 40);
            this.labelPojemnosc.AutoSize = true;

            // ComboBox Roztwor
            this.comboRoztwor.Location = new Point(50, 150);
            this.comboRoztwor.Size = new Size(150, 28);
            this.comboRoztwor.DropDownStyle = ComboBoxStyle.DropDownList;

            // Label Roztwor
            this.labelWyborRoztwor.Text = "Wybierz roztwór";
            this.labelWyborRoztwor.Location = new Point(50, 120);
            this.labelWyborRoztwor.AutoSize = true;

            // TextBox Ilosc
            this.textBoxIl.Location = new Point(50, 230);
            this.textBoxIl.Size = new Size(150, 27);

            // Label Ilosc
            this.labelIlosc.Text = "Liczba naczyń";
            this.labelIlosc.Location = new Point(50, 200);
            this.labelIlosc.AutoSize = true;

            // Label Total Pl
            this.labelTotalPl.Text = "Łączna objętość płynu (ml)";
            this.labelTotalPl.Location = new Point(550, 70);
            this.labelTotalPl.AutoSize = true;

            // TextBox Total Pl
            this.textTotalPl.Location = new Point(550, 100);
            this.textTotalPl.Size = new Size(150, 27);
            this.textTotalPl.ReadOnly = true;
            // Label Total Sub
            this.labelTotalSub.Text = "Objętość substancji (ml)";
            this.labelTotalSub.Location = new Point(550, 160);
            this.labelTotalSub.AutoSize = true;

            // TextBox Total Sub
            this.textTotalSub.Location = new Point(550, 190);
            this.textTotalSub.Size = new Size(150, 27);
            this.textTotalSub.ReadOnly = true;

            // Add Controls
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.comboNaczynie);
            this.Controls.Add(this.labelPojemnosc);
            this.Controls.Add(this.comboRoztwor);
            this.Controls.Add(this.labelWyborRoztwor);
            this.Controls.Add(this.textBoxIl);
            this.Controls.Add(this.labelIlosc);
            this.Controls.Add(this.textTotalPl);
            this.Controls.Add(this.labelTotalPl);
            this.Controls.Add(this.textTotalSub);
            this.Controls.Add(this.labelTotalSub);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}