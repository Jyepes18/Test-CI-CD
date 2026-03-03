namespace Test_CI_CD.Interfaces
{
    public interface IOperationService
    {
        Task<int> Sum(int num1, int num2);
        Task<int> Subtract(int num1, int num2);
        Task<int> Multiply(int num1, int num2);
        Task<int> Divide(int num1, int num2);
    }
}
