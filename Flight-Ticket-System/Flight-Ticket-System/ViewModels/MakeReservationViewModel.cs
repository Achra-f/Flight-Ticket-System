using Flight_Ticket_System.Commands;
using Flight_Ticket_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Flight_Ticket_System.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private int flightNumber;
        public int FlightNumber
        {
            get
            {
                return flightNumber;
            }
            set
            {
                flightNumber = value;
                OnPropertyChanged(nameof(FlightNumber));
            }
        }

        private string flightName;
        public string FlightName
        {
            get
            {
                return flightName;
            }
            set
            {
                flightName = value;
                OnPropertyChanged(nameof(FlightName));
            }
        }

        private DateTime departureTime;
        public DateTime DepartureTime
        {
            get
            {
                return departureTime;
            }
            set
            {
                departureTime = value;
                OnPropertyChanged(nameof(DepartureTime));
            }
        }
        private DateTime arrivalTime;
        public DateTime ArrivalTime
        {
            get
            {
                return arrivalTime;
            }
            set
            {
                arrivalTime = value;
                OnPropertyChanged(nameof(ArrivalTime));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Airport airport)
        {
            SubmitCommand = new MakeReservationCommand( this,airport);
        }
    }
}
