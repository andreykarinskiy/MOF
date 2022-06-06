using MOF.Common;
using MOF.ECore;

namespace MOF.Tests
{
    public abstract class ElementTestFixture<TElement, TElemetBuilder> 
        where TElement : EObject 
        where TElemetBuilder : ElementBuilder<TElement>, new()
    {
        protected readonly TElemetBuilder builder;

        public ElementTestFixture()
        {
            builder = new();
        }
    }
}
