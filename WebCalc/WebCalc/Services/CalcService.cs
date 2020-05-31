namespace WebCalc.Services
{
    public class CalcService
    {
        private readonly Logger _logger;

        public CalcService(Logger logger)
        {
            _logger = logger;
            _logger.Log("CalcService: creating an object");
        }

        public double Add(double x, double y)
        {
            _logger.Log($"CalcService: Add({x}, {y})");
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            _logger.Log($"CalcService: Subtract({x}, {y})");
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            _logger.Log($"CalcService: Multiply({x}, {y})");
            return x * y;
        }

        public double Divide(double x, double y)
        {
            _logger.Log($"CalcService: Divide({x}, {y})");
            return x / y;
        }
    }
}
