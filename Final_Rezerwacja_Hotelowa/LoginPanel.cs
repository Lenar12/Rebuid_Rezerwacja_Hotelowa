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
   
    public partial class LoginPanel : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        CreatorPanel Factory = new CreatorPanel();
        struct Data
        {
            public string login;
            public string password;
            public int uprawnienia;
        } Data dane = new Data();

        public LoginPanel()
        {
            InitializeComponent();
        }

        public bool CheckUser()
        {
            // sprawdza czy użytkownik o podanym loginie istnieje w systemie 
            ReceiveData();
            try
            {
                var val = (from c in dc.Klients where c.login == dane.login select new{c.login, c.haslo, c.id_klienta}).First();
                //MessageBox.Show(val.haslo);
                if(val.haslo==dane.password)
                {
                    dane.uprawnienia = val.id_klienta;
                    return true;
                }
            }catch
            {
                //błąd podczas logowania
            }
                return false;
        }

        public void ReceiveData()
        { 
            // pobranie danych z textboxów 
            dane.login = login_box.Text;
            dane.password = password_box.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // jeśli metoda CheckUser() zwróciła poprawną wartość to można wpuścić użytkownika do systemu
            if (this.CheckUser())
            {
                Factory.CheckAuthorization(dane.uprawnienia);// podajemy login i wprowadza nas w odpowiednie GUI
                this.Hide();
            }else
                MessageBox.Show("Błędne dane użytkownika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
