Cinnamon Cinemas Movie Theatre Seating Challenge

The application imitates the operation of a some service for booking tickets at the Cinnamon Cinemas. Cinnamon Cinemas Movie Theatre has 15 seats arranged in 3 rows of 5 (rows are assigned letters from A to C. Seats are assigned numbers from 1 to 5)

The service processes orders coming from the client (imitates by OrderGenerator), which determines how many seats to book for this order. Seats are booked strictly in order (A1, A2, A3 ...) and therefore a queue was chosen to implement this task.

In the future, it will be possible to switch the ticket booking strategy by changing the "helper" (the main thing is that it implements the IAllocationStrategy interface)

At the end of the simulation, the program outputs a set of reserved seats for each of the bookings.