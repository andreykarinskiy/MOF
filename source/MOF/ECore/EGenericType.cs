namespace MOF.ECore
{
    public interface EGenericType : EObject
    {
        EGenericType EUpperBound { get; set; }

        IList<EGenericType> ETypeArguments { get; }

        EClassifier ERawType { get; }

        EGenericType ELowerBound { get; set; }

        ETypeParameter ETypeParameter { get; set; }

        EClassifier EClassifier { get; set; }

        bool IsInstance(object instance);
    }
}
