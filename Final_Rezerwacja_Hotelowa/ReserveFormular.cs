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
        struct Form_Data
        {
            public System.DateTime data_od;
            public System.DateTime data_do;
            public int room_number;
            public string client_login;
        };
        private Form_Data form_data=new Form_Data();
        public int user_id;
        private DataClassesDataContext dc = new DataClassesDataContext();
        private Refresh_Room_Grid R_Grid = Refresh_Room_Grid.Instance;
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
            //tworzenie obiektów tabel, które będą aktualizowane
            Rezerwacja rezerwacja=new Rezerwacja();
            Rezerwacja_Pokoj rezerwacja1 = new Rezerwacja_Pokoj();
            Pokoj room = new Pokoj();
            GetData();
            rezerwacja.id_klienta = (from s in dc.Klients where s.login == form_data.client_login select new { s.id_klienta }).First().id_klienta;
            rezerwacja.id_pracownika = user_id;
            //wyjatek przeprowadzany podczas rejestracji do pustej bazy
            try
            {
                rezerwacja.id_rezerwacji= (from s in dc.Rezerwacjas orderby s.id_rezerwacji descending select new { s.id_rezerwacji }).First().id_rezerwacji+1;
                
            }catch
            {
                rezerwacja.id_rezerwacji = 1;
            }
            //pokoj update
            room = dc.Pokojs.Single(c => c.id_pokoj == form_data.room_number);
            room.stan = true;
            room.rezerwacja_do = datefrom.Value;
            room.rezerwacja_od = dateto.Value;
            //rezerwacja-pokoj update
            rezerwacja1.id_pokoju = room.id_pokoj;
            rezerwacja1.id_rezerwacji = rezerwacja.id_rezerwacji;
            //akceptacja zmian
            dc.Rezerwacja_Pokojs.InsertOnSubmit(rezerwacja1);
            dc.Rezerwacjas.InsertOnSubmit(rezerwacja);
            dc.SubmitChanges();
            //update room grida
            Sync();
        }

        public void GetData()
        {
            //pobieranie danych z textboxów
            form_data.client_login = Login_box.Text;
            form_data.data_do = dateto.Value;
            form_data.data_od = datefrom.Value;
            form_data.room_number =Convert.ToInt32(numroom_box.Text);
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
                    if(room.zdjecie!=null)
                    pictureBox1.Image = Image.FromFile(room.zdjecie);
                    label4.ForeColor = Color.Green;
                    label4.Text = "\u221A";
                }
                }catch
                {
                    //ustawia default image
                    pictureBox1.Image = pictureBox1.InitialImage;

                    label4.ForeColor = Color.Red;
                    label4.Text = "X";
                   
                }
                try
                {
                    //sprawdzenie poprawności loginu
                    var user = (from c in dc.Klients where c.login.ToString() == Login_box.Text select new { c.login }).First();
                    if (Login_box.Text == user.login&&ExistAcc_rbutton.Checked)
                    {
                        Reserve.Enabled = true;
                        Tick_label.ForeColor = Color.Green;
                        Tick_label.Text = "\u221A";
                        return true;                       
                    }
                }catch
                {
                    Tick_label.ForeColor = Color.Red;
                    Tick_label.Text = "X";
                    return false;
                }
                Reserve.Enabled=false;
                return false;
        }

        public void Sync()
        { // synchronizacja zmian z bazą danych
            R_Grid.Update_All();
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
    }
}
