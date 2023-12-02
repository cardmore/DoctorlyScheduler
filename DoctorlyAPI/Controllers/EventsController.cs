using Doctorly.Services.Events.Dtos.RequestDtp;
using Doctorly.Services.Events.Dtos.ResponseDto;
using Doctorly.Services.Events.EventCommands;
using Doctorly.Services.Events.EventQueries;
using Microsoft.AspNetCore.Mvc;

namespace DoctorlyAPI.Controllers
{
    public class EventsController : BaseApiController
    {
        public EventsController()
        {
      
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventsResponseDto>>> GetAllEvents(CancellationToken cancellationToken)
        {
            var query = new GetEventsDetailsQuery
            {

            };
                 
            return Ok(await Mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<EventsResponseDto>>> AddEvent([FromBody] GetEventRequestDto request, CancellationToken cancellationToken)
        {
            var command = new PostEventDetailsCommand
            {

            };

            return Ok(await Mediator.Send(command, cancellationToken));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<EventsResponseDto>>> UpdateEvent(int id, CancellationToken cancellationToken)
        {
            var command = new PutEventDetailsCommand
            {

            };


            return Ok(await Mediator.Send(command, cancellationToken));
        }

        [HttpDelete]
        public async Task<ActionResult<IEnumerable<EventsResponseDto>>> DeleteEvent(int id, CancellationToken cancellationToken)
        {
            var command = new DeleteEventDetailsCommand
            {

            };

            return Ok(await Mediator.Send(command, cancellationToken));
        }
    }
}
