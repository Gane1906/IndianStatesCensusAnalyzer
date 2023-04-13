using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new IndianStateException(IndianStateException.ExceptionType.FILE_INCORRECT, "Incorrect file path");
            if (!filePath.EndsWith(".csv"))
                throw new IndianStateException(IndianStateException.ExceptionType.TYPE_INCORRECT, "Incorrect file type");
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
                throw new IndianStateException(IndianStateException.ExceptionType.DELIMETER_INCORRECT, "Incorrect delimeter");
            using (var reader = new StreamReader(filePath))
            using (var cr = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = cr.GetRecords<StateCensusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
        public bool ReadCensusData(string filePath, string actualHeader)
        {
            var read = File.ReadAllText(filePath);
            char header = read[0];
            if (header.Equals(actualHeader))
                return true;
            throw new IndianStateException(IndianStateException.ExceptionType.HEADER_INCORRECT, "Incorrect header");

        }
    }
}
