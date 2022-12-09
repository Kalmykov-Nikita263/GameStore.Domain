using GameStore.Domain.Entities;
using System;
using System.Linq;

namespace GameStore.Domain.Repository.Abstractions
{
    public interface IGamesRepository
    {
        IQueryable<Game> GetGames();

        Game GetGameById(Guid id);

        void SaveGame(Game entity);

        void DeleteGame(Guid id);
    }
}