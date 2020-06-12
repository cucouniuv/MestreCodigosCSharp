using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questao4POO;

namespace Questao4POOTests
{
    [TestClass]
    public class TelevisaoTests
    {
        readonly Televisao tv = new Televisao();

        [TestMethod]
        public void SintonizouCanais()
        {
            Assert.IsTrue(tv.ListaCanal.Count > 0);
        }

        [TestMethod]
        public void AumentouVolume()
        {
            tv.Volume = 50;
            tv.AumentarVolume();
            Assert.AreEqual(51, tv.Volume, 1, "Falha ao aumentar o volume");
        }

        [TestMethod]
        public void DiminuiuVolume()
        {
            tv.Volume = 60;
            tv.DiminuirVolume();
            Assert.AreEqual(59, tv.Volume, 1, "Falha ao diminuir o volume");
        }
    }
}
