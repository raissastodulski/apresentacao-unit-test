using Microsoft.VisualBasic;

namespace CalculatorApi.Services
{
    public class FormulaService
    {
        private IBasicOperationService _basicOperationsService;

        public FormulaService(IBasicOperationService basicOperationsService)
        {
            _basicOperationsService = basicOperationsService;
        }

        public double Delta(double a, double b, double c)
        {
            var x = _basicOperationsService.Multiply(b, b) - (4 * a * c);
            return x;
        }
        
        public double BhaskaraSubtract(double a, double b, double c)
        {
            var x = -b - Math.Sqrt(Delta(a, b, c));
            x = x / (2 * a);
            return x;
        }
        
        public double BhaskaraAdd(double a, double b, double c)
        {
            var x = -b + Math.Sqrt(Delta(a, b, c));
            x = x / (2 * a);
            return x;
        }
    }
}