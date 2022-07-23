using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System
{
    public class AirportsList
    {
        private readonly List<Airports> _airports;
        public AirportsList()
        {
            _airports = new List<Airports>();
        }

        public IEnumerable<Airports> GetAllAirports()
        {
            return _airports;
        }

        public void AddAirport(Airports airports)
        {
            foreach (Airports item in _airports)
            {
                if (item.Conflicts(airports))
                {
                    throw new AirportConflict(item, airports);
                }
            }
        }
    }
}
