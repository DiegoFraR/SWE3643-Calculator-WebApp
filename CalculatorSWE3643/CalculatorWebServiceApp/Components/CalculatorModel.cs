using CalculatorEngine;

namespace CalculatorWebServiceApp.Components;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CalculatorModel()
{
    private readonly CalculatorController _controller;

    public CalculatorModel(CalculatorController controller) : this()
    {
        _controller = controller;
    }
    
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    public CalculationResult Result { get; private set; }

    public void Add()
    {
        Result = _controller.Add(A, B);
    }

    public void Subtract()
    {
        Result = _controller.Subtract(A, B);
    }

    public void Multiplication()
    {
        Result = _controller.Multiplication(A, B);
    }

    public void Division()
    {
        Result = _controller.Division(A, B);
    }

    public void Equals()
    {
        Result = _controller.Equals(A, B);
    }

    public void Power()
    {
        Result = _controller.Power(A, B);
    }

    public void Logarithm()
    {
        Result = _controller.Logarithm(A, B);
    }

    public void Root()
    {
        Result = _controller.Root(A, B);
    }

    public void Factorial()
    {
        Result = _controller.Factorial(A);
    }

    public void Sine()
    {
        Result = _controller.Sine(A);
    }

    public void Cosine()
    {
        Result = _controller.Cosine(A);
    }

    public void Tangent()
    {
        Result = _controller.Tangent(A);
    }

    public void Reciprocal()
    {
        Result = _controller.Reciprocal(A);
    }

}