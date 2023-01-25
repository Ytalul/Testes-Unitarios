using Banco;
namespace TestesConta
{
    [TestClass]
    public class TesteContaBancaria
    {
        [TestMethod]
        public void TesteSaqueSucesso()
        {
            // Arrange
            ContaBancaria Conta = new ContaBancaria(500, "71109791400");

            bool resultadoTrue;

            // Action 
            resultadoTrue = Conta.Saque(200);

            // Assert
            Assert.IsTrue(resultadoTrue);
        }

        [TestMethod]
        public void TesteSaqueFalha()
        {
            // Arrange
            ContaBancaria Conta = new ContaBancaria(400, "12358748964");

            bool resultadoFalse;

            // Action 
            resultadoFalse = Conta.Saque(500);
            
            // Assert
            Assert.IsFalse(resultadoFalse); 
        }

        [TestMethod]
        public void TesteDepositar()
        {
            // Arrange
            ContaBancaria Conta = new ContaBancaria(800, "71104487544");
            bool resultado;

            // Action
            resultado = Conta.Depositar(200);

            // Assert
            Assert.IsTrue(resultado);
        }

    }
}