using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Consumer.Infrastucture.Interface
{
    public interface IConsumerRepository
    {
        IEnumerable<string> ReadFile();
    }
}
