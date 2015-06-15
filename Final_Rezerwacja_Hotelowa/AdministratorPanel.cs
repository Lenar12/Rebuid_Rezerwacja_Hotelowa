using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Rezerwacja_Hotelowa
{
    public partial class AdministratorPanel : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public AdministratorPanel()
        {
            InitializeComponent();
            var data = from c in dc.Pokojs select c;
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }
    }
}
