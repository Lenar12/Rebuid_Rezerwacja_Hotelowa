using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Rezerwacja_Hotelowa
{
    interface Refresh_Interface
    {
        void Inicjalize(DataGridView grid);
        void Set_Edited(Object obj);
        void Set_Update();
        bool Get_State();
    }
    class Refresh_Grid : Refresh_Interface
    {
        private static Refresh_Grid instance;
        private DataGridView tmp_grid;
        private Object data;
        private bool state;
        private Refresh_Grid(){}
        public static Refresh_Grid Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Refresh_Grid();
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
            tmp_grid.DataSource = data;
            state = false;
        }
        public bool Get_State()
        {
            return state;
        }
    }
}
