namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EReference : EStructuralFeature
    {
        bool IsContainer { get; set; }

        /// <summary>
        /// Returns the value of the EOpposite reference.
        /// It represent the other end of a bidirectional relation.
        /// </summary>
        EReference EOpposite { get; set; }

        /// <summary>
        /// A reference is a containment if it represents by-value content.
        /// </summary>
        EClass EReferenceType { get; }

        /// <summary>
        /// This represents a subset of the attributes on the referenced type that 
        /// uniquely identify an instance within this reference.
        /// </summary>
        IList<EAttribute> EKeys { get; }
    }
}
