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
    public partial class ReserveFormular : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public ReserveFormular()
        {
            InitializeComponent();
            MakeAcc.Enabled = true;
            Login_box.Enabled = false;
            Reserve.Enabled = false;
            CheckData();
        }

        private void MakeAcc_Click(object sender, EventArgs e)
        {
            // przekierowanie do formularza tworzenia konta

            AccFormular next = new AccFormular();
            next.Show();
            //this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            // rezerwacja pokoju

        }

        public void GetData()
        {
            //pobieranie danych z textboxów


        }

        public bool CheckData()
        {
            //sprawdzenie czy dany użytkownik i pokój na którego chcemy zapisać rezerwację istnieje w systemie
            
                try
                {
                //jeżeli pokój posiada obraz to wyświetla jego podgląd
                var room = (from c in dc.Pokojs where c.id_pokoj.ToString() == numroom_box.Text select new{c.zdjecie,c.id_pokoj}).First();
                if (room.id_pokoj.ToString() == numroom_box.Text || pictureBox1.ImageLocation != room.zdjecie)
                {
                    pictureBox1.Image = Image.FromFile(room.zdjecie);
                }
                }catch
                {
                    //ustawia default image
                    pictureBox1.Image = pictureBox1.InitialImage;
                }
                try
                {
                    //sprawdzenie poprawności loginu
                    var user = (from c in dc.Klients where c.login.ToString() == Login_box.Text select new { c.login }).First();
                    if (Login_box.Text == user.login)
                    {
                        Reserve.Enabled = true;
                        Tick_label.ForeColor = Color.LightGreen;
                        Tick_label.Text = "\u221A";
                        return true;                       
                    }
                }catch
                {
                    Tick_label.ForeColor = Color.Red;
                    Tick_label.Text = "X";
                    return false;
                }
                return false;
        }

        public void Sync()
        { // synchronizacja zmian z bazą danych

        }

        private void NewAcc_rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewAcc_rbutton.Checked) MakeAcc.Enabled = true;
            else MakeAcc.Enabled = false;
        }

        private void ExistAcc_rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExistAcc_rbutton.Checked) Login_box.Enabled = true;
            else Login_box.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckData();
        }

        private void Check_Click(object sender, EventArgs e)
        {

        }



    }
}
