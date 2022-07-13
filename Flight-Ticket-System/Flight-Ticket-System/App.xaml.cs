using Flight_Ticket_System.Exceptions;
using Flight_Ticket_System.Models;
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
        protected override void OnStartup(StartupEventArgs e)
        {
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
            base.OnStartup(e);
        }
    }
}
