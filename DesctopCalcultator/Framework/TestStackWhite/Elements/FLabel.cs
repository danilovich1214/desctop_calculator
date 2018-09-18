using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Framework.TestStackWhite.Elements
{
    public class FLabel: BaseElement<Label>
    {
        public FLabel(string elementName, SearchCriteria searchCriteria) : base(elementName, searchCriteria)
        {
            
        }

        public FLabel(string elementName, string automationId) : base(elementName, automationId)
        {

        }

        public override string GetElementType()
        {
            return "Label";
        }
    }
}
