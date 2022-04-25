using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EObject
    {
        EClass eClass { get; }

        //Resource eResource { get; }

        EObject eContainer { get; }

        EStructuralFeature eContainingFeature { get; }

        EReference eContainmentFeature { get; }

        IList<EObject> eContents { get; }

        IEnumerable<EObject> eAllContents { get; }

        bool eIsProxy { get; }

        IList<EObject> eCrossReferences { get; }

        object eGet(EStructuralFeature feature);

        object eGet(EStructuralFeature feature, bool resolve);

        void eSet(EStructuralFeature feature, object newValue);

        bool eIsSet(EStructuralFeature feature);

        void eUnset(EStructuralFeature feature);

        object eInvoke(EOperation operation, IList<object> arguments);
    }
}
