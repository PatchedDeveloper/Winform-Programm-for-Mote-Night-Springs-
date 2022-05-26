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
    public partial class Form1 : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 40;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_programm window = new about_programm();
            window.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klient window = new klient();
            window.ShowDialog();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sotrydniki window = new sotrydniki();
            window.ShowDialog();
        }

        private void дополнительныеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dopyskygi window = new dopyskygi();
            window.ShowDialog();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            room window = new room();
            window.ShowDialog();
        }

        private void сделкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sovershenie_sdelki window = new sovershenie_sdelki();
            window.ShowDialog();
        }

        private void журналыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
