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
    public partial class RoomManager : Form
    {
        public int selected_room;
        DataClassesDataContext dc = new DataClassesDataContext();
        public RoomManager()
        {
            InitializeComponent();
        }

        public void ShowDetails(int selected_room)
        {
            // pokazanie szczegółów dotyczących pokoju
            //MessageBox.Show(selected_room.ToString());
            var query= (from c in dc.Pokojs where c.id_pokoj == selected_room select c).First();
            groupBox1.Text = query.id_pokoj.ToString();
            label2.Text = query.pojemnosc.ToString();
            if(!query.stan)
            {
                label3.Text = "Wolny";
                label5.Text = "Brak";
                label7.Text = "Brak";
            }else
            {
                label3.Text = "Zajęty";
                label7.Text = query.rezerwacja_od.Value.Date.ToString().Substring(0,10);
                label5.Text = query.rezerwacja_do.Value.Date.ToString().Substring(0,10);
            }
            try
            {

                pictureBox1.Image = Image.FromFile(query.zdjecie);
            }
            catch (FileNotFoundException)
            {
               // MessageBox.Show("Nie znaleziono zdjęcia");
            }
            catch (ArgumentNullException)
            {
                pictureBox1.Image = pictureBox1.InitialImage;
            }
            richTextBox1.Text = query.wyposarzenie;
        }

        public void DeleteReservation()
        {

            // odwołanie rezerwacji 
            Pokoj pokoj = new Pokoj();
            Rezerwacja_Pokoj rezerwacja = new Rezerwacja_Pokoj();
            pokoj = (from s in dc.Pokojs where s.id_pokoj == selected_room select s).First();
            if (pokoj.stan == true)
            {
                rezerwacja = (from s in dc.Rezerwacja_Pokojs where s.id_pokoju == selected_room select s).First();
                pokoj.stan = false;
                dc.Rezerwacja_Pokojs.DeleteOnSubmit(rezerwacja);
                dc.SubmitChanges();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button potwierdzajacy zmiany
            if (checkBox1.Checked)
            {
                DeleteReservation();
                Refresh_Room_Grid R_Grid = Refresh_Room_Grid.Instance;
                R_Grid.Update_All();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
