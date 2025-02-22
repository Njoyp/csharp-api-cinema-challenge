﻿using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        public CustomerResponse AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                CustomerResponse newCustomer = new CustomerResponse();
                customer.CreatedAt = DateTime.UtcNow;
                db.Customers.Add(customer);
                db.SaveChanges();
                newCustomer.Data = customer;
                return newCustomer;
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
                var targetcustomer = db.Customers.FirstOrDefault(i => i.Id == customer.Id);
                if (targetcustomer != null)
                {
                    targetcustomer.Name = string.IsNullOrEmpty(customer.Name) ? targetcustomer.Name : customer.Name;
                    targetcustomer.Email = string.IsNullOrEmpty(customer.Email) ? targetcustomer.Email : customer.Email;
                    targetcustomer.Phone = string.IsNullOrEmpty(customer.Phone) ? targetcustomer.Phone : customer.Phone;
                }
                targetcustomer.UpdatedAt = DateTime.UtcNow;
                //targetcustomer.Update();
                db.Update(targetcustomer);
                db.SaveChanges();
                return targetcustomer;
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

        public MovieResponse AddMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                MovieResponse newmovie = new MovieResponse();
                movie.CreatedAt = DateTime.UtcNow;
                if(movie.MovieScreenings != null) {
                    if (movie.MovieScreenings.Any())
                    {
                        movie.MovieScreenings.ToList().ForEach(x =>
                        {
                            x.CreatedAt = DateTime.UtcNow;
                        });
                    }
                }
                db.Movies.Add(movie);
                db.SaveChanges();
                newmovie.Data = movie;
                return newmovie;
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
                var targetMovie = db.Movies.FirstOrDefault(i => i.Id == movie.Id);
                if (targetMovie != null)
                {
                    targetMovie.Title =  string.IsNullOrEmpty(movie.Title) ? targetMovie.Title : movie.Title;
                    targetMovie.Rating = string.IsNullOrEmpty(movie.Rating) ? targetMovie.Rating : movie.Rating;
                    targetMovie.Description = string.IsNullOrEmpty(movie.Description) ? targetMovie.Description : movie.Description;
                    targetMovie.RuntimeMins = movie.RuntimeMins == 0 ? targetMovie.RuntimeMins : movie.RuntimeMins;
                }
                targetMovie.UpdatedAt = DateTime.UtcNow;
                db.Update(targetMovie);
                db.SaveChanges();
                return targetMovie;
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

        public ScreeningResponse AddScreening(Screening screening)
        {
            using (var db = new CinemaContext())
            {
                ScreeningResponse newScreening = new ScreeningResponse();
                screening.CreatedAt = DateTime.UtcNow;
                screening.StartsAt.ToString();

                db.Screenings.Add(screening);
                db.SaveChanges();
                newScreening.Data = screening;
                return newScreening;
            }
        }

        public IEnumerable<Screening> GetScreenings()
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.ToList();
            }
        }

        public TicketResponse AddTicket(Ticket ticket)
        {
            using (var db = new CinemaContext())
            {
                TicketResponse newTicket = new TicketResponse();
                if (ticket.NumSeats != 0)
                {
                    ticket.CreatedAt = DateTime.UtcNow;
                    db.Tickets.Add(ticket);
                    db.SaveChanges();
                    newTicket.Data = ticket;
                    return newTicket;
                }
                    return null;
            }
        }

        public IEnumerable<Ticket> GetTickets()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.ToList();
            }
        }
    }
}
