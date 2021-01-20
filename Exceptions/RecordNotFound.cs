using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFound:Exception
    {
        public RecordNotFound(string message):base(message)
        {
            
        }

    }
}
