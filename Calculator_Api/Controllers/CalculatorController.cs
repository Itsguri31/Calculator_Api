namespace CalculatorApi.Calculator;

public class CalculatorController  : ControllerBase {

private readonly ICalculatorService<decimal> _service;

public CalculatorController(ICalculatorService<decimal> service){
    _service = service;
}

[HttpGet("Add")]
public decimal Add([FromQuery] decimal left, decimal right){
    return _service.Add(left+right);
}

}

