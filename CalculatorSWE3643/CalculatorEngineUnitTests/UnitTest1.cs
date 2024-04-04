using CalculatorEngine;

namespace CalculatorEngineUnitTests;

public class Tests
{
    //Addition Test
    
    //preq-UNIT-TEST-2
    [Test]
    public void CalculatorAddition_TwoFloatingPointValues_ReturnsSum()
    {
        //Arrange
        const double a = 1.5;
        const double b = 2.75;
        const double expected = 4.25;

        //Act
        var result = Calculator.Add(a,b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    //Subtraction Test
    
    //preq-UNIT-TEST-3
    [Test]
    public void CalculatorSubtraction_TwoFloatingPointValues_ReturnsDifference()
    {
        //Arrange
        const double a = 27.93;
        const double b = 4;
        const double expected = 23.93;
        //Act
        var result = Calculator.Subtract(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    //Multiplication Test
    
    //preq-UNIT-TEST-4
    [Test]
    public void CalculatorMultiplication_TwoFloatingPointValues_ReturnsMultiplication()
    {
        //Arrange
        const double a = 5;
        const double b = 7.1;
        const double expected = 35.5;
        
        //Act
        var result = Calculator.Multiplication(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    //Division Tests
    
    //preq-UNIT-TEST-5
    [Test]
    public void CalculatorDivision_TwoFloatingPointValues_ReturnsDivision()
    {
        //Arrange
        const double a = 3.0;
        const double b = 9.0;
        const double expected = 0.33333333;
        
        //Act
        var result = Calculator.Division(a, b);
        result.Result = Math.Round(result.Result, 8);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    
    //preq-UNIT-TEST-6
    [Test]
    public void CalculatorDivision_DivisionByZero_ThrowsDivideByZeroError()
    {
        //Arrange
        const double a = 3.0;
        const double b = 0.0;
        
        //Act + Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Division(a, b));
    }
    
    //Equivalence Test
    
    //preq-UNIT-TEST-7
    [Test]
    public void CalculatorIsEqual_TwoFloatingPointValues_ReturnsTrue()
    {
        //Arrange
        const double a = 0.333333;
        const double b = 0.333333;
        
        //Act
        var result = Calculator.IsEqual(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(1));
    }
    
    //preq-UNIT-TEST-7A
    [Test]
    public void CalculatorIsEqual_TwoFloatingPointValues_ReturnsFalse()
    {
        //Arrange 
        const double a = 0.33333333;
        const double b = 0.33333334;
        
        //Act 
        var result = Calculator.IsEqual(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(0));
    }
    
    //Raise to Power Test
    
    //preq-UNIT-TEST-8
    [Test]
    public void CalculatorPower_RaiseToPower_Power()
    {
        //Arrange
        const double a = 2.0;
        const double b = 3.0;
        const double expected = 8.0;
        
        //Act
        var result = Calculator.Power(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    //Logarithm Tests
    
    //preq-UNIT-TEST-9
    [Test]
    public void CalculatorLogarithm_ALogB_Logarithm()
    {
        //Arrange
        const double a = 8.0;
        const double b = 2.0;
        
        //Act
        var result = Calculator.Logarithm(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(3));
    }
    
    //preq-UNIT-TEST-10
    [Test]
    public void CalculatorLogarithm_ALessThanZero_ThrowsNanError()
    {
        //Arrange
        const double a = -3;
        const double b = 2;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Logarithm(a, b));
    }
    
    //preq-UNIT-TEST-10A
    [Test]
    public void CalculatorLogarithm_AEqualToZero_ThrowsNaNError()
    {
        //Arrange
        const double a = 0;
        const double b = 2;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Logarithm(a, b));
    }
    
    //preq-UNIT-TEST-11
    [Test]
    public void CalculatorLogarithm_BEqualsZero_ThrowsNaNError()
    {
        //Arrange
        const double a = 8.0;
        const double b = 0;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Logarithm(a, b));
    }
    
    //Root Tests
    
    //preq-UNIT-TEST-12
    [Test]
    public void CalculatorRoot_BthRootOfA_ReturnsRoot()
    {
        //Arrange
        const double a = 8.0;
        const double b = 3.0;
        
        //Act
        var result = Calculator.Root(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(2));
    }
    
    //preq-UNIT-TEST-13
    [Test]
    public void CalculatorRoot_BEqualsZero_ThrowsNaNError()
    {
        //Arrange
        const double a = 8;
        const double b = 0;
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Root(a, b));
    }
    
    //Factorial Tests
    
    
    //preq-UNIT-TEST-14
    [Test]
    public void CalculatorFactorial_FactorialOfA_ReturnsFactorial()
    {
        //Arrange
        const double a = 5;
        
        //Act
        var result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(120));
    }
    
    //preq-UNIT-TEST-15
    [Test]
    public void CalculatorFactorial_FactorialOf0_ReturnsOne()
    {
        //Arrange
        const double a = 0;
        
        //Act
        var result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(1));
    }
    
    //preq-UNIT-TEST-NegativeFactorial
    [Test]
    public void CalculatorFactorial_FactorialOfNegativeNumber_ReturnsNegativeFactorial()
    {
        //Arrange
        const double a = -5;
        
        //Act
        var result = Calculator.Factorial(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(-120));
    }
    
    //Sine Test
    
    //preq-UNIT-TEST-16
    [Test]
    public void CalculatorSine_SineOfA_ReturnsSineValue()
    {
        //Arrange
        const double a = 360;
        
        //Act
        var result = Calculator.Sine(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(0));
    }
    
    //Cosine Test
    
    //preq-UNIT-TEST-17
    [Test]
    public void CalculatorCosine_CosineOfA_ReturnsCosineValue()
    {
        //Arrange
        const double a = 360;
        
        //Act
        var result = Calculator.Cosine(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(1));
    }
    
    //Tangent Test
    [Test]
    //preq-UNIT-TEST-18
    public void CalculatorTangent_TanOf360_ReturnsTangentValue()
    {
        //Arrange
        const double a = 360;
        
        //Act
        var result = Calculator.Tangent(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(0));
    }
    
    //Reciprocal Tests
    
    //preq-UNIT-TEST-19
    [Test]
    public void CalculatorReciprocal_ReciprocalOfEight_ReturnsOneOverEight()
    {
        //Arrange
        const double a = 8.0;
        
        //Act
        var result = Calculator.Reciprocal(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(0.125));
    }
    
    //preq-UNIT-TEST-20
    [Test]
    public void CalculatorReciprocal_ReciprocalOfZero_ReturnsNaNError()
    {
        //Arrange
        const double a = 0; 
        
        //Act + Assert
        Assert.Throws<NotFiniteNumberException>(() => Calculator.Reciprocal(a));
    }
}