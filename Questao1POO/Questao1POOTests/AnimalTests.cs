using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questao1POO;

namespace Questao1POOTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void MovimentarHumanoEVerificarAcaoRealizada()
        {
            string esperado = "Humano se moveu";
            Humano humano = new Humano();
            humano.Mover();

            Assert.AreEqual(esperado, humano.AcaoRealizada, "Falha ao comparar se o humano se movimentou.");
        }

        [TestMethod]
        public void MovimentarPeixeEVerificarAcaoRealizada()
        {
            string esperado = "Peixe se moveu";
            Peixe peixe = new Peixe();
            peixe.Mover();

            Assert.AreEqual(esperado, peixe.AcaoRealizada, "Falha ao comparar se o peixe se movimentou.");
        }

        [TestMethod]
        public void MovimentarCachorroEVerificarAcaoRealizada()
        {
            string esperado = "Cachorro latiu e se moveu";
            Cachorro cachorro = new Cachorro();
            cachorro.Mover();

            Assert.AreEqual(esperado, cachorro.AcaoRealizada, "Falha ao comparar se o cachorro se movimentou.");
        }

        [TestMethod]
        public void CriarCachorroComBomHumorEVerificarAcaoRealizada()
        {
            string esperado = "Cachorro brincou com uma criança";
            Cachorro cachorro = new Cachorro();
            ((IHumorBom)cachorro).ExecutarAlgo();

            Assert.AreEqual(esperado, cachorro.AcaoRealizada, 
                "Falha ao comparar se o cachorro de bom humor executou sua ação.");
        }

        [TestMethod]
        public void CriarCachorroComMauHumorEVerificarAcaoRealizada()
        {
            string esperado = "Cachorro mordeu o carteiro";
            Cachorro cachorro = new Cachorro();
            ((IHumorRuim)cachorro).ExecutarAlgo();

            Assert.AreEqual(esperado, cachorro.AcaoRealizada, 
                "Falha ao comparar se o cachorro de mau humor executou sua ação.");
        }
    }
}
