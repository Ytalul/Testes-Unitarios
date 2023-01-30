using Preços;
using NUnit.Framework;
using Moq;

namespace TestesProduto
{
    public class TestesProduto
    {
        private Produto Prod;

        [SetUp]
        public void SetUp()
        {
            Prod = new Produto(13, 45, "Bola");
        }

        [Test]
        public void TestMethodConsultarProdutoTrue()
        {
               
            var mock = new Mock<IConsultorPrice>();

            mock.Setup(ClasseReplica => ClasseReplica.Consultar(It.Is<decimal> (x => x <100) )).Returns(true);
            // so isolei a parte que busca em outro sistema entendeu
            Prod.Consultor = (mock.Object);

            bool resul = Prod.Consultor.Consultar(50);
            Assert.IsTrue(resul);
        }

        [Test]
        public void TestMethodTemTaxaEntregaTrue()
        {

            var mock = new Mock<IConsultorPrice>();
            mock.Setup(Replica => Replica.TemTaxaEntrega(It.Is<int>(x => x<15))).Returns(true);

            Prod.Consultor = (mock.Object);

            bool Resul = Prod.TemTaxaEntrega(14);

            Assert.IsTrue(Resul);


        }

        [Test]
        [Category("Excecao")]
        [TestCase(15, 20, "Drone")]
        public void TemTaxaException(int Id, int Price, string Nome)
        {
            var moq = new Mock<IConsultorPrice>();
            moq.Setup( Replica => Replica.TemTaxaEntrega(Id)).Throws<ArgumentNullException>();
            Prod.Consultor = moq.Object;

            bool Tem =  Prod.TemTaxaEntrega(Id);

            Assert.IsFalse(Tem);

        }


        [Test]
        public void TestVeriFY()
        {

            var Moc = new Mock<IConsultorPrice>();
            Prod.Consultor = (Moc.Object);

            bool RESUL = Prod.Consultor.Consultar(15);

            Moc.Verify( X => X.TemTaxaEntrega(12), Times.AtMost(5));

        }

    }
}