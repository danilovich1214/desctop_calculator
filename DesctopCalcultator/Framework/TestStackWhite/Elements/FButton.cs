using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Framework.TestStackWhite.Elements
{
    public class FButton: BaseElement<Button>
    {
        public FButton(string elementName, SearchCriteria searchCriteria) : base(elementName, searchCriteria)
        {

        }

        public FButton(string elementName, string automationId) : base(elementName, automationId)
        {

        }

        public override string GetElementType()
        {
            return "Button";
        }
    }
}
