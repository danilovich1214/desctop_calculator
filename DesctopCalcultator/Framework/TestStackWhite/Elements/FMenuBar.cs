using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;

namespace Framework.TestStackWhite.Elements
{
    public class FMenuBar: BaseElement<MenuBar>
    {
        public FMenuBar(string elementName, SearchCriteria searchCriteria) : base(elementName, searchCriteria)
        {

        }

        public FMenuBar(string elementName, string automationId) : base(elementName, automationId)
        {

        }

        public Menu GetMenuItem(params string[] path)
        {
            return GetElement().MenuItem(path);                        
        }

        public Menu GetMenuItemBy(params SearchCriteria[] searchCriterias)
        {
            return GetElement().MenuItemBy(searchCriterias);
        }

        public override string GetElementType()
        {
            return "MenuBar";
        }
    }
}
