﻿using System;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Base exception for all exceptions generated by library
    /// </summary>
    public abstract class OcipException : Exception
    {
        public OcipException(string message) : base(message) { }

        public OcipException(string message, Exception innerException) : base(message, innerException) { }
    }
}
