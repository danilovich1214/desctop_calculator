using CalculatorTests.Forms;
using CalculatorTests.Menus;
using Framework.TestStackWhite;
using Framework.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CalculatorTests.Steps
{
    [Binding]
    public class CalculatorCalculationSteps
    {
        private MainForm mainForm;

        [Given(@"I open the calculator application in (.*) View")]
        public void GivenIOpenTheCalculatorApplicationInView(string viewName)
        {
            FApplication.Instance.LaunchApplication();
            Assert.IsNotNull(FApplication.Instance.Application, "Application instance is null");            

            mainForm = new MainForm();
            mainForm.AssertIsOpen();
            mainForm.mainMenu.OpenSubMenu(MainMenuItem.View.ToDescription(), viewName);
        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int number)
        {            
            mainForm.EnterNumber(number);            
        }

        [When(@"I add the number (.*)")]
        public void WhenIAddTheNumber(int number)
        {
            mainForm.PushAdd();
            mainForm.EnterNumber(number);
            mainForm.PushEquals();
        }

        [When(@"I add the result to the memory")]
        public void WhenIAddTheResultToTheMemory()
        {
            mainForm.PushMemoryAdd();
        }
        
        [When(@"I add current result to the memory number")]
        public void WhenIAddCurrentResultToTheMemoryNumber()
        {
            mainForm.PushAdd();
            mainForm.PushMemoryRecall();
            mainForm.PushEquals();
        }

        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int number)
        {
            int result = mainForm.GetCalculationResult();
            Assert.AreEqual(number, result, "Incorrect expected result. Numbers don't equals");
        }
    }
}
