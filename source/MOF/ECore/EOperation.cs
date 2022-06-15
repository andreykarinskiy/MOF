namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EOperation : ETypedElement
    {
        /// <summary>
        /// Returns the value of the EContaining Class container reference. 
        /// It is bidirectional and its opposite is EOperations.
        /// It represents a method in the C# sense.
        /// </summary>
        EClass EContainingClass { get; }

        /// <summary>
        /// Returns the value of the EParameters containment reference list. 
        /// The list contents are of type EParameter. 
        /// It is bidirectional and its opposite is EOperation.
        /// It represents the valid arguments for this operation.
        /// </summary>
        IList<EParameter> EParameters { get; }

        /// <summary>
        /// Returns the value of the EExceptions reference list. 
        /// The list contents are of type EClassifier.
        /// It represents the exceptions thrown by this operation and is derived from the generic exceptions.
        /// </summary>
        IList<EClassifier> EExceptions { get; }

        /// <summary>
        /// The list contents are of type EGenericType.
        /// It represents the generic exceptions thrown by this operation.
        /// The exceptions list is derived from this one, i.e., it represents the erasure of each generic exception.
        /// </summary>
        IList<EGenericType> EGenericExceptions { get; }

        /// <summary>
        /// Returns the ID relative to the containing class.
        /// </summary>
        int OperationID { get; }

        /// <summary>
        /// Returns whether this operation is an override of some other operation.
        /// </summary>
        bool IsOverrideOf(EOperation someOperation);

        /// <summary>
        /// An operation can optionally introduce type parameters.
        /// </summary>
        IList<ETypeParameter> ETypeParameters { get; }
    }
}
