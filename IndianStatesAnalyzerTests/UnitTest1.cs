using IndianStatesCensusAnalyzer;

namespace IndianStatesAnalyzerTests
{
    public class Tests
    {
        StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
        public string stateCensusFileIncorrect = @"E:\Users\Ganesh\Documents\BL Excercise\IndianStatesCensusAnalyzer\IndianStatesAnalyzerTests\File\StateCode1.csv";
        public string typeIncorrect = @"E:\Users\Ganesh\Documents\BL Excercise\IndianStatesCensusAnalyzer\IndianStatesAnalyzerTests\File\StateCode.txt";
        public string delimeterIncorrect = @"E:\Users\Ganesh\Documents\BL Excercise\IndianStatesCensusAnalyzer\IndianStatesAnalyzerTests\File\StateCodeDelimeter.csv";
        public string headerIncorrect = @"E:\Users\Ganesh\Documents\BL Excercise\IndianStatesCensusAnalyzer\IndianStatesAnalyzerTests\File\StateCodeHeader.csv";
        [Test]
        public void GuivenCensusDataFileIncorrect_WhenAalyze_ShouldThrowException()
        {
            try
            {
                int records = analyzer.ReadStateCensusData(stateCensusFileIncorrect);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }
        }
        [Test]
        public void GuivenCensusDataIncorrectType_WhenAalyze_ShouldThrowException()
        {
            try
            {
                int records = analyzer.ReadStateCensusData(typeIncorrect);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file type");
            }
        }
        [Test]
        public void GuivenCensusDataIncorrectDelimeter_WhenAalyze_ShouldThrowException()
        {
            try
            {
                int records = analyzer.ReadStateCensusData(delimeterIncorrect);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect delimeter");
            }
        }
        [Test]
        public void GuivenCensusDataIncorrectHeader_WhenAalyze_ShouldThrowException()
        {
            try
            {
                bool records = analyzer.ReadCensusData(headerIncorrect, "State,Population,AreaInSqKm,DensityPerSqKm");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect header");
            }
        }
    }
}