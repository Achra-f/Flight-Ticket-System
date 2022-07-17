using Flight_Ticket_System.Models;
using Flight_Ticket_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Airport _airport;
        private readonly MakeReservationViewModel _makeReservationViewModel;



        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Airport airport)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _airport = airport;
        }

        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(
                new FlightID(_makeReservationViewModel.FlightNumber, _makeReservationViewModel.FlightName), _makeReservationViewModel.Name,
                _makeReservationViewModel.DepartureTime, _makeReservationViewModel.ArrivalTime
                );

            _airport.MakeReservation(reservation);
        }
    }
}
