namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EEnum : EDataType
    {
        /// <summary>
        /// The list contents are of type EEnumLiteral. 
        /// It is bidirectional and its opposite is EEnum.
        /// It represents the enumerators of the enumeration.
        /// </summary>
        IList<EEnumLiteral> ELiterals { get; }

        /// <summary>
        /// Returns the enum literal with the given name, or null.
        /// </summary>
        EEnumLiteral GetEEnumLiteral(string name);

        /// <summary>
        /// Returns the enum literal with the given value, or null. 
        /// The values may not be unique; it returns the first.
        /// </summary>
        EEnumLiteral GetEEnumLiteral(int value);

        /// <summary>
        /// Returns the enum literal with the given literal value, or null.
        /// </summary>
        EEnumLiteral GetEEnumLiteralByLiteral(string literal);
    }
}
