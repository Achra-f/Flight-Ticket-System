using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Flight_Ticket_System.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;

        public IEnumerable<ReservationViewModel> Reservations => _reservation;
        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel()
        {
            _reservation = new ObservableCollection<ReservationViewModel>();

            _reservation.Add(new ReservationViewModel(new Models.Reservation(new Models.FlightID(1, "sydney"), "Achraf", DateTime.Now, DateTime.Now)));
            _reservation.Add(new ReservationViewModel(new Models.Reservation(new Models.FlightID(2, "brussels"), "Ben", DateTime.Now, DateTime.Now)));
            _reservation.Add(new ReservationViewModel(new Models.Reservation(new Models.FlightID(3, "oujda"), "Bendella", DateTime.Now, DateTime.Now)));
        }
    }
}
