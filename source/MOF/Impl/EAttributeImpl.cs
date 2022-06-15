using MOF.ECore;

namespace MOF.Impl
{
    public sealed class EAttributeImpl : EStructuralFeatureImpl, EAttribute
    {
        public EDataType EAttributeType => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
