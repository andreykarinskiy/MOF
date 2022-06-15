namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EModelElement : EObject
    {
        /// <summary>
        /// Returns the value of the EAnnotations containment reference list. 
        /// The list contents are of type EAnnotation. 
        /// It is bidirectional and its opposite is EModel Element. 
        /// It represents additional associated information
        /// </summary>
        IList<EAnnotation> EAnnotations { get; }

        /// <summary>
        /// Return the annotation with a matching source attribute.
        /// </summary>
        EAnnotation GetEAnnotation(string source);
    }
}
