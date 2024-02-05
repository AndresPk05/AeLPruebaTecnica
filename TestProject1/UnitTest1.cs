using AeLPruebaTecnica.Logic.Test;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var liquidacion = new Liquidacion();
            int number1 = 1;
            int number2 = 4;
            int number3 = 5;

            int result = liquidacion.CalcularLiquidacion(number1, number2, number3);
            Assert.AreEqual(10, result);
            number1 = -1;
            Assert.ThrowsException<Exception>(() => liquidacion.CalcularLiquidacion(number1, number2, number3));
        }
    }
}