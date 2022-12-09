using GameStore.Domain.Entities;
using GameStore.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace GameStore.Domain.Repository.EntityFramework
{
    public class EFGamesRepository : IGamesRepository
    {
        private readonly ApplicationDbContext _context;

        public EFGamesRepository(ApplicationDbContext context) => _context = context;

        public IQueryable<Game> GetGames() =>
            _context.Games;

        public Game GetGameById(Guid id) =>
            _context.Games.FirstOrDefault(x => x.GameId == id);

        public void SaveGame(Game entity)
        {
            if (entity.GameId == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void DeleteGame(Guid id)
        {
            _context.Games.Remove(new Game() { GameId = id });
            _context.SaveChanges();
        }
    }
}