using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeNubi.Api.Responses
{
    public class BaseResponse<T>
    {
        public BaseResponse(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
