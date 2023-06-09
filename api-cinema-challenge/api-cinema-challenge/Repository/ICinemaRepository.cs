using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICinemaRepository
    {
        CustomerResponse AddCustomer (Customer customer);
        IEnumerable<Customer> GetCustomers();
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);

        /*
         * movies
         * create
         * get all
         * update
         * delete
         */
        MovieResponse AddMovie (Movie movie);
        IEnumerable<Movie> GetMovies();
        Movie UpdateMovie (Movie movie);
        Movie DeleteMovie (int id);

        /*
         * screenings
         * create 
         * get all
         */

        ScreeningResponse AddScreening (Screening screening);
        IEnumerable<Screening> GetScreenings();

        /*
         * tickets
         * post
         * get all
         */

        TicketResponse AddTicket (Ticket ticket);
        IEnumerable<Ticket> GetTickets();
    }
}
