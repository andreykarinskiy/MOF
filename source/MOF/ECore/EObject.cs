namespace MOF.ECore
{
    /// <summary>
    /// EObject is the root of all modeled objects so all the method names start with "e" to distinguish the EMF methods from the client methods. 
    /// It provides support for the behaviors and features common to all modeled objects.
    /// It is a full participant of the common notification framework: org.eclipse.emf.common.notify. 
    /// Any EObject is assumed to also implement InternalEObject, which provides lower-level access that 
    /// is not necessarily suitable for general consumption but is required for maintaining the EMF support mechanisms. 
    /// Implementations of EObject should extend BasicEObjectImpl or one of its derived classes because methods can and will be added to this API. 
    /// The framework also assumes that implementations will not specialize #equals(Object) (nor #hashCode()) so that "==" 
    /// can be always used for equality testing; EcoreUtil.equals should be used for doing structural equality testing.
    /// </summary>
    public interface EObject
    {
        /// <summary>
        /// The meta class defines the features available for reflective access.
        /// </summary>
        EClass EClass { get; }

        /// <summary>
        /// An object is contained in a resource if it, or one of it's containers, appears in the contents of that resource.
        /// An object must be contained by a resource in order to be serialized.
        /// </summary>
        // Resource eResource { get; }


        /// <summary>
        /// Returns the containing object, or null.
        /// An object is contained by another object if it appears in the contents of that object. 
        /// The object will be contained by a containment feature of the containing object.
        /// </summary>
        EObject EContainer { get; }

        /// <summary>
        /// Returns the particular feature of the container that actually holds the object, or null, if there is no container. 
        /// Because of support for wildcard content, this feature may be an attribute representing a feature map; 
        /// in this case the object is referenced by the containment feature of an entry in the map, i.e., the eContainmentFeature.
        /// </summary>
        EStructuralFeature EContainingFeature { get; }

        /// <summary>
        /// Returns the containment feature that properly contains the object, or null, if there is no container. 
        /// Because of support for wildcard content, this feature may not be a direct feature of the container's class, 
        /// but rather a feature of an entry in a feature map feature of the container's class.
        /// </summary>
        EReference EContainmentFeature { get; }

        /// <summary>
        /// Returns a list view of the content objects; it is unmodifiable.
        /// This will be the list of EObjects determined by the contents of the containment features of this object's meta class.
        /// Objects can, indirectly, be removed and will change to reflect container changes. 
        /// The implicit tree of contents is also directly available.
        /// </summary>
        IList<EObject> EContents { get; }

        /// <summary>
        /// Returns a tree iterator that iterates over all the direct contents and indirect contents of this object.
        /// </summary>
        IEnumerable<EObject> EAllContents { get; }

        /// <summary>
        /// Indicates whether this object is a proxy.
        /// A proxy is an object that is defined in a Resource that has not been loaded.
        /// An object may be a proxy either because proxy resolution was disabled when the object 
        /// was accessed(see eGet(EStructuralFeature, boolean)) or because proxy resolution failed.
        /// </summary>
        bool EIsProxy { get; }

        /// <summary>
        /// Returns a list view of the cross referenced objects; it is unmodifiable.
        /// This will be the list of EObjects determined by the contents of the reference features 
        /// of this object's meta class, excluding containment features and their opposites. 
        /// </summary>
        IList<EObject> ECrossReferences { get; }

        /// <summary>
        /// Returns the value of the given feature of this object.
        /// It returns the resolved value.
        /// </summary>
        object EGet(EStructuralFeature feature);

        /// <summary>
        /// Returns the value of the given feature of the object; the value is optionally resolved before it is returned.
        /// If the feature is many-valued, the result will be an EList and each object in the list will be an instance of the feature's type; 
        /// the list's contents are not affected by resolve argument.
        /// Otherwise the result directly will be an instance of the feature's type; if it is a proxy, it is resolved.
        /// </summary>
        object EGet(EStructuralFeature feature, bool resolve);

        /// <summary>
        /// Sets the value of the given feature of the object to the new value.
        /// If the feature is many-valued, the new value must be an EList and each object in that list must be 
        /// an instance of the feature's type; the existing contents are cleared and the contents of the new value are added. 
        /// However, if the new value is the content list itself, or is modified as a side effect of modifying 
        /// the content list (i.e., if it is a view on the content list), 
        /// the behavior is undefined and will likely result in simply clearing the list. 
        /// If the feature is single-valued, the new value directly must be an instance 
        /// of the feature's type and it becomes the new value of the feature of the object. 
        /// If the feature is unsettable, the modeled state becomes set; otherwise, 
        /// the feature may still not considered set if the new value is the same as the default.
        /// </summary>
        void ESet(EStructuralFeature feature, object newValue);

        /// <summary>
        /// Returns whether the feature of the object is considered to be set.
        /// If the feature is many-valued, the value must be an EList and the feature is considered set if the list is not empty.
        /// If the feature is unsettable, the modeled state is directly available and is used.Otherwise, 
        /// the unresolved value of the feature of the object is compared against the feature's default value or 
        /// the meta class's default value, as appropriate; the feature is considered set if it's not the same as the default.
        /// This property can affect serialization, since defaults are typically omitted in a compact serialization.
        /// </summary>
        bool EIsSet(EStructuralFeature feature);

        /// <summary>
        /// Unsets the feature of the object.
        /// If the feature is many-valued, the value must be an EList and that list is cleared.Otherwise, 
        /// the value of the feature of the object is set to the feature's default value or the meta class's default value, as appropriate.
        /// If the feature is unsettable, the modeled state becomes unset.
        /// In any case, the feature will no longer be considered set.
        /// </summary>
        /// <param name="feature"></param>
        void EUnset(EStructuralFeature feature);

        /// <summary>
        /// Invokes the specified operation of the object. 
        /// If the operation has parameters, then corresponding arguments must be supplied. 
        /// There are no optional parameters in Ecore operations.
        /// If the operation is a void operation, then on successful execution, the result of this invocation is null. 
        /// Otherwise, if the operation is multi-valued, then an EList is returned (possibly empty). 
        /// If single-valued, then an instance of the operation's type is returned, or possibly null.
        /// </summary>
        object EInvoke(EOperation operation, IList<object> arguments);


        public void Accept(IEcoreVisitor visitor);
    }
}
