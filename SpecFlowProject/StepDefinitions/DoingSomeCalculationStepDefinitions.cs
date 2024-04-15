using Microsoft.VisualStudio.TestPlatform.ObjectModel.Host;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class DoingSomeCalculationStepDefinitions
    {
        public int num1, num2, op;
        [Given(@"I have nos as ""([^""]*)"" and ""([^""]*)""")]
        public void GivenIHaveNosAsAnd(string p0, string p1)
        {
            num1 = Convert.ToInt32(p0);
            num2 = Convert.ToInt32(p1);
        }

        [When(@"I add those nos")]
        public void WhenIAddThoseNos()
        {
            op=num1 + num2;
        }
        [Then(@"I should print the result")]
        public void ThenIShouldPrintTheResult()
        {
            Console.WriteLine(op);
        }
    }
}
