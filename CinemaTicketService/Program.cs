using System;
namespace CinemaTicketService
{
    public class Program
    {
        static void Main(string[] args)
        {
            TicketService ticketService = new TicketService();
            ticketService.StartService();
        }
    }
}
