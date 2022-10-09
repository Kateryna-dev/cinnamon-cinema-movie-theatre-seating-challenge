using System.Collections.Generic;

namespace CinemaTicketService
{
    public class TicketService
    {
        private IAllocationStrategy _allocationHelper;
        private List<string[]> _allocatedSeats;

        public TicketService() 
        {
            _allocationHelper = new QueueAllocationHelper();
            _allocatedSeats = new List<string[]>();
        }

        public void StartService() 
        {
            string[] tickets;
            int numberOfTicketsInOrder;

            while (_allocationHelper.GetAvailiableSeatsCount() > 0) 
            {
                numberOfTicketsInOrder = OrderGenerator.GetNumberOfTicketsToBook();
                tickets = _allocationHelper.GetTicketsFor(numberOfTicketsInOrder);
                
                if (tickets != null && tickets.Length > 0)
                    _allocatedSeats.Add(tickets);
            }

            DataIOHelper.PrintAllOrders(_allocatedSeats);
        }
    }
}
