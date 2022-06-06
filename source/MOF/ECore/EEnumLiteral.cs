namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EEnumLiteral : ENamedElement
    {
        /// <summary>
        /// It represents the int value of an enumerator.
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// This is the literal, string value that represents this enumerator value. 
        /// This is used in persisting instances of enumerated type. 
        /// If set to null, it will return the name, instead.
        /// </summary>
        string Literal { get; set; }

        /// <summary>
        /// It is bidirectional and its opposite is 'ELiterals'.
        /// It represents the contain enumeration.
        /// </summary>
        EEnum EEnum { get; }
    }
}
