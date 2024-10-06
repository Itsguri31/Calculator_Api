namespace CalculatorApi.Calculator;

public class CalculatorService : ICalculatorService <decimal>{

    public int Add(decimal left, decimal right) {
        return left + right;
    }

    public int Subtract(decimal left, decimal right) {
        return left - right;
    }

    public int Divide(decimal left, decimal right) {
        return left / right;
    }


    public int Multiply(decimal left, decimal right) {
        return left * right;
    }

}