namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object EFactory.
    /// A factory is responsible for creating class instances, and for converting data type instances to and from String.
    /// </summary>
    public interface EFactory : EModelElement
    {
        EPackage EPackage { get; set; }

        /// <summary>
        /// Creates a new instance of the class and returns it.
        /// </summary>
        EObject Create(EClass eClass);

        /// <summary>
        /// Creates an instance of the data type from the literal value.
        /// </summary>
        object CreateFromString(EDataType eDataType, string literalValue);

        /// <summary>
        ///  Returns the literal value of the instance.
        /// </summary>
        string ConvertToString(EDataType eDataType, object instanceValue);

        /// <summary>
        /// Returns a new object of class EObject.
        /// </summary>
        EObject CreateEObject();

        /// <summary>
        /// TODO
        /// </summary>
        EAttribute CreateEAttribute();

        /// <summary>
        /// TODO
        /// </summary>
        EAnnotation CreateEAnnotation();

        /// <summary>
        /// TODO
        /// </summary>
        EClass CreateEClass();

        /// <summary>
        /// TODO
        /// </summary>
        EDataType CreateEDataType();

        /// <summary>
        /// TODO
        /// </summary>
        EParameter CreateEParameter();

        /// <summary>
        /// TODO
        /// </summary>
        EOperation CreateEOperation();

        /// <summary>
        /// TODO
        /// </summary>
        EPackage CreateEPackage();

        /// <summary>
        /// TODO
        /// </summary>
        EFactory CreateEFactory();

        /// <summary>
        /// TODO
        /// </summary>
        EEnumLiteral CreateEEnumLiteral();

        /// <summary>
        /// TODO
        /// </summary>
        EEnum CreateEEnum();

        EReference CreateEReference();

        EGenericType CreateEGenericType();

        ETypeParameter CreateETypeParameter();
    }
}
