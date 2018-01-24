﻿using System;

namespace Rabbit.Go.Abstractions.Codec
{
    public class EncodeException : GoException
    {
        public EncodeException(string message) : base(message)
        {
        }

        public EncodeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}