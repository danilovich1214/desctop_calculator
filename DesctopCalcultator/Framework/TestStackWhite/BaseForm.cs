using Framework.TestStackWhite.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Framework.TestStackWhite
{
    public class BaseForm: BaseEntity
    {
        protected string FormName;

        protected SearchCriteria SearchCriteria;        

        protected BaseForm(string formName, SearchCriteria searchCriteria)
        {
            FormName = formName;
            SearchCriteria = searchCriteria;            
        }

        public void AssertIsOpen()
        {
            Info("Assertion that form is open by searching element");
            var element = BaseElement<UIItem>.GetUIItemBySearchCriteria(SearchCriteria);            
            Assert.IsNotNull(element, "No such element");
            Assert.IsTrue(element.Visible, "element is not visible");
            Info("Form is open");
        }

        protected override string FormatLogMsg(string message)
        {
            return string.Format("{0} {1} {2}", FormName, Logger.LogDelimiter, message);
        }
    }
}
