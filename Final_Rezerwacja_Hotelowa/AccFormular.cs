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
    public partial class AccFormular : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public struct AccData
        {
            public string Imie;
            public string Nazwisko;
            public string Login;
            public string Pesel;
            public string Adres;
        };
        AccData AData;

        public AccFormular()
        {
            InitializeComponent();
        }

        public void AddAcc()
        {
            // funkcja do tworzenia nowego konta

        }

        public void Sync()
        { // funkcja do synchronizacji danych nowo utworzonego konta do bazy danych

        }

        public void GetData()
        {
            // pobiera dane z textboxów
            AData.Imie = Imie_box.Text;
            AData.Nazwisko = Nazwisko_box.Text;
            AData.Login = Login_box.Text;
            AData.Pesel = Pesel_box.Text;
            AData.Adres = Adres_box.Text;

        }
      
        public bool CheckData()
        {
            GetData();
            // sprawdza czy użytkownik o podanym loginie już istnieje w systemie 
            var user = from c in dc.Klients 
                           where c.login ==  AData.Imie
                           select c;
            if (user.ToString() == "")
                return true;
            else
                return false;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            // przycisk uruchamiający proces tworzenia konta 
            if (this.CheckData())
            {
                MessageBox.Show("Konto utworzono");
            }
            else
                MessageBox.Show("Już takie konto istnieje");

            this.Close();
        }


    }
}
