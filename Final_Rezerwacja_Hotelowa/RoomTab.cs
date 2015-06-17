using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Rezerwacja_Hotelowa
{
    class RoomTab
    {

        public void OpenReservePanel(int id)
        {
            // otwiera formularz rezerwacji
            ReserveFormular next = new ReserveFormular();
            next.user_id = id;
            next.Show();
        }

        public void ShowRooms()
        {
            // pokazuję listę pokoi

        }

        public void ManageRoom(int selected_room)
        {
            // otwiera okno w ,którym będziemy mogli zobaczyć szczegóły pokoju
            RoomManager next = new RoomManager();
            next.selected_room = selected_room;
            next.ShowDetails(selected_room);
            next.Show();
        }


    }
}
