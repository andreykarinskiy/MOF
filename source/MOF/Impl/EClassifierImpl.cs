using MOF.ECore;

namespace MOF.Impl
{
    public abstract class EClassifierImpl : ENamedElementImpl, EClassifier
    {
        public string InstanceClassName { get; set; }

        public Type InstanceClass { get; set; }

        public object DefaultValue => throw new NotImplementedException();

        public EPackage EPackage { get; set; } 

        public IList<ETypeParameter> ETypeParameters => throw new NotImplementedException();

        public int ClassifierID { get; set; }

        public string InstanceTypeName { get; set; } = string.Empty;

        public bool IsInstance(object instance)
        {
            throw new NotImplementedException();
        }
    }
}
