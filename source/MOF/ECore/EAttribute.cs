namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object EAttribute.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EAttribute.java
    public interface EAttribute : EStructuralFeature
    {
        /// <summary>
        /// An ID attribute explicitly models the one unique ID of an object.
        /// </summary>
        bool IsID();

        /// <summary>
        /// Sets the value of the ID attribute.
        /// </summary>
        void SetID(bool value);

        /// <summary>
        /// Returns the value of the EAttribute Type reference.
        /// </summary>
        /// <returns></returns>
        EDataType GetEAttributeType();
    }
}