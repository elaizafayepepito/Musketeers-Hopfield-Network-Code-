using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musketeers_Hopfield_Network_Code
{
    public partial class Form1 : Form
    {
        int[] array = new int[9];
        int[] outputArray = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                button1.BackColor = Color.Black;
                array[0] = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender == button2)
            {
                button2.BackColor = Color.Black;
                array[1] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender == button3)
            {
                button3.BackColor = Color.Black;
                array[2] = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sender == button4)
            {
                button4.BackColor = Color.Black;
                array[3] = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sender == button5)
            {
                button5.BackColor = Color.Black;
                array[4] = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sender == button6)
            {
                button6.BackColor = Color.Black;
                array[5] = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sender == button7)
            {
                button7.BackColor = Color.Black;
                array[6] = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sender == button8)
            {
                button8.BackColor = Color.Black;
                array[7] = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sender == button9)
            {
                button9.BackColor = Color.Black;
                array[8] = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    array[i] = -1;
            }
            int[] wt1 = new int[] { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
            int[] wt2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
            int[] wt3 = new int[] { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
            int[] wt4 = new int[] { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
            int[] wt5 = new int[] { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
            int[] wt6 = new int[] { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
            int[] wt7 = new int[] { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
            int[] wt8 = new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
            int[] wt9 = new int[] { 2, 0, 2, -2, -2, -2, 2, 0, 0 };

            Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);

            h1.Activation(array);

            for (int i = 0; i < 9; i++)
            {
                outputArray[i] = h1.output[i];
                Button btn = this.Controls["button" + (i + 11)] as Button;
                if (btn != null)
                {
                    if (outputArray[i] == 1)
                    {
                        btn.BackColor = Color.Black;
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Array.Clear(array, 0, array.Length);
            Array.Clear(outputArray, 0, outputArray.Length);
            ResetButtonProperties(button1);
            ResetButtonProperties(button2);
            ResetButtonProperties(button3);
            ResetButtonProperties(button4);
            ResetButtonProperties(button5);
            ResetButtonProperties(button6);
            ResetButtonProperties(button7);
            ResetButtonProperties(button8);
            ResetButtonProperties(button9);
            ResetButtonProperties(button11);
            ResetButtonProperties(button12);
            ResetButtonProperties(button13);
            ResetButtonProperties(button14);
            ResetButtonProperties(button15);
            ResetButtonProperties(button16);
            ResetButtonProperties(button17);
            ResetButtonProperties(button18);
            ResetButtonProperties(button19);
        }

        private void ResetButtonProperties(Button button)
        {
            button.ResetBackColor();
        }
    }
}