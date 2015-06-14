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
    public partial class RoomManager : Form
    {
        public RoomManager()
        {
            InitializeComponent();
        }

        public void ShowDetails()
        {
            // pokazanie szczegółów dotyczących pokoju

        }

        public void DeleteReservation()
        {
            // odwołanie rezerwacji 

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
