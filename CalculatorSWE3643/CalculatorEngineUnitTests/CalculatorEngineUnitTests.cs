using CalculatorEngine;
namespace CalculatorEngineUnitTests;

public class Tests
{
    private ICalculatorEngine _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }
    
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
        var result = _calculator.Add(a, b);
        
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
        var result = _calculator.Subtract(a, b);
        
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
        var result = _calculator.Multiplication(a, b);
        
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
        var result = _calculator.Division(a, b);
        result.Result = Math.Round(result.Result, 8);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    
    //preq-UNIT-TEST-6
    [Test]
    public void CalculatorDivision_DivisionByZero_ThrowsDivideByZeroErrorMessage()
    {
        //Arrange
        const double a = 3.0;
        const double b = 0.0;
        const string expected = "Cannot Divide by 0";
        
        //Act
        var result = _calculator.Division(a, b);
        
        //Assert
        Assert.That(result.Error, Is.EqualTo(expected));
        
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
        var result = _calculator.Equals(a, b);
        
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
        var result = _calculator.Equals(a, b);
        
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
        var result = _calculator.Power(a, b);
        
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
        var result = _calculator.Logarithm(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(3));
    }
    
    //preq-UNIT-TEST-10
    [Test]
    public void CalculatorLogarithm_ALessThanZero_ThrowsNanErrorMessage()
    {
        //Arrange
        const double a = -3;
        const double b = 2;
        const string expected = "Value of A cannot be equal to or less than 0!";
        
        //Act
        var result = _calculator.Logarithm(a, b);
        //Assert
        Assert.That(result.Error, Is.EqualTo(expected));

    }
    
    //preq-UNIT-TEST-10A
    [Test]
    public void CalculatorLogarithm_AEqualToZero_ThrowsNaNError()
    {
        //Arrange
        const double a = 0;
        const double b = 2;
        const string expected = "Value of A cannot be equal to or less than 0!";
        
        //Act
        var result = _calculator.Logarithm(a, b);
        //Assert
        Assert.That(result.Error, Is.EqualTo(expected));
    }
    
    //preq-UNIT-TEST-11
    [Test]
    public void CalculatorLogarithm_BEqualsZero_ThrowsNaNError()
    {
        //Arrange
        const double a = 8.0;
        const double b = 0;
        const string expected = "Value of B cannot equal 0!";
        
        //Act
        var result = _calculator.Logarithm(a, b);
        
        //Assert
        Assert.That(result.Error, Is.EqualTo(expected));
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
        var result = _calculator.Root(a, b);
        
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
        const string expected = "Value of B cannot be 0!";
        
        //Act
        var result = _calculator.Root(a, b);
        
        //Assert
        Assert.That(result.Error, Is.EqualTo(expected));
    }
    
    //Factorial Tests
    
    
    //preq-UNIT-TEST-14
    [Test]
    public void CalculatorFactorial_FactorialOfA_ReturnsFactorial()
    {
        //Arrange
        const double a = 5;
        
        //Act
        var result = _calculator.Factorial(a);
        
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
        var result = _calculator.Factorial(a);
        
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
        var result = _calculator.Factorial(a);
        
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
        var result = _calculator.Sine(a);
        
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
        var result = _calculator.Cosine(a);
        
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
        var result = _calculator.Tangent(a);
        
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
        var result = _calculator.Reciprocal(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(0.125));
    }
    
    //preq-UNIT-TEST-20
    [Test]
    public void CalculatorReciprocal_ReciprocalOfZero_ReturnsNaNError()
    {
        //Arrange
        const double a = 0;
        const string expected = "Cannot Divide by 0!";
        
        //Act
        var result = _calculator.Reciprocal(a);
        //Act + Assert
        Assert.That(result.Error, Is.EqualTo(expected));
    }
}