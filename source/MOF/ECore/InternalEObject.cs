using MOF.Common.Util;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/InternalEObject.java
    public interface InternalEObject : EObject
    {
        /**
   * The base value for negative, i.e., opposite-end, eContainerFeatureID values.
   */
        const int EOPPOSITE_FEATURE_BASE = -1;
        /**
         * Returns whether {@link org.eclipse.emf.common.notify.Notifier#eNotify eNotify} needs to be called.
         * <p>
         * This may return <code>true</code> even when {@link org.eclipse.emf.common.notify.Notifier#eDeliver eDeliver} is <code>false</code>
         * or when {@link org.eclipse.emf.common.notify.Notifier#eAdapters eAdapters} is empty.
         * <p>
         * @return <code>true</code> if eNotify needs to be called.
         */
        bool eNotificationRequired();
        /**
         * Returns the fragment segment that, 
         * when passed to {@link #eObjectForURIFragmentSegment eObjectForURIFragmentSegment},
         * will resolve to the given object in this object's given feature.
         * <p>
         * The feature argument may be <code>null</code> in which case it will be deduced, if possible.
         * The default result will be of the form:
         *<pre>
         *  "@&lt;feature-name>[.&lt;index>]"
         *</pre>
         * The index is used only for {@link ETypedElement#isMany() many-valued} features;
         * it represents the position within the list.
         * </p>
         * <p>
         * Given given an <code>eObject</code> present in the <code>eFeature</code> of some other {@link InternalEObject} <code>x</code>, the following condition must hold:
         * <pre>
         *   x.eObjectForURIFragmentSegment(x.eURIFragmentSegment(eFeature, eObject)) == eObject
         * </pre>
         * </p>
         * @param eFeature the feature relating the given object to this object, or <code>null</code>.
         * @param eObject the object to be identified.
         * @return the fragment segment that resolves to the given object in this object's given feature.
         */
        string eURIFragmentSegment(EStructuralFeature eFeature, EObject eObject);
        /**
         * Returns the object resolved by the fragment segment.
         * <p>
         * The fragment segment encoding will typically be of the form returned by {@link #eURIFragmentSegment eURIFragmentSegment}.
         * @param uriFragmentSegment a fragment segment.
         * @return the object resolved by the fragment segment.
         */
        EObject eObjectForURIFragmentSegment(string uriFragmentSegment);
        /**
         * Sets the meta class.
         * An object with a set meta class is, by definition, a dynamic instance;
         * it will support dynamic {@link #eSetting settings}.
         * an.
         * @param eClass the dynamic meta class.
         * @see #eSetting(EStructuralFeature)
         */
        void eSetClass(EClass eClass);
        
        /**
         * Returns the feature ID relative to the base class, given a feature ID relative to this derived object's actual class.
         * @param derivedFeatureID the ID in the actual derived class
         * @param baseClass the base class for which a relative ID is desired.
         * @return the up-cast feature ID.
         */
        int eBaseStructuralFeatureID(int derivedFeatureID, object baseClass);
        /**
         * Returns the container feature ID.
         * If the container isn't a navigable feature, this will be a negative ID indicating the inverse of the containment feature's ID.
         * @return the container feature ID.
         * @see #eContainmentFeature()
         * @see #EOPPOSITE_FEATURE_BASE
         */
        int eContainerFeatureID();
        /**
         * Returns the feature ID relative to this derived object's actual class, given a feature ID relative to the given base class.
         * @param baseFeatureID the ID relative to a base class.
         * @param baseClass the base class to which the ID is relative.
         * @return the down-cast feature ID.
         */
        int eDerivedStructuralFeatureID(int baseFeatureID, object baseClass);
        /**
         * Returns the operation ID relative to this derived object's actual class, given an operation ID relative to the given base class.
         * @param baseOperationID the ID relative to a base class.
         * @param baseClass the base class to which the ID is relative.
         * @return the down-cast operation ID.
         * @since 2.6
         */
        int eDerivedOperationID(int baseOperationID, object baseClass);
        
        Uri eProxyURI();
        /**
         * Set the proxy URI of this object.
         * It will be used to {@link org.eclipse.emf.ecore.util.EcoreUtil#resolve(EObject, EObject) resolve} to the actual object.
         * @param uri the URI.
         * @see org.eclipse.emf.ecore.util.EcoreUtil#resolve(EObject, org.eclipse.emf.ecore.resource.ResourceSet)
         * @see Resource#unload
         */
        void eSetProxyURI(Uri uri);
        /**
         * Resolves the {@link EObject#eIsProxy proxy} object relative to this object.
         * @see org.eclipse.emf.ecore.util.EcoreUtil#resolve(EObject,EObject)
         * @return the resolved object, or the original if the proxy can't be resolved.
         */
        EObject eResolveProxy(InternalEObject proxy);
        /**
         * Returns the internal container, or <code>null</code>.
         * It does not resolve a proxy.
         * @return the internal container.
         * @see EObject#eContainer
         * @see InternalEObject#eDirectResource
         */
        InternalEObject eInternalContainer();
        
        /**
         * Returns the value of the given feature of the object; 
         * the value is optionally {@link org.eclipse.emf.ecore.util.EcoreUtil#resolve(EObject, EObject) resolved} before it is returned.
         * <p>
         * If the feature is {@link ETypedElement#isMany() many-valued},
         * the result will be an {@link EList}
         * and each object in the list will be {@link EClassifier#isInstance an instance of} 
         * the feature's {@link ETypedElement#getEType() type};
         * the list's contents are <b>not</b> affected by <code>resolve</code> argument.
         * Otherwise the result directly will be an instance of the feature's type;
         * if it is a {@link EObject#eIsProxy() proxy},
         * it is resolved.
         * The core type specifies whether to return the core reflective value,  
         * e.g., {@link org.eclipse.emf.common.util.EMap},
         * or the public API value,
         * e.g., {@link java.util.Map}.
         * @param eFeature the feature of the value to fetch.
         * @param resolve whether to resolve.
         * @param coreType whether to return the core type value or the API type value.
         * @return the value of the given feature of the object.
         * @exception IllegalArgumentException 
         * if the feature is not one the {@link #eClass meta class}'s 
         * {@link EClass#getEAllStructuralFeatures features}
         * and is also not {@link ExtendedMetaData#getAffiliation(EClass, EStructuralFeature) affiliated} with one of the meta class's features.
         * <p>
         * Note that for high-performance generated model implementation classes,
         * full checking whether the feature is among of the meta class's features
         * is performed only if assertions are enabled for the JVM.
         * As such,
         * the return value for an invalid feature,
         * in the absence of enabled assertions,
         * is undefined,
         * though typically it will be the value of the {@link EClass#getEStructuralFeature(int) meta class's feature}
         * with the same {@link EStructuralFeature#getFeatureID() ID} as the given feature.
         * </p>
         * @see EObject#eGet(EStructuralFeature, boolean)
         */
        public object eGet(EStructuralFeature eFeature, bool resolve, bool coreType);
        /**
         * Does the equivalent of <code>eObject.eGet(eObject.eClass().getEStructuralFeature(featureID), resolve, coreType)</code>.
         * @see #eGet(EStructuralFeature, boolean, boolean)
         */
        object eGet(int featureID, bool resolve, bool coreType);
        /**
         * Does the equivalent of <code>eObject.eSet(eObject.eClass().getEStructuralFeature(featureID), newValue)</code>.
         * @see #eSet(EStructuralFeature, Object)
         */
        void eSet(int featureID, object newValue);
        /**
         * Does the equivalent of <code>eObject.eUnset(eObject.eClass().getEStructuralFeature(featureID))</code>.
         * @see #eUnset(EStructuralFeature)
         */
        void eUnset(int featureID);
        /**
         * Does the equivalent of <code>eObject.eIsSet(eObject.eClass().getEStructuralFeature(featureID))</code>.
         * @see #eIsSet(EStructuralFeature)
         */
        bool eIsSet(int featureID);
        /**
         * Does the equivalent of <code>eObject.eInvoke(eObject.eClass().getEOperation(featureID), arguments)</code>.
         * @see #eInvoke(EOperation, EList)
         * @since 2.6
         */
        object eInvoke(int operationID, EList<object> arguments);
    }
}
