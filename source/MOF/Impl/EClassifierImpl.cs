using MOF.ECore;

namespace MOF.Impl
{
    public abstract class EClassifierImpl : ENamedElementImpl, EClassifier
    {
        public string InstanceClassName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Type InstanceClass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object DefaultValue => throw new NotImplementedException();

        public EPackage EPackage => throw new NotImplementedException();

        public IList<ETypeParameter> ETypeParameters => throw new NotImplementedException();

        public int ClassifierID => throw new NotImplementedException();

        public string InstanceTypeName { get; set; } = string.Empty;

        public bool IsInstance(object instance)
        {
            throw new NotImplementedException();
        }
    }
}
