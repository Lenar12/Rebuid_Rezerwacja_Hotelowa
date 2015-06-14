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
        public ReserveFormular()
        {
            InitializeComponent();
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
            if (this.CheckData()) ;

        }

        public void GetData()
        {
            //pobieranie danych z textboxów

        }

        public bool CheckData()
        {
            //sprawdzenie czy dany użytkownik na którego chcemy zapisać rezerwację istnieje w systemie
            return true;
        }

        public void Sync()
        { // synchronizacja zmian z bazą danych

        }



    }
}
