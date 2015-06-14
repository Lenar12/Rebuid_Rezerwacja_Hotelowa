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

        }

        public bool CheckData()
        {
            // sprawdza czy użytkownik o podanym loginie już istnieje w systemie 

            return true;
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
               
            }

            this.Close();
        }


    }
}
