using libCommerciaux;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestlibCommerciaux
{
    [TestClass]
    public class TestEcrire
    {
        [TestMethod]
        public void TestAjouterNoteFrais()
        {
            Commercial c = new Commercial("Jean", "Dupond", 25, 'A');
            // Act
            NoteFrais f0 = new NoteFrais(new DateTime(2022, 11, 12), c);
            NoteFrais f1 = new NoteFrais(new DateTime(2022, 11, 15), c);

            Assert.AreEqual(2, c.getMesNoteFrais().Count);
        }
    }
}
