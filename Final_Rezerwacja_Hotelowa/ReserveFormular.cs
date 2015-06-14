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
        public struct ReserveData
        {
            public string Login;
            public int RoomNum;
            public DateTime Rezbeg;
            public DateTime Rezend;
        };
        ReserveData RData;

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
            if (this.CheckData())
            {
                //MessageBox.Show(RData.Login);
                Reserve.Enabled = true;
            }

        }

        public void GetData()
        {
            //pobieranie danych z textboxów
            RData.Login = Login_box.Text;
            RData.Rezbeg = datefrom.Value;
            RData.Rezend = dateto.Value;

            try
            {
                RData.RoomNum = Int32.Parse(numroom_box.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Number of room : FormatException" + numroom_box.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number of room : OverflowException" +  numroom_box.Text);
            }

        }

        public bool CheckData()
        {
            //sprawdzenie czy dany użytkownik na którego chcemy zapisać rezerwację istnieje w systemie
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



    }
}
