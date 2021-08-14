﻿namespace Ethereal.Application.Exceptions
{
    public class ThreadExceededTimeoutException : EtherealException
    {
        public ThreadExceededTimeoutException(string message = "Internal server error",
            string description = "Something went wrong, try again")
            : base(message, description)
        {

        }
    }
}