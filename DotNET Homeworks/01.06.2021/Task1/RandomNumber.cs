using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class RandomNumber : Form
    {
        int number = new Random().Next(1, 2000);
        int count = 0;
        public RandomNumber()
        {
            InitializeComponent();
        }

        private void buttonYoxla_Click(object sender, EventArgs e)
        {
            count++;
            if (int.Parse(textBoxNumber.Text) > number) {
                MessageBox.Show("Daxil etdiyiniz eded komputerin fikrinde tutdugu ededden boyukdur!");
            }
            if (int.Parse(textBoxNumber.Text) == number) { 
            MessageBox.Show($"Ededi {count} addim sonra duzgun texmin etdiniz! Eded: {number}");
            }
            if (int.Parse(textBoxNumber.Text) < number)
            {
                MessageBox.Show("Daxil etdiyiniz eded komputerin fikrinde tutdugu ededden kicikdir!");
            }
        }
    }
}
