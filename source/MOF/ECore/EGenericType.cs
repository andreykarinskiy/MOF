namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EGenericType : EObject
    {
        /// <summary>
        /// A generic type with an upper bound T, is equivalent to "T" in C#.
        /// </summary>
        EGenericType EUpperBound { get; set; }

        /// <summary>
        /// These represent the template arguments applied to a classifier with type parameters, e.g., Map<T>.
        /// </summary>
        IList<EGenericType> ETypeArguments { get; }

        /// <summary>
        /// This represents the erased or raw type of the generic type.
        /// </summary>
        EClassifier ERawType { get; }

        /// <summary>
        /// A generic type with a lower bound T, is equivalent to "T" in C#.
        /// </summary>
        EGenericType ELowerBound { get; set; }

        /// <summary>
        /// The represents a reference to a type parameter.
        /// </summary>
        ETypeParameter ETypeParameter { get; set; }

        /// <summary>
        /// The represents a reference to a classifier.
        /// </summary>
        EClassifier EClassifier { get; set; }

        bool IsInstance(object instance);
    }
}
