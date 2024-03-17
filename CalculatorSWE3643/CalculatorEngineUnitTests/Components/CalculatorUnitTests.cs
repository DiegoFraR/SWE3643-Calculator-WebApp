using CalculatorEngine;
using CalculatorEngine.Components;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using NUnit.Framework;


namespace CalculatorEngineUnitTests.Components;

[TestFixture]
public class CalculatorUnitTests
{
    //Addition Test
    
    //preq-UNIT-TEST-2
    [Test]
    public void CalculatorAddition_AddTwoIntegers_Add()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 5.5;
        double b = -3.15;
        
        //Act
        result.Result = Calculator.Addition(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(2.35));

    }
    
    //Subtraction Test
    
    //preq-UNIT-TEST-3
    [Test]
    public void CalculatorSubtraction_SubtractTwoIntegers_Subtraction()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 27.93;
        double b = 4;
        
        //Act
        result.Result = Calculator.Subtraction(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(23.93));
    }
    
    //Multiplication
    
    //preq-UNIT-TEST-4
    [Test]
    public void CalculatorMultiplication_MultiplyTwoIntegers_Multiplication()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 5;
        double b = 7.1;
        
        //Act
        result.Result = Calculator.Multiplication(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(35.5));
    }

    //Division Tests
    
    //preq-UNIT-TEST-5
    [Test]
    //Need to set up Equality Method to make this test pass
    public void CalculatorDivision_DivideTwoIntegers_Divide()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 3.0;
        double b = 9.0;
        
        //Act
        result.Result = Calculator.Division(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(.33333333));
    }
    
    //preq-UNIT-TEST-6
    [Test]
    public void CalculatorDivision_DivisionByZero_ThrowsDivisionByZeroError()
    {
        //Arrange
        double a = 3.0;
        double b = 0;
        
        //Act + Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Division(a, b));
    }
    
    
    //Add Equivalence Test Here
    
    
    //Raise To Power Test
    
    //preq-UNIT-TEST-8
    [Test]
    public void CalculatorPower_RaiseToPower_Power()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 2.0;
        double b = 3.0;
        
        //Act
        result.Result = Math.Pow(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(8));
    }
    
    
    //Logarithm Tests
    
    //preq-UNIT-TEST-9
    [Test]
    public void CalculatorLogarithm_ALogB_Logarithm()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 8;
        double b = 2;
        
        //Act
        result.Result = Math.Log(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(3));
    }

    
    //preq-UNIT-TEST-10
    [Test]
    public void CalculatorLogarithm_ALessThanOREqualToZero_ThrowsNaNError()
    {
        //Arrange
        double a = 0;
        double b = 2;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Logarithm(a, b));
    }

    //preq-UNIT-TEST-11
    [Test]
    public void CalculatorLogarithm_BEqualsZero_ThrowsNaNError()
    {
        //Arrange
        double a = 8;
        double b = 0;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Logarithm(a, b));
    }
    
    
    //Root Tests
    
    //preq-UNIT-TEST-12
    [Test]
    public void CalculatorRoot_BthRootOfA_Root()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 8.0;
        double b = 3.0;
        
        //Act
        result.Result = Calculator.Root(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(2));
    }

    //preq-UNIT-TEST-13
    [Test]
    public void CalculatorRoot_BEqualsZero_ThrowsNaNError()
    {
        //Arrange
        double a = 8.0;
        double b = 0;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Root(a, b));
    }
    
    //Factorial Test(s)
    
    //preq-UNIT-TEST-14
    [Test]
    public void CalculatorFactorial_FactorialOfA_Factorial()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 5; 
        
        //Act
        result.Result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(120));
    }

    //preq-UNIT-TEST-Personal
    [Test]
    public void CalculatorFactorial_NegativeFactorialOfA_NegativeFactorial()
    {
        //Arrange
        var result = new CalculationResult();
        double a = -5;
        
        //Act
        result.Result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(-120));
    }

    //preq-UNIT-TEST-15
    [Test]
    public void CalculatorFactorial_FactorialOfZero_ReturnsOne()
    {
        //Arrange
        var result = new CalculationResult();
        double a = 0;
        
        //Act 
        result.Result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(1));
    }
    
    

}