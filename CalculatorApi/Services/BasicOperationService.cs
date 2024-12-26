namespace CalculatorApi.Services
{
    public class BasicOperationService: IBasicOperationService
    {
        public double Add(double a, double b)
        {
            return a + b;
        } 

        public double Subtract(double a, double b)
        {
            return a - b;
        } 
        
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não pode dividir por zero");
            return a / b;
        } 
        
        public double Multiply(double a, double b)
        {
            return a * b;
        } 
    }
}