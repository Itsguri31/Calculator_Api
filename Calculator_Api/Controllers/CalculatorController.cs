namespace CalculatorApi.Calculator;
using Microsoft.AspNetCore.Mvc;

public class CalculatorController  : ControllerBase {

private readonly ICalculatorService<decimal> _service;

public CalculatorController(ICalculatorService<decimal> service){
    _service = service;
}

[HttpGet("Add")]
public decimal Add([FromQuery] decimal left, decimal right){
    return _service.Add(left, right);
}

[HttpGet("Subtract")]
public decimal Subtract([FromQuery] decimal left, decimal right){
    return _service.Subtract(left, right);
}

[HttpGet("Divide")]
public decimal Divide([FromQuery] decimal left, [FromQuery] decimal right){
    return _service.Divide(left, right);
}

[HttpGet("Multiply")]
public decimal Multiply([FromQuery] decimal left, [FromQuery] decimal right){
    return _service.Multiply(left, right);
}





}

