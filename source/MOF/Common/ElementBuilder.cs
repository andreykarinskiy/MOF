using MOF.ECore;

namespace MOF.Common
{
    public abstract class ElementBuilder<TElement> where TElement : EObject
    {
        protected TElement product;
        protected EFactory eFactory;

        public ElementBuilder(EFactory factory)
        {
            eFactory = factory;
            product = CreateInstance(eFactory);
        }

        protected abstract TElement CreateInstance(EFactory factory);

        public TElement Build()
        {
            return product;
        }
    }
}
