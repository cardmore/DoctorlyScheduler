using Doctorly.Domain.Entities;

namespace Doctorly.Repository.Interfaces
{
    public interface IEventsRepository
    {
        List<Event> GetAllEvents();
    }
}
