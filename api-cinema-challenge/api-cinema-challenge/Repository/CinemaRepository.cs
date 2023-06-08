using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        public Customer AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.CreatedAt = DateTime.UtcNow;
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }
        }
        public IEnumerable<Customer> GetCustomers()
        {
            using(var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using ( var db = new CinemaContext())
            {
                customer.UpdatedAt = DateTime.UtcNow;
                db.Update(customer);
                db.SaveChanges();
                return customer;
            }
        }
        public Customer DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                var customer = db.Customers.Find(id);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    return customer;
                }
                return null;
            }
        }

        public Movie AddMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                movie.CreatedAt = DateTime.UtcNow;
                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.Movies.ToList();
            }
        }

        public Movie UpdateMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                movie.UpdatedAt = DateTime.UtcNow;
                db.Update(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public Movie DeleteMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                var movie = db.Movies.Find(id);
                if (movie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return movie;
                }
                return null;
            }
        }

        public Screening AddScreening(Screening screening)
        {
            using (var db = new CinemaContext())
            {
                screening.CreatedAt = DateTime.UtcNow;
                screening.StartsAt.ToString();

                db.Screenings.Add(screening);
                db.SaveChanges();
                return screening;
            }
        }

        public IEnumerable<Screening> GetScreenings()
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.ToList();
            }
        }
    }
}
