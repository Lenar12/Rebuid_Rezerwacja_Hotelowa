using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Rezerwacja_Hotelowa
{
    class RoomTab
    {
        //private static RoomTab instance;
        //private RoomTab() {}

        //public static RoomTab Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new RoomTab();
        //        }
        //        return instance;
        //    }
        //}

        public void OpenReservePanel()
        {
            // otwiera formularz rezerwacji
            ReserveFormular next = new ReserveFormular();
            next.Show();
        }

        public void ShowRooms()
        {
            // pokazuję listę pokoi

        }

        public void ManageRoom()
        {
            // otwiera okno w ,którym będziemy mogli zobaczyć szczegóły pokoju
            RoomManager next = new RoomManager();
            next.Show();
        }


    }
}
