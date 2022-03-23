using MOF.Common;
using MOF.Common.Util;
using MOF.ECore.Resources;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EObject.java
    public interface EObject : Notifier
    {
        EClass eClass();
        
        Resource eResource();
        
        EObject eContainer();
        
        EStructuralFeature eContainingFeature();
        
        EReference eContainmentFeature();

        EList<EObject> eContents();
        
        IEnumerable<EObject> eAllContents();
        
        bool eIsProxy();
        
        EList<EObject> eCrossReferences();
        
        object eGet(EStructuralFeature feature);
        
        object eGet(EStructuralFeature feature, bool resolve);
        
        void eSet(EStructuralFeature feature, object newValue);
        
        bool eIsSet(EStructuralFeature feature);
        
        void eUnset(EStructuralFeature feature);

        object eInvoke(EOperation operation, EList<object> arguments);
    }
}
