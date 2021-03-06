﻿using System;

namespace Sifon.Code.Exceptions
{
    public class RemoteTimeoutException : Exception
    {
        public RemoteTimeoutException()
        {
        }

        public RemoteTimeoutException(string message) : base(message)
        {
        }

        public RemoteTimeoutException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
