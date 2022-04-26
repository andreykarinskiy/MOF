namespace MOF.ECore
{
    public interface EFactory : EModelElement
    {
        EPackage EPackage { get; set; }

        EObject Create(EClass eClass);

        object CreateFromString(EDataType eDataType, string literalValue);
        
        string ConvertToString(EDataType eDataType, object instanceValue);

        EObject CreateEObject();

        EAttribute CreateEAttribute();

        EAnnotation CreateEAnnotation();

        EClass CreateEClass();
        
        EDataType CreateEDataType();

        EParameter CreateEParameter();

        EOperation CreateEOperation();

        EPackage CreateEPackage();

        EFactory CreateEFactory();

        EEnumLiteral CreateEEnumLiteral();

        EEnum CreateEEnum();

        EReference CreateEReference();

        EGenericType CreateEGenericType();

        ETypeParameter CreateETypeParameter();
        
        // EcorePackage getEcorePackage();
    }
}
