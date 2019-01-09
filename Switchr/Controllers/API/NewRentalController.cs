using Switchr.DTOs;
using Switchr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Switchr.Controllers.API
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        // POST: /api/newrental
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageGames)]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            if (newRental.GameIds.Count == 0)
                return BadRequest("Invalid game IDs.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            if (customer == null)
                return BadRequest("Invalid customer ID.");

            var games = _context.Games
                .Where(g => newRental.GameIds.Contains(g.Id))
                .ToList();

            if (games.Count != newRental.GameIds.Count)
                return BadRequest("One or more game IDs are invalid.");

            foreach (var game in games)
            {
                if (game.NumberAvailable < 1)
                    return BadRequest("Game is not currently in stock.");

                game.NumberAvailable--;

                var rental = new Rental
                {
                    Game = game,
                    Customer = customer,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
