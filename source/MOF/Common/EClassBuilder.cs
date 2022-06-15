using MOF.ECore;
using MOF.Impl;

namespace MOF.Common
{
    public sealed class EClassBuilder : ElementBuilder<EClass>
    {
        public EClassBuilder(EFactory factory) : base(factory)
        {
        }

        public EClassBuilder() : this(new DefaultEFactory())
        {
        }

        public EClassBuilder Owner(EPackage ownerPackage)
        {
            product.EPackage = ownerPackage;
            ownerPackage.EClassifiers.Add(product);

            return this;
        }

        public EClassBuilder Named(string className)
        {
            product.Name = className;

            return this;
        }

        public EClassBuilder Documentation(string text)
        {
            var builder = new EAnnotationBuilder(eFactory);

            // TODO Нужно выяснить правильное значение для документации.
            //builder.Source("???");

            builder.AddDocumentation(text);
            builder.ToElement(product);

            return this;
        }

        public EClassBuilder Inherits(params EClass[] ancestors)
        {
            foreach (var type in ancestors)
            {
                product.ESuperTypes.Add(type);
            }

            return this;
        }

        public EClassBuilder IsAbstract(bool value)
        {
            product.IsAbstract = value;

            return this;
        }

        protected override EClass CreateInstance(EFactory factory) => factory.CreateEClass();
    }
}
