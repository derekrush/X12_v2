using System;
using System.Collections.Generic;
using X12.Framework.Domain;

namespace X12.Framework.Services
{
    public interface IX12TransactionSetReader : IX12Reader<IList<IX12Entity>>
    {
        
    }
}
