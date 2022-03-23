namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object <b>EData Type</b>.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EFactory.java
    public interface EFactory : EModelElement
    {
        /// <summary>
        /// Returns the value of the <b>EPackage</b> reference.
        /// </summary>
        /// <returns></returns>
        EPackage GetEPackage();
       
        void SetEPackage(EPackage value);

        /// <summary>
        /// Creates a new instance of the class and returns it.
        /// </summary>
        EObject Create(EClass eClass);

        /// <summary>
        /// Creates an instance of the data type from the literal value.
        /// </summary>
        object CreateFromString(EDataType eDataType, string literalValue);

        /// <summary>
        /// Returns the literal value of the instance.
        /// </summary>
        string ConvertToString(EDataType eDataType, object instanceValue);
    }
}
