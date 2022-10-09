using System;
using System.Linq;
using System.Collections.Generic;

namespace CinemaTicketService
{
    public static class DataIOHelper
    {
        public static void PrintAllOrders(List<string[]> allocatedSeats) 
        {
            Console.WriteLine("This is our orders:");

            if (allocatedSeats == null || allocatedSeats.Count == 0)
                Console.WriteLine("Houston, we've had a problem... ");

            foreach (string[] seats in allocatedSeats)
                Console.WriteLine(String.Join(" ", seats));

            Console.ReadKey();
        }
    }
}
