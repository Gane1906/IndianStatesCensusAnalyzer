using IndianStatesCensusAnalyzer;
using System;
namespace IndianStatesAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            Console.WriteLine(analyzer.ReadStateCensusData(@"E:\Users\Ganesh\Documents\BL Excercise\IndianStatesCensusAnalyzer\IndianStatesAnalyzerTests\File\StateCode.csv"));
        }
    }
}