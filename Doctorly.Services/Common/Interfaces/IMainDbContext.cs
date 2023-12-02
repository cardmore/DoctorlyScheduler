using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctorly.Services.Common.Interfaces
{
    public interface IMainDbContext
    {
        public DatabaseFacade Database { get; } //Implementation of EF is only to act as a conduit ro connect to DB
    }
}
