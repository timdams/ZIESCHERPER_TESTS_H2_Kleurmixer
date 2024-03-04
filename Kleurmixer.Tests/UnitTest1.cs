
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPClassBasicsTesterLibrary;

namespace Kleurmixer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        TimsEpicClassAnalyzer tester = new TimsEpicClassAnalyzer(new Kleur());

        [TestMethod]
        public void BasisKlasseProps()
        {
            tester.CheckAutoProperty("Rood", typeof(int), propType: TimsEpicClassAnalyzer.PropertyTypes.Normal);
            tester.CheckAutoProperty("Groen", typeof(int), propType: TimsEpicClassAnalyzer.PropertyTypes.Normal);
            tester.CheckAutoProperty("Blauw", typeof(int), propType: TimsEpicClassAnalyzer.PropertyTypes.Normal);
            tester.CheckMethod("MengKleur", typeof(void), new System.Type[] { typeof(Kleur) });
        }
        
    }
}
