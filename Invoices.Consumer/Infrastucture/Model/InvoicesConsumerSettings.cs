using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Consumer.Model
{
    public class InvoicesConsumerSettings
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public dynamic Content { get; set; }
    }
}
