using System.Collections.Generic;

namespace CinemaTicketService
{
    /*
     The Cinnamon Cinemas Movie Theatre has 15 seats, arranged in 3 rows of 5
        ● Rows are assigned a letter from A to C
        ● Seats are assigned a number from 1 to 5
    ----------------------------------------------------------------------------
    
        ● GIVEN a customer wants to request some tickets
        ● WHEN they request a number of seats between 1 and 3 for a movie
        ● THEN the customer should be allocated the required number of seats
            from the available seats on the seating plan
        ● AND the seats should be recorded as allocated

     */

    public class TicketService
    {
        private IAllocationStrategy _allocationHelper;

    }
}
