﻿using System;

namespace Sifon.Code.Exceptions
{
    public class RemoteNotInitializedException : Exception
    {
        public RemoteNotInitializedException()
        {
        }

        public RemoteNotInitializedException(string message) : base(message)
        {
        }

        public RemoteNotInitializedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
