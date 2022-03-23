using MOF.Common.Util;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object <see cref="EModelElement"/>.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EAnnotation.java
    public interface EAnnotation : EModelElement
    {
        /// <summary>
        /// Returns the value of the EAnnotations containment reference list.
        /// </summary>
        /// <returns>
        /// return the value of the EAnnotations containment reference list.
        /// </returns>
        EList<EAnnotation> GetEAnnotations();

        /// <summary>
        /// Return the annotation with a matching attribute.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>
        /// The annotation with a matching source attribute.
        /// </returns>
        EAnnotation GetEAnnotation(string source);
    }
}