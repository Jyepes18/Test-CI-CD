
using Test_CI_CD.Interfaces;
using Test_CI_CD.Services;

namespace TestOperation
{
    [TestClass]
    public class TestOperation
    {
        private OperationService _operationService;

        [TestInitialize]
        public void Setup()
        {
            _operationService = new OperationService();
        }

        [TestMethod]
        public async Task Test_Calular_Suma()
        {
            // Arrange: Inicializador de variables
            int numbrer_one = 1;
            int number_two = 2;

            // Act: Ejecución de la función a probar
            int resultado = await _operationService.Sum(numbrer_one, number_two);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public async Task Test_Calular_Resta()
        {
            // Arrange: Inicializador de variables
            int numbrer_one = 2;
            int number_two = 1;

            // Act: Ejecución de la función a probar
            int resultado = await _operationService.Subtract(numbrer_one, number_two);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public async Task Test_Calular_Multiplicar()
        {
            // Arrange: Inicializador de variables
            int numbrer_one = 2;
            int number_two = 1;

            // Act: Ejecución de la función a probar
            int resultado = await _operationService.Multiply(numbrer_one, number_two);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public async Task Test_Calular_Dividir()
        {
            // Arrange: Inicializador de variables
            int numbrer_one = 4;
            int number_two = 2;

            // Act: Ejecución de la función a probar
            int resultado = await _operationService.Divide(numbrer_one, number_two);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public async Task Test_Calular_Dividir_Por_Cero()
        {
            // Arrange: Inicializador de variables
            int numbrer_one = 10;
            int number_two = 0;

            // Act: Ejecución de la función a probar
           await _operationService.Divide(numbrer_one, number_two);

            //Assert: se espera una excepción de DivideByZeroException
        }
    }
    }
