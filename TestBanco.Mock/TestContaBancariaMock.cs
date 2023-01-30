using NUnit.Framework;
using Moq;
using Banco;
namespace TestBanco.Mock
{
    public class TestContaBancariaMock
    {

        [Test]
        [Category("Teste True")]
        public void TestSolicitarEmprestimoMock()
        {

            ContaBancaria Conta = new ContaBancaria(400 , "711097", "55");


            var Mock = new Mock<IValidadorCredito>();
            Mock.Setup(x => x.ValidarCredito(It.IsAny<string>())).Returns(true);
            Conta.SetValidador(Mock.Object);
           

            bool Resultado =  Conta.SolicitarEmprestimo(5000);

            Assert.AreEqual(Resultado, true);

        }

        [Test]
        [Category("True")]
        public void TestEntregaDeCartaoTemTaxa()
        {

            ContaBancaria Conta = new ContaBancaria(25000, "0024", "55");

            var Mock = new Mock<IValidadorCredito>();
            Mock.Setup(Classe => Classe.TemTaxa("55")).Returns(true);
            Conta.SetClasseTemTaxa(Mock.Object);

            int ResultadoEsperado = 24900;
            Conta.EntregarCartaoTemTaxa();
            Assert.AreEqual(ResultadoEsperado, Conta.GetSaldo());

        }


    }
}