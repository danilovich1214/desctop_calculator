using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Framework.TestStackWhite.Elements
{
    public abstract class BaseElement<T>: BaseEntity where T: UIItem
    {
        protected readonly string ElementName;

        protected SearchCriteria SearchCriteria;

        protected BaseElement(string elementName, SearchCriteria searchCriteria)
        {
            ElementName = elementName;
            SearchCriteria = searchCriteria;            
        }

        protected BaseElement(string elementName, string automationId)
        {            
            ElementName = elementName;
            SearchCriteria = SearchCriteria.ByAutomationId(automationId);
        }

        public string GetElementName()
        {
            return ElementName;
        }

        protected T GetElement() => FApplication.Instance.CurrentWindow.Get<T>(SearchCriteria);

        public static UIItem GetUIItemBySearchCriteria(SearchCriteria searchCriteria)
        {
            return (UIItem)FApplication.Instance.CurrentWindow.Get(searchCriteria);
        }

        public void Click()
        {
            Info("Click()");            
            GetElement().Click();
        }

        public string GetText()
        {
            Info("GetText()");
            string text = GetElement().Name;
            Info($"Element text = {text}");
            return text;
        }

        public abstract string GetElementType();

        protected override string FormatLogMsg(string message)
        {
            return string.Format("{0} {1} {2} {3}", ElementName, GetElementType(), Logger.LogDelimiter, message);
        }
    }
}
