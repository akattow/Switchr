using AutoMapper;
using System.Data.Entity;
using Switchr.DTOs;
using Switchr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace Switchr.Controllers.API
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: /api/games
        public IHttpActionResult GetGames()
        {
            var gameDtos = _context.Games
                .Include(g => g.GameType)
                .ToList()
                .Select(Mapper.Map<Game, GameDto>);

            return Ok(gameDtos);
        }

        // GET: /api/games/#
        public IHttpActionResult GetGame(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
                return NotFound();

            return Ok(Mapper.Map<Game, GameDto>(game));
        }

        // POST: /api/games
        [HttpPost]
        public IHttpActionResult AddGame(GameDto gameDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var game = Mapper.Map<GameDto, Game>(gameDto);
            _context.Games.Add(game);
            _context.SaveChanges();

            gameDto.Id = game.Id;

            return Created(new Uri(Request.RequestUri + "/" + game.Id), gameDto);
        }

        // PUT: /api/games/#
        [HttpPut]
        public IHttpActionResult UpdateGame(int id, GameDto gameDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);

            if (gameInDb == null)
                return NotFound();

            Mapper.Map<GameDto, Game>(gameDto, gameInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE: /api/customers/#
        [HttpDelete]
        public IHttpActionResult DeleteGame(int id)
        {
            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);

            if (gameInDb == null)
                return NotFound();

            _context.Games.Remove(gameInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}