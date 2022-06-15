using MOF.ECore;

namespace MOF.Impl
{
    public sealed class EParameterImpl : ETypedElementImpl, EParameter
    {
        public EOperation EOperation => throw new NotImplementedException();

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
