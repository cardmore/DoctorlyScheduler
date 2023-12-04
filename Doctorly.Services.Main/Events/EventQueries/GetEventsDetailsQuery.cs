using Doctorly.Repository.Interfaces;
using Doctorly.Services.Events.Dtos.ResponseDto;
using MapsterMapper;
using MediatR;

namespace Doctorly.Services.Events.EventQueries
{
    public class GetEventsDetailsQuery : IRequest<List<EventsResponseDto>>
    {
    }

    public class GetEventsDetailsQueryHandler : IRequestHandler<GetEventsDetailsQuery, List<EventsResponseDto>>
    {
        private readonly IEventsRepository _eventsRepository;
        private readonly IMapper _mapper;

        public GetEventsDetailsQueryHandler(IEventsRepository eventsRepository, IMapper mapper)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
        }
        public async Task<List<EventsResponseDto>> Handle(GetEventsDetailsQuery request, CancellationToken cancellationToken)
        {
            var events = _eventsRepository.GetAllEvents();

           var eventsResponse =  _mapper.Map(events, new List<EventsResponseDto>());

            return eventsResponse;
        }
    }
}
