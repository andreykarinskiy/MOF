namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EClass : EClassifier
    {
        /// <summary>
        /// It represents whether the class is abstract in the C# sense. 
        /// For an abstract class, the generated implementation class will be abstract,
        /// and the generated factory will not provide support for creating an instance.
        /// </summary>
        bool IsAbstract { get; set; }

        /// <summary>
        /// It represents whether the class is an interface in the C# sense. 
        /// For an interface class, there will be no generated implementation class.
        /// </summary>
        bool IsInterface { get; set; }

        /// <summary>
        /// It represents the super types in the C# sense, i.e., 
        /// the super class and the direct implemented interfaces, 
        /// and is derived from the generic super types.
        /// </summary>
        IList<EClass> ESuperTypes { get; }

        /// <summary>
        /// It represents the closure of all inherited super types and is derived from the generic super types.
        /// </summary>
        IList<EClass> EAllSuperTypes { get; }

        /// <summary>
        /// It represents the attribute that will be used as the ID of an instance.
        /// </summary>
        EAttribute EIDAttribute { get; }

        /// <summary>
        /// The list contents are of type EStructuralFeature. 
        /// It is bidirectional and its opposite is EContaining Class. 
        /// It represents the modeled features local to this class.
        /// </summary>
        IList<EStructuralFeature> EStructuralFeatures { get; }

        /// <summary>
        /// It represents the generic super types in the C# sense, i.e., 
        /// the super class and the direct implemented interfaces. 
        /// The super types list is derived from this one, i.e., 
        /// it represents the erasure of each generic super type.
        /// </summary>
        IList<EGenericType> EGenericSuperTypes { get; }

        /// <summary>
        /// It represents the closure of all inherited generic super types. 
        /// The all super types list is derived from this one, i.e., 
        /// it represents the erasure of each generic super type.
        /// </summary>
        IList<EGenericType> EAllGenericSuperTypes { get; }

        /// <summary>
        /// It represents the modeled attributes local to this class.
        /// </summary>
        IList<EAttribute> EAttributes { get; }

        /// <summary>
        /// It represents the closure of all attributes, inherited and local.
        /// </summary>
        IList<EAttribute> EAllAttributes { get; }

        /// <summary>
        /// It represents the modeled references local to this class.
        /// </summary>
        IList<EReference> EReferences { get; }

        /// <summary>
        /// It represents the closure of all references, inherited and local.
        /// </summary>
        IList<EReference> EAllReferences { get; }

        /// <summary>
        /// It represents the closure of all references, inherited and local, that are containments. 
        /// These features will determine the EObject.eContents() of an instance.
        /// </summary>
        IList<EReference> EAllContainments { get; }

        /// <summary>
        /// It represents the closure of all attributes and references, inherited and local.
        /// </summary>
        IList<EStructuralFeature> EAllStructuralFeatures { get; }

        /// <summary>
        /// It represents the modeled operations local to this class.
        /// </summary>
        IList<EOperation> EOperations { get; }

        /// <summary>
        /// It represents the closure of all operations, inherited and local.
        /// </summary>
        IList<EOperation> EAllOperations { get; }

        /// <summary>
        /// Returns whether this class is the same as, or a super type of, some other class.
        /// </summary>
        /// <param name="someClass">some other class</param>
        /// <returns>whether this class is the same as, or a super type of, some other class.</returns>
        bool IsSuperTypeOf(EClass someClass);

        /// <summary>
        /// Returns the number of features.
        /// </summary>
        int FeatureCount { get; }

        /// <summary>
        /// Returns the feature with this ID.
        /// </summary>
        /// <returns>the feature with this ID.</returns>
        EStructuralFeature GetEStructuralFeature(int featureID);

        /// <summary>
        /// Returns the feature with this name.
        /// </summary>
        EStructuralFeature GetEStructuralFeature(string featureName);

        /// <summary>
        /// Returns the number of operations.
        /// </summary>
        int OperationCount { get; }

        /// <summary>
        /// Returns the operation with this ID.
        /// </summary>
        EOperation GetEOperation(int operationID);

        /// <summary>
        /// Returns the ID of the operation relative to this class, or -1 if the operation is not in this class.
        /// </summary>
        int GetOperationID(EOperation operation);

        /// <summary>
        /// Returns the operation that overrides this operation.
        /// </summary>
        EOperation GetOverride(EOperation operation);

        /// <summary>
        /// TODO
        /// </summary>
        EGenericType GetFeatureType(EStructuralFeature feature);

        /// <summary>
        /// Returns the ID of the feature relative to this class, or -1 if the feature is not in this class.
        /// </summary>
        int GetFeatureID(EStructuralFeature feature);
    }
}
