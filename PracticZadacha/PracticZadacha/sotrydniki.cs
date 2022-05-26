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
    public partial class sotrydniki : Form
    {
        public sotrydniki()
        {
            InitializeComponent();
        }

        private void sotrydnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrydnikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void sotrydniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.sotrydniki". При необходимости она может быть перемещена или удалена.
            this.sotrydnikiTableAdapter.Fill(this.danyakDataSet.sotrydniki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sotrydnikiBindingSource.Filter = "[NameSot] LIKE'" + textBox1.Text + "%'"; // search for grid data
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrydnikiBindingSource.Filter = "[FamSot] LIKE'" + textBox2.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sotrydnikiBindingSource.Filter = "[TelephoneSot] LIKE'" + textBox3.Text + "%'"; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sotrydnikiBindingSource.Filter = string.Empty;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            addsotrydnik window = new addsotrydnik();
            window.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sotrydnikiBindingSource.Filter = "[ObrazovanieSot] LIKE'" + "Общее" + "%'"; // search for grid data
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sotrydnikiBindingSource.Filter = "[ObrazovanieSot] LIKE'" + "Профессиональное" + "%'"; // search for grid data
                checkBox1.Checked = false;
            }
        }
    }
}
