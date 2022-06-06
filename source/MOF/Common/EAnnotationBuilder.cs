using MOF.ECore;
using MOF.Impl;

namespace MOF.Common
{
    public sealed class EAnnotationBuilder : ElementBuilder<EAnnotation>
    {
        public EAnnotationBuilder(EFactory factory) : base(factory)
        {
        }

        public EAnnotationBuilder() : this(new DefaultEFactory())
        {
        }

        public EAnnotationBuilder ToElement(EModelElement target)
        {
            product.EModelElement = target;
            target.EAnnotations.Add(product);

            return this;
        }

        public EAnnotationBuilder Source(string value)
        {
            product.Source = value;

            return this;
        }

        public EAnnotationBuilder AddDetail(string key, string value)
        {
            product.Details.Add(key, value);

            return this;
        }

        public EAnnotationBuilder AddDocumentation(string text)
        {
            const string key = "documentation";
            product.Details.Add(key, text);

            return this;
        }

        protected override EAnnotation CreateInstance(EFactory factory) => factory.CreateEAnnotation();
    }
}
