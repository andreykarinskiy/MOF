using MOF.ECore;

namespace MOF.Impl
{
    public sealed class EAnnotationImpl : EModelElementImpl, EAnnotation
    {
        private readonly Lazy<IDictionary<string, string>> details = new (() => new Dictionary<string, string>());

        public string Source { get; set; } = string.Empty;

        public IDictionary<string, string> Details => details.Value;

        public EModelElement? EModelElement { get; set; }
        
        public IList<EObject> Contents => throw new NotImplementedException();

        public IList<EObject> References => throw new NotImplementedException();
    }
}
