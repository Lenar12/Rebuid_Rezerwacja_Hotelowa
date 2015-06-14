using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Rezerwacja_Hotelowa
{
    class UsersTab
    {

        //private static UsersTab instance;
        //private UsersTab() {}
        //public static UsersTab Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new UsersTab();
        //        }
        //        return instance;
        //    }
        //}

        public void MakeAcc()
        {
            // utworzenie formularza tworzenia nowego konta
            AccFormular next = new AccFormular();
            next.Show();
        }

        public void ChooseUser()
        {
            // otworzenie okna z możliwością edycji danych użytkownika
            UserEditor next = new UserEditor();
            next.Show();
        }

        public void ShowUsers()
        { // wyświetla użytkowników systemu

        }


    }

  
}
