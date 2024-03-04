
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
            tester.CheckAutoProperty("Rood", typeof(int));
            tester.CheckAutoProperty("Groen", typeof(int));
            tester.CheckAutoProperty("Blauw", typeof(int));
       
        }

        [TestMethod]
        public void BasisKlasseMethode()
        {
            tester.CheckMethod("MengKleur", typeof(void), new System.Type[] { typeof(Kleur) });
        }


        [TestMethod]
        public void WerkingMengkleurMethode()
        {


            if (tester.CheckMethod("MengKleur", typeof(void), new System.Type[] { typeof(Kleur) }))
            {
                var k1 = new TimsEpicClassAnalyzer(new Kleur());
                k1.SetProp("Rood", 10);
                k1.SetProp("Groen", 0);
                k1.SetProp("Blauw", 20);
                var k2 = new TimsEpicClassAnalyzer(new Kleur());
                k2.SetProp("Rood", 10);
                k2.SetProp("Groen", 10);
                k2.SetProp("Blauw", 50);

                k1.TestMethod("MengKleur", new object[] { k2.RefToObject });
                Assert.AreEqual((int)k1.GetProp("Rood"), 10, message:"Rood zou waarde 10 moeten hebben indien Rood in beide Kleur-objecten 10 was.");

                Assert.AreEqual((int)k1.GetProp("Groen"), 5, message: "Groen zou waarde 5 moeten hebben indien Groen in beide Kleur-objecten eerste 0 en 10 was.");

                Assert.AreEqual((int)k1.GetProp("Blauw"), 35, message: "Blauw zou waarde 35 moeten hebben indien Blauw in beide Kleur-objecten eerste 20 en 50 was.");
            }
        }
    }
}
