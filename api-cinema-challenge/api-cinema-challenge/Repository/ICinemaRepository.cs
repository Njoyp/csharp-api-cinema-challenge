using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICinemaRepository
    {
        ResponseCustomer AddCustomer (Customer customer);
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
        Movie AddMovie (Movie movie);
        IEnumerable<Movie> GetMovies();
        Movie UpdateMovie (Movie movie);
        Movie DeleteMovie (int id);

        /*
         * screenings
         * create 
         * get all
         */

        Screening AddScreening (Screening screening);
        IEnumerable<Screening> GetScreenings();

        /*
         * tickets
         * post
         * get all
         */

        Ticket AddTicket (Ticket ticket);
        IEnumerable<Ticket> GetTickets();
    }
}
