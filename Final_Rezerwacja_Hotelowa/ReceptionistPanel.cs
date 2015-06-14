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

        public ReceptionistPanel()
        {
            InitializeComponent();
            CreateUsersTab();
            CreateRoomTab();
            
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
        
    }
}
