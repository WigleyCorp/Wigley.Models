using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wigley.Exceptions
{
    public class ArgumentException : ResultCodeException
    {
        public ArgumentException(params (string language, string message)[] errormessages) : base(ResultCodes.ArgumentError, errormessages)
        {

        }
    }

}
