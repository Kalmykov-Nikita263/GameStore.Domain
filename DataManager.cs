using GameStore.Domain.Repository.Abstractions;

namespace GameStore.Domain
{
    public class DataManager
    {
        public IGamesRepository Games { get; set; }

        public DataManager(IGamesRepository games) => Games = games;
    }
}
