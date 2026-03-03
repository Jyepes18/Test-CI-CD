using Test_CI_CD.Interfaces;

namespace Test_CI_CD.Services
{
    public class OperationService : IOperationService
    {
        public async Task<int> Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public async Task<int> Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public async Task<int> Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public async Task<int> Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}
