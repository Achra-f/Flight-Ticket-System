using Flight_Ticket_System.Exceptions;
using Flight_Ticket_System.Models;
using Flight_Ticket_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Flight_Ticket_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Airport _airport;

        public App()
        {
            _airport = new Airport("ZaventemBXL");
        }
        protected override void OnStartup(StartupEventArgs e)
        {

            /*testing models
            Airport airport = new Airport("Zaventem Airport");
            try
            {
                airport.MakeReservation(new Reservation
                (new FlightID(1, "test"),
                "Morocco",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 2)));

                airport.MakeReservation(new Reservation
                (new FlightID(1, "test"),
                "Morocco",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 2)));
            }
            catch (ReservationConflictException ex)
            {

                throw;
            }




            

            IEnumerable<Reservation> reservations = airport.GetAllReservations();
            */

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_airport)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
