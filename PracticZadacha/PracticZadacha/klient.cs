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
    public partial class klient : Form
    {
        public klient()
        {
            InitializeComponent();
        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.danyakDataSet.klient);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            klientBindingSource.Filter = "[documentsKl] LIKE'" + textBox3.Text + "%'"; // search for grid data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            klientBindingSource.Filter = "[NameKl] LIKE'" + textBox1.Text + "%'"; // search for grid data
        }

        private void button2_Click(object sender, EventArgs e)
        {
            klientBindingSource.Filter = "[FamKl] LIKE'" + textBox2.Text + "%'"; // search for grid data
        }

        private void button5_Click(object sender, EventArgs e)
        {
            klientBindingSource.Filter = string.Empty;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            addclienty window = new addclienty();
            window.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                klientBindingSource.Filter = "[Baby] LIKE'" + "Да" + "%'"; // search for grid data
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                klientBindingSource.Filter = "[Baby] LIKE'" + "Нет" + "%'"; // search for grid data
                checkBox1.Checked = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
