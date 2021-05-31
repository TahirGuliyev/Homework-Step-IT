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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSave.Enabled = false;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxAge.Text) > 0)
            {
                buttonSave.Enabled = true;
            }
            else {
                MessageBox.Show("Age incorrect!");
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            User user = new User(textBoxName.Text, textBoxLastName.Text, int.Parse(textBoxAge.Text), textBoxGender.Text, textBoxFavouriteFilm.Text, textBoxFavouriteCar.Text);
            using (StreamWriter writer = new StreamWriter("users.txt"))
            {
                writer.WriteLine(user.ToString());
            }
        }
    }
}
