using CalculatorEngine.Components;

namespace CalculatorEngine;

public static class Calculator
{
    private static readonly CalculationResult Result = new CalculationResult();

    //Addition
    public static double Addition(double a, double b)
    {
        Result.Result = a + b;
        Result.Operation = a + " + " + b;
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Subtraction
    public static double Subtraction(double a, double b)
    {
        Result.Result = a - b;
        Result.Operation = a + " - " + b;
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Multiplication
    public static double Multiplication(double a, double b)
    {
        Result.Result = a * b;
        Result.Operation = a + " * " + b;
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Division
    public static double Division(double a, double b)
    {
        if (b == 0)
        {
            Result.IsSuccess = false;
            throw new  DivideByZeroException();
        }
        else
        {
            Result.Result = a / b;
            Result.Operation = a + " / " + b;
            Result.IsSuccess = true;
            return Result.Result;
        }
    }
    
    //Equivalence
    public static bool IsEqual(double a, double b)
    {
        if (Math.Abs(a - b) < 0.000000001)
        {
            return true;
        }
        else
        {
            Result.Operation = a + " = " + b + "?";
            return false;
        }
    }
    
    //Raise To Power
    public static double Power(double a, double b)
    {
        Result.Result = Math.Pow(a, b);
        Result.Operation = a + " ^ " + b;
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Logarithm
    public static double Logarithm(double a, double b)
    {
        switch (a)
        {
            case <= 0:
                Result.IsSuccess = false;
                throw new NotFiniteNumberException();
            default:
            {
                switch (b)
                {
                    case 0:
                        Result.IsSuccess = false;
                        throw new NotFiniteNumberException();
                    default:
                        Result.Result = Math.Log(a, b);
                        Result.Operation = a + " log " + b;
                        Result.IsSuccess = true;
                        return Result.Result;
                }
            }
        }
    }
    
    //Root
    public static double Root(double a, double b)
    {
        if (b == 0)
        {
            Result.IsSuccess = false;
            throw new NotFiniteNumberException();
        }
        else
        {
            //This does nth root of A. Root of A by B is the same as raising A to the power of 1/B
            Result.Result = Math.Pow(a, 1 / b);
            Result.Operation = a + " root " + b;
            Result.IsSuccess = true;
            return Result.Result;

        }
    }
    
    //Factorial
    public static double Factorial(double a)
    {
        
        if (a == 0)
        {
            return 1;
        }
        else if (a < 0 && IsFactorialNegative(a))
        {
            int fact = -1;
            a *= -1; 
            for (int i = 1; i <= a; i++)
            {
                fact *= i; 
            }

            Result.Result = fact;
            Result.Operation = a + "!";
            Result.IsSuccess = true;
            return Result.Result;
        }
        else
        {
            int fact = 1;

            for (int i = 1; i <= a; i++)
            {
                fact *= i; 
            }

            Result.Result = fact;
            Result.Operation = a + "!";
            Result.IsSuccess = true;
            return Result.Result;
        }
    }
    
    //Help Method For Factorial
    private static bool IsFactorialNegative(double a)
    {
        double remainder = a % 2;
        if (!(Math.Abs(remainder - 1) < 0.000001) && Math.Abs(remainder - (-1)) > 0.000001)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Sine
    public static double Sine(double a)
    {
        Result.Result = Math.Sin(a);
        Result.Operation = "Sin (" + a + ") ";
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Cosine
    public static double Cosine(double a)
    {
        Result.Result = Math.Cos(a);
        Result.Operation = "Cos (" + a + ") ";
        Result.IsSuccess = true;
        return Result.Result;
    } 
    
    //Tangent
    public static double Tangent(double a)
    {
        Result.Result = Math.Tan(a);
        Result.Operation = "Tan (" + a + ") ";
        Result.IsSuccess = true;
        return Result.Result;
    }
    
    //Reciprocal 
    public static double Reciprocal(double a)
    {
        if (a == 0)
        {
            Result.IsSuccess = false;
            throw new NotFiniteNumberException();
        }
        else
        {
            Result.Result = 1/a;
            Result.Operation = "Reciprocal " + a;
            Result.IsSuccess = true;
            return Result.Result;
        }
    }

}