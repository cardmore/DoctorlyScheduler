using Doctorly.Domain.Main.Entities;
using Doctorly.Services.Common;
using Doctorly.Services.Common.Interfaces;
using Doctorly.Services.Events.Dtos.RequestDtp;
using Doctorly.Services.Events.Dtos.ResponseDto;
using MapsterMapper;
using MediatR;

namespace Doctorly.Services.Events.EventQueries
{
    public class GetEventsDetailsQuery : RequestWrapper<GetEventRequestDto, EventsResponseDto>
    {
    }

    public class GetEventsDetailsQueryHandler : IRequestHandlerWrapper<GetEventsDetailsQuery, EventsResponseDto>
    {
        private readonly IDoctorlyDbContext _db;
        private readonly IMapper _mapper;

        public GetEventsDetailsQueryHandler(IDoctorlyDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EventsResponseDto> Handle(GetEventsDetailsQuery request, CancellationToken cancellationToken)
        {
            var getEntities = _db.GetList<Event>("@ID=@p0", request.ClientId);

            var response = new EventsResponseDto();

            return response;
        }
    }
}
