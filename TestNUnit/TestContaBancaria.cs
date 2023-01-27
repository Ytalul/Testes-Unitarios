using Banco;

namespace ContaTest.NUnit
{
    [TestFixture]
    public class TestContaBancaria
    {
        ContaBancaria Conta;

        [SetUp]
        public void Setup()
        {
            Conta = new ContaBancaria(400, "0001");
        }


        [Test]
        [Category("Validos")]
        public void SaqueValido()
        {
            // Arrange
            // Action
            bool Valido = Conta.Saque(100);
            // Assert
            Assert.IsTrue(Valido);
        }

        [Test]
        [Category("Invalido - Valor maior que o saldo")]
        public void SaqueInvalido()
        {
            bool ResultadoFalse = Conta.Saque(500);
            Assert.IsFalse(ResultadoFalse);
        }


        [Test]
        [Category("Invalido - Valor Negativo")]
        [TestCase(-450, false)]
        [TestCase(-200, false)]
        // [Ignore("Falta implementar RN02")]  Decorador para ignorar temporariamente esse teste 
        public void SacarValorNegativo(int valor, bool resposta)
        {
            bool Resultado = Conta.Saque(valor);

            Assert.AreEqual(Resultado, resposta);
        }

        [Test]
        [Category("Cases")]
        [TestCase(100, true)]
        [TestCase(-200, false)]
        [TestCase(500, false)]
        public void TestCases(int a, bool resultado)
        {
            bool result = Conta.Saque(a);

            Assert.AreEqual(result, resultado);
        }


        [Test]
        [Timeout(5000)]
        [Category("Exceção")]
        public void TestSaqueExceptionValorIgualZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { Conta.Saque(0); });
        }


    }
}