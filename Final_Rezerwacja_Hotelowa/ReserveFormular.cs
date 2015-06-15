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

        private void Check_Click(object sender, EventArgs e)
        {
            // weryfikacja użytkownika
            if (this.CheckData("dfsfds"))
            {

                Reserve.Enabled = true;
            }

        }

        public void GetData()
        {
            //pobieranie danych z textboxów


        }

        public bool CheckData(string login)
        {
            //sprawdzenie czy dany użytkownik i pokój na którego chcemy zapisać rezerwację istnieje w systemie
            
                try
                {
                var room = (from c in dc.Pokojs where c.id_pokoj.ToString() == numroom_box.Text select new{c.zdjecie,c.id_pokoj}).First();
                    if(room.id_pokoj.ToString()==numroom_box.Text||pictureBox1.ImageLocation!=room.zdjecie)
                    {
                        //pictureBox1.Image = room.zdjecie;
                        //MessageBox.Show(numroom_box.Text);
                    }
                }catch
                {
                    //pictureBox1.ImageLocation = "D:\\Programy\\Rebuid_Rezerwacja_Hotelowa\\Final_Rezerwacja_Hotelowa\\Room_photodefault-image.png";
                }
               // MessageBox.Show(room[0].ToString());
            
            return true;
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
            CheckData("fgfd");
        }



    }
}
