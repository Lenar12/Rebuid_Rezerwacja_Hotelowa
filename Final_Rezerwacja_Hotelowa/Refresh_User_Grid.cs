using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Rezerwacja_Hotelowa
{
    class Refresh_User_Grid : Refresher
    {
        private DataClassesDataContext dc = new DataClassesDataContext();
        private static Refresh_User_Grid instance;
        private DataGridView tmp_grid;
        private object data;
        public bool state;
        private Refresh_User_Grid() { }
        public static Refresh_User_Grid Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Refresh_User_Grid();
                }
                return instance;
            }
        }
        public void Inicjalize(DataGridView grid)
        {
            tmp_grid = grid;
        }
        public void Set_Edited(Object obj)
        {
            data = obj;
            state = true;
        }
        public void Set_Update()
        {
            if (data != null)
            {
                tmp_grid.DataSource = data;
                state = false;
                data = null;
            }
        }
        public bool Get_State()
        {
            return state;
        }
        public void Update_All()
        {
            var user = from c in dc.Klients select new { ID = c.id_klienta, Imie = c.imie, Nazwisko = c.nazwisko, Login = c.login, Adres = c.adres_zamieszkania };
            tmp_grid.DataSource = user;
        }
    }
}
