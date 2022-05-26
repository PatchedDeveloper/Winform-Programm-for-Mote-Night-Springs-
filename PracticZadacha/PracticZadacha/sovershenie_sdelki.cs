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
    public partial class sovershenie_sdelki : Form
    {
        public sovershenie_sdelki()
        {
            InitializeComponent();
        }

        private void sdelkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sdelkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void sovershenie_sdelki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.sdelka". При необходимости она может быть перемещена или удалена.
            this.sdelkaTableAdapter.Fill(this.danyakDataSet.sdelka);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sdelkaBindingSource.Filter = "day=\'" + textBox1.Text + "\'"; // search for grid data
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sdelkaBindingSource.Filter = "summa=\'" + textBox2.Text + "\'"; // search for grid data
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sdelkaBindingSource.Filter = string.Empty;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addsdelka window = new addsdelka();
            window.ShowDialog();
        }
    }


}
