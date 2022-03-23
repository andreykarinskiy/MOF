using MOF.Common.Impl;
using MOF.Common.Util;
using MOF.ECore.Resources;

namespace MOF.ECore.Impl
{
    internal class BasicEObjectImpl : BasicNotifierImpl, EObject, InternalEObject
    {
        public IEnumerable<EObject> eAllContents()
        {
            throw new NotImplementedException();
        }

        public virtual int eBaseStructuralFeatureID(int derivedFeatureID, object baseClass)
        {
            throw new NotImplementedException();
        }

        public virtual EClass eClass()
        {
            throw new NotImplementedException();
        }

        public virtual EObject eContainer()
        {
            throw new NotImplementedException();
        }

        public virtual int eContainerFeatureID()
        {
            throw new NotImplementedException();
        }

        public virtual EStructuralFeature eContainingFeature()
        {
            throw new NotImplementedException();
        }

        public virtual EReference eContainmentFeature()
        {
            throw new NotImplementedException();
        }

        public virtual EList<EObject> eContents()
        {
            throw new NotImplementedException();
        }

        public virtual EList<EObject> eCrossReferences()
        {
            throw new NotImplementedException();
        }

        public virtual int eDerivedOperationID(int baseOperationID, object baseClass)
        {
            throw new NotImplementedException();
        }

        public virtual int eDerivedStructuralFeatureID(int baseFeatureID, object baseClass)
        {
            throw new NotImplementedException();
        }

        public virtual object eGet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public virtual object eGet(EStructuralFeature feature, bool resolve)
        {
            throw new NotImplementedException();
        }

        public virtual object eGet(EStructuralFeature eFeature, bool resolve, bool coreType)
        {
            throw new NotImplementedException();
        }

        public virtual object eGet(int featureID, bool resolve, bool coreType)
        {
            throw new NotImplementedException();
        }

        public virtual InternalEObject eInternalContainer()
        {
            throw new NotImplementedException();
        }

        public virtual object eInvoke(EOperation operation, EList<object> arguments)
        {
            throw new NotImplementedException();
        }

        public virtual object eInvoke(int operationID, EList<object> arguments)
        {
            throw new NotImplementedException();
        }

        public virtual bool eIsProxy()
        {
            throw new NotImplementedException();
        }

        public virtual bool eIsSet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public virtual bool eIsSet(int featureID)
        {
            throw new NotImplementedException();
        }

        public bool eNotificationRequired()
        {
            throw new NotImplementedException();
        }

        public EObject eObjectForURIFragmentSegment(string uriFragmentSegment)
        {
            throw new NotImplementedException();
        }

        public Uri eProxyURI()
        {
            throw new NotImplementedException();
        }

        public EObject eResolveProxy(InternalEObject proxy)
        {
            throw new NotImplementedException();
        }

        public virtual Resource eResource()
        {
            throw new NotImplementedException();
        }

        public virtual void eSet(EStructuralFeature feature, object newValue)
        {
            throw new NotImplementedException();
        }

        public virtual void eSet(int featureID, object newValue)
        {
            throw new NotImplementedException();
        }

        public virtual void eSetClass(EClass eClass)
        {
            throw new NotImplementedException();
        }

        public void eSetProxyURI(Uri uri)
        {
            throw new NotImplementedException();
        }

        public virtual void eUnset(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public virtual void eUnset(int featureID)
        {
            throw new NotImplementedException();
        }

        public string eURIFragmentSegment(EStructuralFeature eFeature, EObject eObject)
        {
            throw new NotImplementedException();
        }
    }
}
