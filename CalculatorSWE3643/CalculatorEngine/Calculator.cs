namespace CalculatorEngine;

public class Calculator : ICalculatorEngine
{
    private static readonly CalculationResult Result= new CalculationResult();
    
    //Addition
    public CalculationResult Add(double a, double b)
    {
        Result.Result = a + b;
        Result.Operation = a + " + " + b;
        Result.IsSuccess = true;

        return Result;
    }

    //Subtraction
    public CalculationResult Subtract(double a, double b)
    {
        Result.Result = a - b;
        Result.Operation = a + " - " + b;
        Result.IsSuccess = true;
        return Result;
    }

    //Multiplication
    public CalculationResult Multiplication(double a, double b)
    {
        Result.Result = a * b;
        Result.Error = "";
        Result.Operation = a + " x " + b;
        Result.IsSuccess = true;

        return Result;
    }

    //Division
    public CalculationResult Division(double a, double b)
    {
        if (b == 0)
        {
            Result.Error = "Cannot Divide by 0";
            Result.IsSuccess = false;
            throw new DivideByZeroException();
        }
        else
        {
            Result.Result = a / b;
            Result.Operation = a + " / " + b;
            Result.IsSuccess = true;
            return Result;
        }
    }
    
    //Equivalence
    public CalculationResult Equals(double a, double b)
    {
        if (Math.Abs(a - b) < 0.000000001)
        {
            Result.Result = 1;
            Result.Operation = a + " == " + b;
            Result.IsSuccess = true;
            return Result;
        }
        else
        {
            Result.Result = 0;
            Result.Operation = a + " == " + b;
            Result.IsSuccess = true;
            return Result;
        }
    }
    
    //Raise To Power
    public CalculationResult Power(double a, double b)
    {
        Result.Result = Math.Pow(a, b);
        Result.Operation = a + " ^ " + b;
        Result.IsSuccess = true;
        return Result;
    }
    
    //Logarithm
    public CalculationResult Logarithm(double a, double b)
    {
        switch (a)
        {
            case <= 0:
                Result.IsSuccess = false;
                Result.Error = "Value of A cannot be equal to or less than 0!";
                throw new NotFiniteNumberException();
            default:
            {
                switch (b)
                {
                    case 0:
                        Result.IsSuccess = false;
                        Result.Error = "Value of B cannot equal 0!";
                        throw new NotFiniteNumberException();
                    default:
                        Result.Result = Math.Log(a, b);
                        Result.Operation = a + " log " + b;
                        Result.IsSuccess = true;
                        return Result;
                        
                }
            }
        }
    }
    
    //Root
    public CalculationResult Root(double a, double b)
    {
        if (b == 0)
        {
            Result.IsSuccess = false;
            Result.Error = "Value of B cannot be 0!";
            throw new NotFiniteNumberException();
        }
        else
        {
            //This does nth root of A. Root of A by B is the same as raising A to the power of 1/B
            Result.Result = Math.Pow(a, 1 / b);
            Result.Operation = a + " root " + b;
            Result.IsSuccess = true;
            return Result;
        }
    }
    
    //Factorial
    public CalculationResult Factorial(double a)
    {
        if (a == 0)
        {
            Result.Result = 1;
            Result.Operation = "Factorial of " + a;
            Result.IsSuccess = true;
            return Result;
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
            return Result;
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
            return Result;
        }
    }

    //Help Method for Factorial of Negatives
    private static bool IsFactorialNegative(double a)
    {
        return (a < 0);
    }
    
    //Sine
    public CalculationResult Sine(double a)
    {
        a = ConvertToRadians(a);
        Result.Result = Math.Round(Math.Sin(a), 0);
        Result.Operation = "Sin (" + a + ") ";
        Result.IsSuccess = true;
        return Result;
    }
    
    //Helper Method for Sin & Cosine & Tangent
    private static double ConvertToRadians(double degrees)
    {
        double radians = Math.Round((degrees * Math.PI) / 180, 0);
        return radians;
    }
    
    //Cosine
    public CalculationResult Cosine(double a)
    {
        a = ConvertToRadians(a);
        Result.Result = Math.Round(Math.Cos(a), 0);
        Result.Operation = "Cos (" + a + ") ";
        Result.IsSuccess = true;
        return Result;
    }
    
    //Tangent
    public CalculationResult Tangent(double a)
    {
        a = ConvertToRadians(a);
        Result.Result = Math.Round(Math.Tan(a), 0);
        Result.Operation = "Tan (" + a + ") ";
        Result.IsSuccess = true;
        return Result;
    }
    
    //Reciprocal
    public CalculationResult Reciprocal(double a)
    {
        if (a == 0)
        {
            Result.IsSuccess = false;
            Result.Error = "Cannot Divide by 0!";
            throw new NotFiniteNumberException();
        }
        else
        {
            Result.Result = 1 / a;
            Result.Operation = "Reciprocal " + a;
            Result.IsSuccess = true;
            return Result;
        }
    }
}