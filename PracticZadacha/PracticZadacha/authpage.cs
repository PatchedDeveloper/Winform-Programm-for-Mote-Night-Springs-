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
    public partial class authpage : Form
    {
        public authpage()
        {
            InitializeComponent();
        }
        string l = "admin",p = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == l) & (maskedTextBox1.Text == p))
            {
                Hide();
                Form1 window = new Form1();
                window.ShowDialog();

            }
            else
                MessageBox.Show("Введён не верный пароль или логин");
        }
    }
}
