using CalculatorEngine;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebServiceApp.Components;

[ApiController]
[Route("[controller]")]
public class Controller : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly ICalculatorEngine _engine;

    public Controller(ICalculatorEngine calculatorEngine)
    {
        _engine = calculatorEngine;
    }

    [HttpGet("add")]
    public CalculationResult Add(double a, double b)
    {
        var result = _engine.Add(a, b);
        return result;
    }

    [HttpGet("subtract")]
    public CalculationResult Subtract(double a, double b)
    {
        var result = _engine.Subtract(a, b);
        return result;
    }
    
    [HttpGet("multiplication")]
    public CalculationResult Multiplication(double a, double b)
    {
        var result = _engine.Multiplication(a, b);
        return result;
    }
    
    
    [HttpGet("division")]
    public CalculationResult Division(double a, double b)
    {
        var result = _engine.Division(a, b);
        return result;
    }
    
    [HttpGet("equals")]
    public CalculationResult Equals(double a, double b)
    {
        var result = _engine.Equals(a, b);
        return result;
    }
    
    [HttpGet("power")]
    public CalculationResult Power(double a, double b)
    {
        var result = _engine.Power(a, b);
        return result;
    }
    
    [HttpGet("logarithm")]
    public CalculationResult Logarithm(double a, double b)
    {
        var result = _engine.Logarithm(a, b);
        return result;
    }
    
    [HttpGet("root")]
    public CalculationResult Root(double a, double b)
    {
        var result = _engine.Root(a, b);
        return result;
    }
    
    [HttpGet("factorial")]
    public CalculationResult Factorial(double a)
    {
        var result = _engine.Factorial(a);
        return result;
    }
    
    [HttpGet("sine")]
    public CalculationResult Sine(double a)
    {
        var result = _engine.Sine(a);
        return result;
    }
    
    [HttpGet("cosine")]
    public CalculationResult Cosine(double a)
    {
        var result = _engine.Cosine(a);
        return result;
    }
    
    [HttpGet("tangent")]
    public CalculationResult Tangent(double a)
    {
        var result = _engine.Tangent(a);
        return result;
    }
    
    [HttpGet("reciprocal")]
    public CalculationResult Reciprocal(double a)
    {
        var result = _engine.Reciprocal(a);
        return result;
    }
    
}