using MOF.ECore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.Impl
{
    public abstract class EObjectImpl : EObject
    {
        public EClass eClass => throw new NotImplementedException();

        public EObject eContainer => throw new NotImplementedException();

        public EStructuralFeature eContainingFeature => throw new NotImplementedException();

        public EReference eContainmentFeature => throw new NotImplementedException();

        public IList<EObject> eContents => throw new NotImplementedException();

        public IEnumerable<EObject> eAllContents => throw new NotImplementedException();

        public bool eIsProxy => throw new NotImplementedException();

        public IList<EObject> eCrossReferences => throw new NotImplementedException();

        public object eGet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public object eGet(EStructuralFeature feature, bool resolve)
        {
            throw new NotImplementedException();
        }

        public object eInvoke(EOperation operation, IList<object> arguments)
        {
            throw new NotImplementedException();
        }

        public bool eIsSet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public void eSet(EStructuralFeature feature, object newValue)
        {
            throw new NotImplementedException();
        }

        public void eUnset(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }
    }
}
