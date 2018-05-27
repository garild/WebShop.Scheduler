using Invoices.Consumer.Infrastucture.Interface;
using Invoices.Consumer.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Invoices.Consumer.Infrastucture.Repositories
{
    public class ConsumerRepositry : IConsumerRepository
    {
        private readonly InvoicesConsumerSettings _invoicesSettings;

        public ConsumerRepositry(IOptions<InvoicesConsumerSettings> invoicesSettings)
        {
            _invoicesSettings = invoicesSettings.Value;
        }

        public IEnumerable<string> ReadFile()
        {
            var filePath = Path.Combine(_invoicesSettings.FilePath, _invoicesSettings.FileName);
            if (!File.Exists(filePath)) return null;

            return File.ReadLines(filePath);
        }
    }
}
