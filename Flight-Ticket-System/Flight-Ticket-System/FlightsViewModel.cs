using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System
{
    internal class FlightsViewModel
    {
        readonly Coordinator coordinator;



        public FlightsViewModel( Coordinator coordinator)
        {
            this.coordinator = coordinator;
        }
    }
}
