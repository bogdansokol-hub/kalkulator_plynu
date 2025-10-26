

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace kalkulator_plynu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
      
        public void InitializeComboBoxes()
        {
         
            comboNaczynie.DataSource = new BindingSource(Kakulator.volumeMapping, null);
            comboNaczynie.DisplayMember = "Key";
            comboNaczynie.ValueMember = "Value";

            comboRoztwor.DataSource = new BindingSource(Kakulator.keySolution, null);
            comboRoztwor.DisplayMember = "Key";
            comboRoztwor.ValueMember = "Value";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboNaczynie.SelectedValue == null || comboRoztwor.SelectedValue == null)
            {
                MessageBox.Show("Wybierz naczynie i roztwór!");
                return;
            }

            if (!int.TryParse(textBoxIl.Text, out int ilosc))
            {
                MessageBox.Show("Podaj poprawną ilość!");
                return;
            }

            int pojemnosc = (int)comboNaczynie.SelectedValue;
            int procent = (int)comboRoztwor.SelectedValue;

            double totalPlyn = pojemnosc * ilosc;
            double totalSubs = totalPlyn * procent / 100.0;

            textTotalPl.Text = totalPlyn.ToString() + " ml";
            textTotalSub.Text = totalSubs.ToString()+ " ml";
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }


    }

}
