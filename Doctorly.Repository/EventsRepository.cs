using Doctorly.Domain.Entities;
using Doctorly.Persistence;
using Doctorly.Repository.Interfaces;

namespace Doctorly.Repository
{
    public class EventsRepository : IEventsRepository
    {
        public DataContext _db { get; set; }

        public EventsRepository(DataContext db)
        {
            _db = db;
        }
        public List<Event>? GetAllEvents()
        {
            if(_db != null)
                return _db.Events?.ToList();

            return null;

        }
    }
}
