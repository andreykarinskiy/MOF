using MOF.ECore;

namespace MOF.Impl
{
    public abstract class EModelElementImpl : EObjectImpl, EModelElement
    {
        private readonly Lazy<IList<EAnnotation>> annotations = new(() => new List<EAnnotation>());

        public IList<EAnnotation> EAnnotations => annotations.Value;

        public EAnnotation GetEAnnotation(string source)
        {
            return annotations.Value.Single(o => o.Source == source);
        }
    }
}
