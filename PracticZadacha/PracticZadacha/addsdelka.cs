using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticZadacha
{
    public partial class addsdelka : Form
    {
        public addsdelka()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
}

        private void button3_Click(object sender, EventArgs e)
        {
            int x=0,y=0,z=0;
            if(textBox1.Text == "1")
            {
                x = x + 700;
            }
            else if (textBox1.Text == "2")
            {
                x = x + 500;
            }
            else if (textBox1.Text == "3")
            {
                x = x + 800;
            }
            else if (textBox1.Text == "4")
            {
                x = x + 300;
            }
            else if (textBox4.Text == "5")
            {
                y = y + 100;
            }
            else
            
                MessageBox.Show("Комнаты под таким номером нет! ");
            



            /////////////////////////////////////////
             if (textBox4.Text == "1")
            {
                y = y + 100;
            }
            else if (textBox4.Text == "3")
            {
                y = y + 40;
            }
            else if (textBox4.Text == "4")
            {
                y = y + 500;
            }
            else if (textBox4.Text == "5")
            {
                y = y + 1500;
            }
            else if(textBox4.Text == "5")
            {
                y = y + 200;
            }
            else if (textBox4.Text == "6")
            {
                y = y + 150;
            }
            else
            {
                MessageBox.Show("введены не верные параметры ");
            }

            z = x + y;
            /////////////////////////////////////////////////
            if (textBox7.Text == "1")
            {
                label9.Text = Convert.ToString(z) + " Рублей";
            }
           else if (textBox7.Text == "2")
            {
                z = z * 2;
                label9.Text = Convert.ToString(z) + " Рублей";
            }
            else if (textBox7.Text == "3")
            {
                z = z * 3;
                label9.Text = Convert.ToString(z) + " Рублей";
            }
            else if (textBox7.Text == "4")
            {
                z = z * 4;
                label9.Text = Convert.ToString(z) + " Рублей";
            }
            else if (textBox7.Text == "5")
            {
                z = z * 5;
                label9.Text = Convert.ToString(z) + " Рублей";
            }
            else 
            {
                MessageBox.Show("введены не верные параметры или аренда больше 5 дней");
            }


        }
    }
    }

