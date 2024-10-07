namespace CalculatorApi.Calculator;

public class CalculatorService : ICalculatorService <decimal>{

    

    decimal ICalculatorService<decimal>.Add(decimal left, decimal right)
    {
        return left + right;
    }

    decimal ICalculatorService<decimal>.Subtract(decimal left, decimal right)
    {
        return left - right;
    }

    decimal ICalculatorService<decimal>.Multiply(decimal left, decimal right)
    {
        return left * right;
    }

    decimal ICalculatorService<decimal>.Divide(decimal left, decimal right)
    {
        return left / right;
    }
}