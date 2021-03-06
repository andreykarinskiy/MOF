using MOF.ECore;

namespace MOF.Impl
{
    public sealed class EPackageImpl : ENamedElementImpl, EPackage
    {
        private const string eNS_URI = "http://www.eclipse.org/emf/2002/Ecore";
        private const string eNS_PREFIX = "ecore";

        private readonly Lazy<IList<EPackage>> subPackages = new(() => new List<EPackage>());
        private readonly Lazy<IList<EClassifier>> classifiers = new(() => new List<EClassifier>());

        public string NsURI { get; set; } = eNS_URI;

        public string NsPrefix { get; set; } = eNS_PREFIX;

        public EFactory? EFactoryInstance { get; set; }

        public IList<EClassifier> EClassifiers => classifiers.Value;

        public IList<EPackage> ESubpackages => subPackages.Value;

        public EPackage? ESuperPackage { get; set; }

        public override void Accept(IEcoreVisitor visitor)
        {
            visitor.Visit(this);
        }

        public EClassifier GetEClassifier(string name)
        {
            throw new NotImplementedException();
        }
    }
}
