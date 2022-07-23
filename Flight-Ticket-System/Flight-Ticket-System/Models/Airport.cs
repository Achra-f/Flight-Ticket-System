using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Models
{
    public class Airport
    {
        private readonly AirportsList _airportsList;

        public int Id { get; }
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        public string Code { get; }

        public Airport(int id, string name, string country, string city, string code)
        {

            Id = id;
            Name = name;
            Country = country;
            City = city;
            Code = code;
            _airportsList = new AirportsList();
        }

        public IEnumerable<Airports> GetAllAirports()
        {
            return _airportsList.GetAllAirports();
        }

        public void CreateAirport(Airports airports)
        {
            _airportsList.AddAirport(airports);
        }


    }
}
