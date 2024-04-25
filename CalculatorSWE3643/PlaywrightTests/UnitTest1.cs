using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    //preq-E2E-TEST-5
    [Test]
    public async Task CalculatorWebUi_PageTitle_IsCalculator()
    {
        const string pageTitle = "Calculator";

        await Page.GotoAsync("http://localhost:5093/");
        
        await Expect(Page).ToHaveTitleAsync(pageTitle);
    }
    
    //preq-E2E-TEST-6
    [Test]
    public async Task VerifyAdditionOperation()
    {
        //refresh page
        await Page.ReloadAsync();
        
        //load webpage
        await Page.GotoAsync("http://localhost:5093/");
        
        //values into A and B
        await Page.GetByLabel("A", new() { Exact = true }).FillAsync("5");
        await Page.GetByLabel("B", new() { Exact = true }).FillAsync("7");

        //add button
        await Page.GetByLabel("add", new() { Exact = true }).ClickAsync();
        
        //get result
        string result6 = await Page.GetByLabel("result", new() { Exact = true }).TextContentAsync();

        //write to console for verification
        Console.Write("Test 6: ");
        Console.Write(result6);
        
        //string to int
        var actualSum = int.Parse(result6);

        //calculate expected
        var expectedSum = 5 + 7;

        //verify
        Assert.That(actualSum, Is.EqualTo(expectedSum));
    }
    
    //preq-E2E-TEST-7
     [Test]
     public async Task DivideByZeroError()
     {
         //refresh page
         await Page.ReloadAsync();
         
         //load webpage
         await Page.GotoAsync("http://localhost:5093/");
     
         //values into A and B
         await Page.GetByLabel("A", new() { Exact = true }).FillAsync("5");
         await Page.GetByLabel("B", new() { Exact = true }).FillAsync("0");
     
         //divide button
         await Page.GetByLabel("divide", new() { Exact = true }).ClickAsync();
         
         //get result
         string result7 = await Page.GetByLabel("error", new() { Exact = true }).TextContentAsync();

         //write to console for verification
         Console.Write("Test 7: ");
         Console.Write(result7);
         
         //expected error
         var expectedOutput = "Cannot Divide by 0";
     
         //verify
         Assert.That(result7, Is.EqualTo(expectedOutput));
     }
    
    //preq-E2E-TEST-8
    
    
    //preq-E2E-TEST-9
    [Test]
    public async Task ClearPage()
    {
        //refresh page
        await Page.ReloadAsync();
        
        //load webpage
        await Page.GotoAsync("http://localhost:5093/");
        
        //values into A and B
        await Page.GetByLabel("A", new() { Exact = true }).FillAsync("5");
        await Page.GetByLabel("B", new() { Exact = true }).FillAsync("7");
        
        //add button
        await Page.GetByLabel("add", new() { Exact = true }).ClickAsync();
        
        //clear
        await Page.GetByLabel("clear", new() { Exact = true }).ClickAsync();
        
        //get values
        string inputA = await Page.GetByLabel("A", new() { Exact = true }).TextContentAsync();
        string inputB = await Page.GetByLabel("B", new() { Exact = true }).TextContentAsync();
        string label = await Page.GetByLabel("defaultLabel", new() { Exact = true }).TextContentAsync();
        
        //set expected results
        string expectedA = "";
        string expectedB = "";
        string expectedLabel = "Enter values(s) below and select an operation.";
        
        //verify
        Assert.That(inputA, Is.EqualTo(expectedA));
        Assert.That(inputB, Is.EqualTo(expectedB)); 
        Assert.That(label, Is.EqualTo(expectedLabel));
    }
}