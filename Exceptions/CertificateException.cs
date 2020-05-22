﻿namespace Wigley.Exceptions
{
    public class CertificateException : ResultCodeException
    {
        public CertificateException(params (string language, string message)[] errormessages) : base(ResultCodes.SystemError, errormessages)
        {

        }
    }
}