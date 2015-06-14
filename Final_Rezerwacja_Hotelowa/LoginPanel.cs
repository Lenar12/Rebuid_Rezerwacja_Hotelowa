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
        AbstractFactory Factory = new AbstractFactory();

        public LoginPanel()
        {
            InitializeComponent();

        }

        public bool CheckUser()
        {
            // sprawdza czy użytkownik o podanym loginie istnieje w systemie 
            return true;
        }

        public void ReceiveData()
        { 
            // pobranie danych z textboxów 

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // jeśli metoda CheckUser() zwróciła poprawną wartość to można wpuścić użytkownika do systemu
            if (this.CheckUser())
            {
               
                Factory.CheckAuthorization();// podajemy login i wprowadza nas w odpowiednie GUI
                this.Hide();
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
