using Framework.TestStackWhite.Elements;
using TestStack.White.UIItems.MenuItems;

namespace Framework.TestStackWhite
{
    public class FMenu : BaseEntity
    {
        protected static FMenuBar MainMenuBar;
        
        private Menu _currentMenu;

        private string _pathToMenuItem;

        public FMenu()
        {

        }

        public FMenu(Menu currentMenu, string pathToMenu)
        {
            _currentMenu = currentMenu;
            _pathToMenuItem = pathToMenu;
        }

        public FMenu OpenSubMenu(params string[] pathToMenu)
        {
            Menu subMenu = MainMenuBar.GetMenuItem(pathToMenu);
            Info($"Open sub menu by path {string.Join(CommonConstants.MenuPathSeparator, pathToMenu)}");
            subMenu.Click();
            return new FMenu(subMenu, pathToMenu.ToString());
        }

        public string GetPathToMenuItem()
        {
            return _pathToMenuItem;
        }

        protected override string FormatLogMsg(string message)
        {
            return message;
        }
    }
}
