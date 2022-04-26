namespace MOF.ECore
{
    public interface EEnumLiteral : ENamedElement //, Enumerator
    {
        int Value { get; set; }

        string Literal { get; set; }

        EEnum EEnum { get; }
    }
}
