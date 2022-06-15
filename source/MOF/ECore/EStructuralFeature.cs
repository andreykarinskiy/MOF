namespace MOF.ECore
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface EStructuralFeature : ETypedElement
    {
        /// <summary>
        /// TODO
        /// </summary>
        bool IsTransient { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        bool IsVolatile { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        bool IsChangeable { get; set; }

        /// <summary>
        /// It represents the serialized form of the default value.
        /// </summary>
        string DefaultValueLiteral { get; set; }

        /// <summary>
        /// It represents the default value that feature must take on when an explicit value has not been set. 
        /// Specifically, it may be non-null if the feature has an eType. 
        /// If the defaultValueLiteral is null, it is simply the eType's intrinsic default value. 
        /// Otherwise, if the eType is an EDataType and the defaultValueLiteral is non-null, 
        /// it is the object created by the factory's 
        /// <code>EFactory.CreateFromString(EDataType, string)</code> 
        /// method when invoked with those two objects as parameters.
        /// </summary>
        object DefaultValue { get; set; }

        /// <summary>
        /// An unsettable feature explicitly models the state of being set verses being unset and 
        /// so provides a direct implementation for the reflective eIsSet. 
        /// It is only applicable single-valued features. 
        /// One effect of this setting is that, in addition to generating the methods getXyz 
        /// and setXyz (if the feature is changeable), 
        /// a reflective generator will generate the methods isSetXyz and unsetXyz.
        /// </summary>
        bool IsUnsettable { get; set; }

        /// <summary>
        /// A derived feature typically computes its value from those of other features. 
        /// It will typically be transient and will often be volatile and not changeable. 
        /// The default copier won't copy it.
        /// </summary>
        bool IsDerived { get; set; }

        /// <summary>
        /// It is bidirectional and its opposite is EStructuralFeatures.
        /// It represents the containing class of this feature.
        /// </summary>
        EClass EContainingClass { get; }

        /// <summary>
        /// Returns the ID relative to the containing class.
        /// </summary>
        int FeatureID { get; }

        /// <summary>
        /// Returns the instance class of the containing class.
        /// </summary>
        Type ContainerClass { get; }
    }
}
