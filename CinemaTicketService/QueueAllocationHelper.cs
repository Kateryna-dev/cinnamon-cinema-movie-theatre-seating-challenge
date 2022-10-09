using System.Collections;

namespace CinemaTicketService
{
    public class QueueAllocationHelper : IAllocationStrategy
    {
        private Queue availiableSeats;

        public QueueAllocationHelper()
        {
            availiableSeats = new Queue();
            string[] rows = new string[] { "A", "B", "C" };
            int seatsInRow = 5;

            foreach (string row in rows)
                for (int i = 1; i <= seatsInRow; i++) 
                    availiableSeats.Enqueue($"{row}{i}");
        }

        public string[] GetTicketsFor(int numberOfSeats) 
        {
            if (numberOfSeats == 0 || numberOfSeats > availiableSeats.Count)
                return System.Array.Empty<string>();

            string[] tickets = new string[numberOfSeats];

            for (int i = 0; i < numberOfSeats; i++)
                 tickets[i] = availiableSeats.Dequeue().ToString();

            return tickets;
        }

        public int GetAvailiableSeatsCount() => (availiableSeats != null) ? availiableSeats.Count : 0;
    }
}
