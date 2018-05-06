using System;
using X12.Framework.Configuration;
using X12.Framework.Domain;
namespace X12.Framework.Services
{
    public class X12TransactionSetStaticItemReader : IX12TransactionSetItemReader
    {
        private readonly IX12TransactionSetStaticItemReaderConfiguration _config;

        public X12TransactionSetStaticItemReader(IX12TransactionSetStaticItemReaderConfiguration config)
        {
            _config = config;
        }

        public IX12Entity<string> Read(string input)
        {
            var value = input.Substring(_config.Offset ?? 0, _config.Length);
            return new X12Entity<string>(_config, value);
        }

        object IX12Reader.Read(string input)
        {
            return Read(input);
        }
    }
}
