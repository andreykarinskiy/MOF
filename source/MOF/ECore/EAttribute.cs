namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EAttribute : EStructuralFeature
    {
        /// <summary>
        /// The type of an attribute must always be a data type.
        /// </summary>
        EDataType EAttributeType { get; }
    }
}
