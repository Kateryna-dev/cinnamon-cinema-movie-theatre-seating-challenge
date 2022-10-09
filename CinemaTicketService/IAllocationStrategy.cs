namespace CinemaTicketService
{
    public interface IAllocationStrategy
    {
        string[] GetTicketsFor(int numberOfSeats);

        int GetAvailiableSeatsCount();
    }
}
