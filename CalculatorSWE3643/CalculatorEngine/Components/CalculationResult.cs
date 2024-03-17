namespace CalculatorEngine.Components;

public class CalculationResult
{
    public double Result { get; set; } = 0.0;
    public bool IsSuccess { get; set; } 
    public string Operation { get; set; }
    public string Error { get; set; }
}
