namespace CinemaTicketService
{
    public static class OrderGenerator
    {
        const int MAX_NUM_OF_TICKETS_IN_ORDER = 3;

        public static  int GetNumberOfTicketsToBook() => new System.Random().Next(1, MAX_NUM_OF_TICKETS_IN_ORDER + 1);

    }
}
