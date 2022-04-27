namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface ETypedElement : ENamedElement
    {
        /// <summary>
        /// It represents whether order is meaningful.
        /// </summary>
        bool IsOrdered { get; set; }

        /// <summary>
        /// It represents whether values must be unique.
        /// </summary>
        bool IsUnique { get; set; }

        /// <summary>
        /// It represents the minimum number of values that must appear in a valid instance.
        /// </summary>
        int LowerBound { get; set; }

        /// <summary>
        /// The default value is "1".
        /// It represents the maximum number of values that must appear in a valid instance. 
        /// </summary>
        int UpperBound { get; set; }

        /// <summary>
        /// It represents whether more than one value may appear in a valid instance.
        /// </summary>
        bool IsMany { get; }

        /// <summary>
        /// It represents whether at least one value is required for a valid instance.
        /// </summary>
        bool IsRequired { get; }

        /// <summary>
        /// It represents the type of the element and is derived from the generic type.
        /// </summary>
        EClassifier EType { get; set; }

        /// <summary>
        /// It represents the generic type of the element. 
        /// The type is derived from this, i.e., it represents the erasure of the generic type.
        /// </summary>
        EGenericType EGenericType { get; set; }
    }
}
