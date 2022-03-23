namespace MOF.ECore
{
    /// <summary>
    /// The <b>Factory</b> for the model.
    /// It provides a create method for each non-abstract class of the model.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EcoreFactory.java
    public interface EcoreFactory : EFactory
    {
        /// <summary>
        /// Returns a new object of class EObject.
        /// </summary>
        /// <returns></returns>
        EObject CreateEObject();

        /// <summary>
        /// Returns a new object of class EAttribute.
        /// </summary>
        EAttribute CreateEAttribute();

        /// <summary>
        /// Returns a new object of class EAnnotation.
        /// </summary>
        EAnnotation CreateEAnnotation();

        /// <summary>
        /// Returns a new object of class EClass.
        /// </summary>
        EClass createEClass();

        /// <summary>
        /// Returns a new object of class EData Type.
        /// </summary>
        EDataType CreateEDataType();

        /// <summary>
        /// Returns a new object of class EParameter.
        /// </summary>
        EParameter CreateEParameter();

        /// <summary>
        /// Returns a new object of class '<em>EOperation</em>'.
        /// </summary>
        EOperation CreateEOperation();

        /// <summary>
        /// Returns a new object of class '<em>EPackage</em>'.
        /// </summary>
        EPackage CreateEPackage();

        /// <summary>
        /// Returns a new object of class '<em>EFactory</em>'.
        /// </summary>
        EFactory CcreateEFactory();

        /// <summary>
        /// Returns a new object of class '<em>EEnum Literal</em>'.
        /// </summary>
        EEnumLiteral CreateEEnumLiteral();

        /// <summary>
        /// Returns a new object of class '<em>EEnum</em>'.
        /// </summary>
        EEnum CreateEEnum();

        /// <summary>
        /// Returns a new object of class '<em>EReference</em>'.
        /// </summary>
        /// <returns></returns>
        EReference CreateEReference();

        /// <summary>
        /// Returns a new object of class '<em>EGeneric Type</em>'.
        /// </summary>
        EGenericType CreateEGenericType();

        /// <summary>
        /// Returns a new object of class '<em>EType Parameter</em>'.
        /// </summary>
        ETypeParameter CreateETypeParameter();

        /// <summary>
        /// Returns the package supported by this factory.
        /// </summary>
        EcorePackage GetEcorePackage();
    }
}
