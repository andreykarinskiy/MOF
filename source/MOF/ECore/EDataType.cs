namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EDataType : EClassifier
    {
        /// <summary>
        /// It represents whether values of this type will be serialized. 
        /// For a serializable data type, there will be factory methods of the form:
        /// <code>
        /// string ConvertXyzToString(EDataType metaObject, object instanceValue);
        /// object CreateXyzFromString(EDataType metaObject, string initialValue);
        /// </code>
        /// in the generated factory implementation.Clients will typically need to hand write the bodies of these generated methods.
        /// </summary>
        bool IsSerializable { get; set; }
    }
}
