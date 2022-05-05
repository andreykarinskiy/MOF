namespace MOF.ECore
{
    public interface IEcoreVisitor
    {
        void Visit(EObject element);

        void Visit(EAnnotation element);

        void Visit(EAttribute element);

        void Visit(EClass element);

        void Visit(EDataType element);

        void Visit(EEnum element);

        void Visit(EEnumLiteral element);

        void Visit(EGenericType element);

        void Visit(EOperation element);

        void Visit(EPackage element);

        void Visit(EParameter element);

        void Visit(EReference element);

        void Visit(ETypeParameter element);
    }
}
