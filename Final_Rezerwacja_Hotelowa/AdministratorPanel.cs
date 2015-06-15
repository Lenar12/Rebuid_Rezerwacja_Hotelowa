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
            refresher();
        }
        void refresher()
        {
            var data = from c in dc.Pokojs select new { c.id_pokoj, c.zdjecie };
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //MessageBox.Show(openFileDialog1.FileName);
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Pokoj room = (from c in dc.Pokojs where c.id_pokoj.ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString() select c).First();
            room.zdjecie = openFileDialog1.FileName;
            dc.SubmitChanges();
            refresher();
            
        }
 }
}
