using MOF.Common;
using MOF.ECore;
using MOF.Impl;

namespace MOF.Tests
{
    public abstract class ElementTestFixture<TElement, TElemetBuilder> 
        where TElement : EObject 
        where TElemetBuilder : ElementBuilder<TElement>, new()
    {
        protected readonly TElemetBuilder builder;

        protected readonly EFactory eFactory = new DefaultEFactory();

        public ElementTestFixture()
        {
            builder = new();
        }
    }
}
