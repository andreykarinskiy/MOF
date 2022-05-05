using MOF.ECore;

namespace MOF.Impl
{
    public abstract class EObjectImpl : EObject
    {
        public EClass EClass => throw new NotImplementedException();

        public EObject EContainer => throw new NotImplementedException();

        public EStructuralFeature EContainingFeature => throw new NotImplementedException();

        public EReference EContainmentFeature => throw new NotImplementedException();

        public IList<EObject> EContents => throw new NotImplementedException();

        public IEnumerable<EObject> EAllContents => throw new NotImplementedException();

        public bool EIsProxy => throw new NotImplementedException();

        public IList<EObject> ECrossReferences => throw new NotImplementedException();

        public object EGet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public object EGet(EStructuralFeature feature, bool resolve)
        {
            throw new NotImplementedException();
        }

        public object EInvoke(EOperation operation, IList<object> arguments)
        {
            throw new NotImplementedException();
        }

        public bool EIsSet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public void ESet(EStructuralFeature feature, object newValue)
        {
            throw new NotImplementedException();
        }

        public void EUnset(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public abstract void Accept(IEcoreVisitor visitor);
    }
}
