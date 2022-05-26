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
    public partial class oformleniedopyslygi : Form
    {
        public oformleniedopyslygi()
        {
            InitializeComponent();
        }

        private void dopyslygikogdaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dopyslygikogdaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void oformleniedopyslygi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.dopyslygikogda". При необходимости она может быть перемещена или удалена.
            this.dopyslygikogdaTableAdapter.Fill(this.danyakDataSet.dopyslygikogda);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adddopyslyga window = new adddopyslyga();
            window.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dopyslygikogdaBindingSource.Filter = "id_yslygi=\'" + textBox1.Text + "\'"; // search for grid data
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dopyslygikogdaBindingSource.Filter = "summa=\'" + textBox2.Text + "\'"; // search for grid data   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dopyslygikogdaBindingSource.Filter = string.Empty;
            textBox1.Text = "";
            textBox2.Text = "";
         
        }
    }
}
