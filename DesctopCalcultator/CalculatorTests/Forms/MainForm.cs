using CalculatorTests.Menus;
using Framework.TestStackWhite;
using Framework.TestStackWhite.Elements;
using TestStack.White.UIItems.Finders;
using System;

namespace CalculatorTests.Forms
{
    public class MainForm: BaseForm
    {
        private FButton btnAdd = new FButton("Add", "93");         

        private FButton btnEquals = new FButton("Equals", "121");

        private FButton btnMemoryRecall = new FButton("Memory Recall", "123");

        private FButton btnMemoryAdd = new FButton("Memory Add", "125");        

        private FButton btnNumberOne = new FButton("Number 1", "131");

        private FButton btnNumberTwo = new FButton("Number 2", "132");

        private FButton btnNumberNine = new FButton("Number 9", "139");

        private FLabel lblResultText = new FLabel("Result text", "158");

        public MainMenu mainMenu = new MainMenu();

        public MainForm(): base("Main calculator form", SearchCriteria.ByAutomationId("123"))
        {
            
        }        

        public int GetCalculationResult()
        {            
            return Int32.Parse(lblResultText.GetText());
        }

        public void PushAdd()
        {
            btnAdd.Click();
        }

        public void PushEquals()
        {
            btnEquals.Click();
        }

        public void PushMemoryAdd()
        {
            btnMemoryAdd.Click();
        }

        public void PushMemoryRecall()
        {
            btnMemoryRecall.Click();
        }

        public void EnterNumber(int number)
        {
            foreach(char charapter in number.ToString())
            {
                PushToNumberButton((int)Char.GetNumericValue(charapter));
            }
        }

        public void PushToNumberButton(int number)
        {
            switch (number)
            {
                case 1:
                    btnNumberOne.Click();
                    break;

                case 2:
                    btnNumberTwo.Click();
                    break;

                case 9:
                    btnNumberNine.Click();
                    break;

                default:
                    break;                    
            }
        }
    }
}
