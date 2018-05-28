using FluentScheduler;
using Invoices.Consumer.Infrastucture.Interface;
using System.IO;

namespace Invoices.Consumer.Infrastucture
{
    public class CosumerJob : IJob
    {
        private readonly IConsumerRepository _consumerRepository;
        
        public CosumerJob(IConsumerRepository consumerRepository)
        {
            _consumerRepository = consumerRepository;
        }

        public void Execute()
        {
            var data  =_consumerRepository.ReadFile();

            File.AppendAllLines(@"C:/Temp/Test2.txt", data);
        }
    }
}
