using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    static class Program
    {
        static string databasename = "Db_Hostel.mdf";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           // Application.Run(new MainForm());
            //Application.Run(new AjoutterClient());
            //Application.Run(new MoudifierClient());
            //Application.Run(new SupprimerClient());
            //Application.Run(new Reservation());
            Application.Run(new Loading_page());
            //Application.Run(new SupprimerReservation());

        }
    }
}
