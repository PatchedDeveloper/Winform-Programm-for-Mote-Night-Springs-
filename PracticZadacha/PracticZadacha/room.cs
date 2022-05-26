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
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }

        private void komnatanomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.komnatanomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void room_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.Typenomera". При необходимости она может быть перемещена или удалена.
            this.typenomeraTableAdapter.Fill(this.danyakDataSet.Typenomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.komnatanomer". При необходимости она может быть перемещена или удалена.
            this.komnatanomerTableAdapter.Fill(this.danyakDataSet.komnatanomer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            komnatanomerBindingSource.Filter = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                komnatanomerBindingSource.Filter = "[krovaty] LIKE'" + 1 + "%'"; // search for grid data
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
              if (checkBox2.Checked)
            {
                komnatanomerBindingSource.Filter = "[krovaty] LIKE'" + 2 + "%'"; // search for grid data
                checkBox1.Checked = false;
            }
        }
    }
}
