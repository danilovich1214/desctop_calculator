using Framework.TestStackWhite;
using Framework.Utils;
using TechTalk.SpecFlow;

namespace CalculatorTests.Hooks
{
    [Binding]
    public class CalculatorHooks
    {
        [BeforeScenario]
        public void CheckOpenedCalculatorInstances()
        {
            ProcessesUtil.CloseProcessesByName(Configuration.ProcessName);
        }

        [AfterScenario]
        public void CloseApplication()
        {
            Screenshoter.TakeFullScreenshot();
            FApplication.Instance.CloseApplication();
        }
    }
}
