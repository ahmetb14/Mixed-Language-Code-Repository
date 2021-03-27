using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RecorNotFoundException:Exception
    {
        public RecorNotFoundException(string message):base(message)
        {
            
        }
    }
}
