using Microsoft.EntityFrameworkCore.Infrastructure;


namespace Doctorly.Services.Common.Interfaces
{
    public interface IDoctorlyDbContext
    {
        public DatabaseFacade Database { get; } //Implementation of EF is only to act as a conduit ro connect to DB
        public List<TEntity> GetList<TEntity>(string sqlParams = null, params object[] parameters) where TEntity : class;

    }
}
