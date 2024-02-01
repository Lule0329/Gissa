using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int nummer;
        int guesses = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            guesses += 1;
            if (guess == nummer)
            {
                MessageBox.Show("Du gissade rätt efter " + guesses.ToString() + " försök");
                nummer = rng.Next(1, 21);
                guesses = 0;
            }
            else if (guess > nummer)
            {
                MessageBox.Show("För högt");
            }
            else if (guess < nummer)
            {
                MessageBox.Show("För lågt");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nummer = rng.Next(1, 21);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = nummer.ToString();
        }
    }
}
