using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctorly.Services.Common
{
    public class RequestWrapper<TRequest, TResponse> : IRequestWrapper<TResponse>
       where TRequest : class
       where TResponse : class
    {
        public TRequest Request { get; set; }
        public UserDto User { get; set; }
    }
}
