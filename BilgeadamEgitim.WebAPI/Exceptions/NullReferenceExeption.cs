using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeadamEgitim.WebAPI.Exceptions
{

    public class NullReferenceExeptioncs : Exception
    {
        public NullReferenceExeptioncs(string message) : base(message)
        {
        }
    }
}
