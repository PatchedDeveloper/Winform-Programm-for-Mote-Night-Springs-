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
    public partial class klients : Form
    {
        public klients()
        {
            InitializeComponent();
        }

        private void bronBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bronBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.danyakDataSet);

        }

        private void klients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.danyakDataSet.klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danyakDataSet.bron". При необходимости она может быть перемещена или удалена.
            this.bronTableAdapter.Fill(this.danyakDataSet.bron);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
