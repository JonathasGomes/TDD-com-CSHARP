using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2018,1,1,0,0,0,0)));
        }

        [Test]
        public void DeveRetornarCorretamenteAnoNovo_Within()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2018, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
        }
    }
}
