namespace CalculatorEngine;

public interface ICalculatorEngine
{
    CalculationResult Add(double a, double b);
    CalculationResult Subtract(double a, double b);
    CalculationResult Multiplication(double a, double b);
    CalculationResult Division(double a, double b);
    CalculationResult Equals(double a, double b);
    CalculationResult Power(double a, double b);
    CalculationResult Logarithm(double a, double b);
    CalculationResult Root(double a, double b);
    CalculationResult Factorial(double a);

    CalculationResult Sine(double a);
    CalculationResult Cosine(double a);
    CalculationResult Tangent(double a);
    CalculationResult Reciprocal(double a);
}