namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EParameter : ETypedElement
    {
        /// <summary>
        /// It is bidirectional and its opposite is EParameters.
        /// It represents the containing operation.
        /// </summary>
        EOperation EOperation { get; }
    }
}
