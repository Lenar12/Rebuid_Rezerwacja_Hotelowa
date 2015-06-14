using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Rezerwacja_Hotelowa
{
    class Refresh_Room_Grid
    {
        private static Refresh_Room_Grid instance;
        private DataGridView tmp_grid;
        private Object data;
        public bool state;
        private Refresh_Room_Grid(){}
        public static Refresh_Room_Grid Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Refresh_Room_Grid();
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
    }
}
