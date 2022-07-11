using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight_Ticket_System
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        readonly Coordinator coordinator;

        public ActionCommand FlightsCommand { get;private set; }

        public MainViewModel()
        {
            FlightsCommand = new ActionCommand(FlightsCommandAction);
        }

        private void FlightsCommandAction()
        {
            coordinator.OpenFlights();
        }


        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
