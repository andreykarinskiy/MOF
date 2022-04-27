namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface ETypeParameter : ENamedElement
    {
        /// <summary>
        /// It represents the bounds on the type of argument that be may be used to instantiate this parameter.
        /// </summary>
        IList<EGenericType> EBounds { get; }
    }
}
