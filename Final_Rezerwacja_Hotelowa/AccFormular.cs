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
            public string Password;
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
            Refresh_User_Grid U_Grid = Refresh_User_Grid.Instance;
            U_Grid.Update_All();
        }

        public void GetData()
        {
            // pobiera dane z textboxów
            AData.Imie = Imie_box.Text;
            AData.Nazwisko = Nazwisko_box.Text;
            AData.Adres = Adres_Box.Text;
            AData.Login = (AData.Imie.Substring(0, 1) + AData.Nazwisko).ToLower();
            AData.Password = "123"; //lub jakaś funkcja generująca hasło w przyszłości by tu była
        }
      
        public bool CheckData()
        {
            GetData();
            // sprawdza czy użytkownik o podanym loginie już istnieje w systemie 
            try
            {
                var user = (from c in dc.Klients
                            where c.login == AData.Login
                            select new { c.login }).First().login != null;
                return false;
            }
            catch
            {
                return true;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Klient client = new Klient();
            // przycisk uruchamiający proces tworzenia konta 
            if (this.CheckData())
            {
                client.login = AData.Login;
                client.haslo = AData.Password;
                client.id_klienta = (from c in dc.Klients orderby c.id_klienta descending select new { c.id_klienta }).First().id_klienta + 1;
                client.imie = AData.Imie;
                client.nazwisko = AData.Nazwisko;
                client.adres_zamieszkania = AData.Adres;
                dc.Klients.InsertOnSubmit(client);
                dc.SubmitChanges();
                Sync();
            }
            else
                MessageBox.Show("Już takie konto istnieje");

            //this.Close();
        }


    }
}
