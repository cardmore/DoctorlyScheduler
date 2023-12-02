using Doctorly.Domain.Main.Entities;
using Doctorly.Services.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Doctorly.Persistence
{
    public class DoctorlyDbContext : DbContext, IDoctorlyDbContext
    {
        public DoctorlyDbContext(DbContextOptions<DoctorlyDbContext> options)
            : base(options)
        {
            
        }
        // Stored procedures for getting data
        public virtual DbSet<Event> Proc_Get_EventDetails { get; set; }


        public List<TEntity> GetList<TEntity>(string sqlParams = null, params object[] parameters) where TEntity : class
        {
            var enumerable = GetEnumerable<TEntity>(sqlParams, parameters);
            return enumerable.ToList();
        }

        public IEnumerable<TEntity> GetEnumerable<TEntity>(string sqlParams = null, params object[] parameters) where TEntity : class
        {
            var storedProcedureName = typeof(TEntity).Name;

            var sql = $"{storedProcedureName} {sqlParams}".Trim();

            return Set<TEntity>().FromSqlRaw(sql, parameters).AsEnumerable();
        }


    }
}
