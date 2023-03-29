using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Asserts.Tests.Intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DevoAumentarVidaJogadorDepoisDormir()
        {
            // Vida inicial do jogador = 100%
            var sut = new CaracteristicasJogador { Vida = 100};

            sut.Dormir();
            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        [Test]
        public void DevoAumentarVidaJogadorDepoisDormir_Intervalo()
        {
            // Vida inicial do jogador = 100%
            var sut = new CaracteristicasJogador { Vida = 100 };

            sut.Dormir();
            Assert.That(sut.Vida, Is.InRange(101, 200));
        }
    }
}
