using MOF.ECore;

namespace MOF.Impl
{
    public sealed class DefaultEFactory : EModelElementImpl, EFactory
    {
        public EPackage EPackage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Accept(IEcoreVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public string ConvertToString(EDataType eDataType, object instanceValue)
        {
            throw new NotImplementedException();
        }

        public EObject Create(EClass eClass)
        {
            throw new NotImplementedException();
        }

        public EAnnotation CreateEAnnotation()
        {
            return new EAnnotationImpl();
        }

        public EAttribute CreateEAttribute()
        {
            return new EAttributeImpl();
        }

        public EClass CreateEClass()
        {
            return new EClassImpl();
        }

        public EDataType CreateEDataType()
        {
            return new EDataTypeImpl();
        }

        public EEnum CreateEEnum()
        {
            return new EEnumImpl();
        }

        public EEnumLiteral CreateEEnumLiteral()
        {
            return new EEnumLiteralImpl();
        }

        public EFactory CreateEFactory()
        {
            throw new NotImplementedException();
        }

        public EGenericType CreateEGenericType()
        {
            return new EGenericTypeImpl();
        }

        public EObject CreateEObject()
        {
            throw new NotImplementedException();
        }

        public EOperation CreateEOperation()
        {
            return new EOperationImpl();
        }

        public EPackage CreateEPackage()
        {
            return new EPackageImpl();
        }

        public EParameter CreateEParameter()
        {
            return new EParameterImpl();
        }

        public EReference CreateEReference()
        {
            return new EReferenceImpl();
        }

        public ETypeParameter CreateETypeParameter()
        {
            return new ETypeParameterImpl();
        }

        public object CreateFromString(EDataType eDataType, string literalValue)
        {
            throw new NotImplementedException();
        }
    }
}
