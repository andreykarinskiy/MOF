namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EAnnotation : EModelElement
    {
        /// <summary>
        /// This will typically be a full URI representing the type of the annotation.
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// This represents tagged values.
        /// </summary>
        IDictionary<string, string> Details { get; }

        /// <summary>
        /// Returns the value of the EModelElement container reference. 
        /// It is bidirectional and its opposite is EAnnotations.
        /// </summary>
        EModelElement? EModelElement { get; set; }

        /// <summary>
        /// This represents arbitrary contained objects.
        /// </summary>
        IList<EObject> Contents { get; }

        /// <summary>
        /// This represents arbitrary referenced objects.
        /// </summary>
        IList<EObject> References { get; }
    }
}
