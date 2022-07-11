using System.Windows;

namespace Flight_Ticket_System
{
    internal class Coordinator
    {
        private Window _window;

        private Window Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new MainWindow();
                    _window.Show();
                }
                return _window;
            }
        }


        public void OpenFlights()
        {
            Flights flights = new Flights();
            flights.DataContext = new FlightsViewModel(this);
            Window.Content = flights;
        }
    }
}
