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
    public partial class dopyskygi : Form
    {
        public dopyskygi()
        {
            InitializeComponent();
        }

        private void dopyslygiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dopyslygiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void dopyskygi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.dopyslygi". При необходимости она может быть перемещена или удалена.
            this.dopyslygiTableAdapter.Fill(this.danyakDataSet.dopyslygi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oformleniedopyslygi window = new oformleniedopyslygi();
            window.ShowDialog();
        }
    }
}
