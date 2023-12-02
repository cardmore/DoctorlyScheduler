using Doctorly.Services.Events.Dtos.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Doctorly.Services.Events.EventQueries
{
    public class GetEventsDetailsQuery
    {
    }

    public class GetEventsDetailsQueryHandler : IRequestHandlerWrapper<GetEventsDetailsQuery, EventsResponseDto>
    {
        private readonly IMainDbContext _db;
        private readonly IMapper _mapper;

        public GetEventsDetailsQueryHandler(IMainDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EventsResponseDto> Handle(GetEventsDetailsQuery request, CancellationToken cancellationToken)
        {
            var proc_GetClientFromIdResult = _db.GetSingleOrDefault<Proc_GetClientFromId>("@ID=@p0", request.ClientId);

            var response = new EventsResponseDto();

            return new Task<EventsResponseDto>(response);
        }
    }
}
