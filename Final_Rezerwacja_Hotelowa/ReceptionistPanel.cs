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
    public partial class ReceptionistPanel : Form
    {
        //instancje zakładek , w których ukryta jest implementacja 
        UsersTab UTab;
        RoomTab RTab;
        Refresh_Room_Grid R_Grid=Refresh_Room_Grid.Instance;
        DataClassesDataContext dc= new DataClassesDataContext();

        public ReceptionistPanel()
        {
            InitializeComponent();
            CreateUsersTab();
            CreateRoomTab();
            R_Grid.Inicjalize(dataGridView1);
            var query = from c in dc.Pokojs select new { Numer = c.id_pokoj, Pojemnosc = c.pojemnosc, Stan = c.stan, Cena = c.cena_pokoju };
            R_Grid.Set_Edited(query);
            R_Grid.Set_Update();
        }

        private void ReceptionistPanel_Load(object sender, EventArgs e)
        {
            
        }

        public void CreateUsersTab()
        { //tworzy zakładkę Użytkowników
            UTab = new UsersTab();
        }

        public void CreateRoomTab()
        {  // tworzy zakładkę pokoi
            RTab = new RoomTab();
        }

        private void ReserveRoom_Click(object sender, EventArgs e)
        {
            // przycisk do rezerwowania pokoju
            RTab.OpenReservePanel();

        }

        private void Details_Click(object sender, EventArgs e)
        {
            RTab.ManageRoom();
            // przycisk do zobaczenia szegółów pokoju
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            // przycisk do dodania nowego użytkownika
            UTab.MakeAcc();

        }

        private void ChooseUser_Click(object sender, EventArgs e)
        {
            // przycisk do wybrania użytkownika w celu modyfikacji danych
            UTab.ChooseUser();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            // wylogowanie się z panelu recepcjonisty

            LoginPanel next = new LoginPanel();
            next.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(R_Grid.state.ToString());
            if(R_Grid.Get_State())
            {
                R_Grid.Set_Update();
                //MessageBox.Show("Update");
            }
        }
        
    }
}
