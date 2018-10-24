using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "P  E  T     T  H  E    D  O  G";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while (button7.Bottom > button1.Bottom)
            {
                button7.Top -= 10;
            }
            label1.Text = "N  O  T     T  H  E    T  A  I  L";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "W  A  G     W  A  G    W  A  G";
            int distance = button7.Top / 2;
            for (int i = 0; i < 1000; i++)
            {
                button7.Top += distance;
                button7.Top += distance;
                button7.Top -= distance;
                button7.Top -= distance;
            }
            label1.Text = "P  E  T     T  H  E    D  O  G";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "W  A  G     W  A  G    W  A  G";
            int distance = button7.Top / 2;
            for (int i = 0; i < 1000; i++)
            {
                button7.Top += distance;
                button7.Top += distance;
                button7.Top -= distance;
                button7.Top -= distance;
            }
            label1.Text = "P  E  T     T  H  E    D  O  G";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(button7.Bottom > button1.Bottom)
            {
                button7.Top -= 10;
            }
            label1.Text = "N  O  T     T  H  E    L  E  G";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (button7.Bottom > button1.Bottom)
            {
                button7.Top -= 10;
            }
            label1.Text = "N  O  T     T  H  E    L  E  G";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (button7.Bottom > button1.Bottom)
            {
                button7.Top -= 10;
            }
            label1.Text = "N  O  T     T  H  E    L  E  G";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (button7.Bottom > button1.Bottom)
            {
                button7.Top -= 10;
            }
            label1.Text = "N  O  T     T  H  E    L  E  G";
        }
    }
}
