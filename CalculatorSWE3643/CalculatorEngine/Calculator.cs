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
        if (remainder == 1 || remainder == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}