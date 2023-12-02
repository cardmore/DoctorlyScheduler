using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorlyAPI.Controllers
{
        [ApiController]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("api/[controller]")]
        public abstract class BaseApiController : ControllerBase
        {
            private ISender _mediator;

            /// <summary>
            /// Mediator sender
            /// </summary>
            protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
        }
    }
}
