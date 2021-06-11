using System;

namespace BilgeadamEgitim.WebAPI.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException(string message) : base(message)
        {
        }
    }
}