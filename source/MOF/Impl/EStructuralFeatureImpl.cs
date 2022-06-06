using MOF.ECore;

namespace MOF.Impl
{
    public abstract class EStructuralFeatureImpl : ETypedElementImpl, EStructuralFeature
    {
        public bool IsTransient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsVolatile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsChangeable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DefaultValueLiteral { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object DefaultValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsUnsettable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDerived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EClass EContainingClass => throw new NotImplementedException();

        public int FeatureID => throw new NotImplementedException();

        public Type ContainerClass => throw new NotImplementedException();

        public bool IsFeatureMap => throw new NotImplementedException();

        public bool IsID => throw new NotImplementedException();

        public bool IsResolveProxies => throw new NotImplementedException();

        //public bool IsContainer => throw new NotImplementedException();

        public bool IsContainment => throw new NotImplementedException();

        //public EReference EOpposite => throw new NotImplementedException();
    }
}
