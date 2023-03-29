namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void DevoJuntarNomeCompleto()
        {
            JuntarNomes sut = new JuntarNomes();

            string nomeCompleto = sut.Juntar("Jonathas", "Jean");

            Assert.That(nomeCompleto, Is.EqualTo("Jonathas Jean"));
        }

        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            JuntarNomes sut = new JuntarNomes();

            string nomeCompleto = sut.Juntar("JONATHAS", "JEAN");

            Assert.That(nomeCompleto, Is.EqualTo("Jonathas Jean").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            JuntarNomes sut = new JuntarNomes();

            string nomeCompleto = sut.Juntar("JONATHAS", "JEAN");

            Assert.That(nomeCompleto, Is.Not.EqualTo("Jonathas Jean"));
        }
    }
}