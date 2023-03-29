using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    internal class CalculadoraTests
    {
        [Test]
        public void DevoSomarNumerosInteiros()
        {
            Calculadora sut = new Calculadora();
            var resultado = sut.SomarNumerosInteiros(4, 2);
            Assert.That(resultado, Is.EqualTo(6));
        }

        [Test]
        public void DevoSomarNumerosDecimais()
        {
            Calculadora sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.5, 2.4);
            Assert.That(resultado, Is.EqualTo(3.9));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithin()
        {
            Calculadora sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            Calculadora sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01).Percent);
        }

        [Test]
        public void DevoSomarNumerosDecimais_NaoBomExemploWithin()
        {
            Calculadora sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);
            Assert.That(resultado, Is.EqualTo(30).Within(100));
        }
    }
}
