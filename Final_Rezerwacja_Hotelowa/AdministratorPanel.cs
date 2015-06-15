using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            var query = from c in dc.Pokojs select c;
            dataGridView1.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            //string i = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //Pokoj room= (from c in dc.Pokojs where c.id_pokoj.ToString()==i select c).First();
            //room.zdjecie = SelectedPath.ToString();
           // dc.SubmitChanges();
            //refresher();
        }
    }
}
