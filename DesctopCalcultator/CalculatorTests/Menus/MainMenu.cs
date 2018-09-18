using Framework.TestStackWhite;
using Framework.TestStackWhite.Elements;

namespace CalculatorTests.Menus
{
    public class MainMenu: FMenu
    {
        public MainMenu(): base()
        {
            MainMenuBar = new FMenuBar("Main menu", "MenuBar");
        }    
    }
}
