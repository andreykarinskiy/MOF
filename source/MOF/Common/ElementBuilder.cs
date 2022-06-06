using MOF.ECore;

namespace MOF.Common
{
    public abstract class ElementBuilder<TElement> where TElement : EObject
    {
        protected TElement product;

        public ElementBuilder(EFactory factory)
        {
            product = CreateInstance(factory);
        }

        protected abstract TElement CreateInstance(EFactory factory);

        public TElement Build()
        {
            return product;
        }
    }
}
