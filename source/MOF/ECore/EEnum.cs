using MOF.Common.Util;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object <b>EEnum</b>.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EEnum.java
    public interface EEnum : EDataType
    {
        /// <summary>
        /// Returns the value of the <b>ELiterals</b> containment reference list.
        /// </summary>
        /// <returns></returns>
        EList<EEnumLiteral> GetELiterals();

        /// <summary>
        /// Returns the enum literal with the given name, or <code>null</code>.
        /// </summary>
        EEnumLiteral GetEEnumLiteral(String name);
        
        /// <summary>
        /// Returns the enum literal with the given value, or <code>null</code>.
        /// The values may not be unique; it returns the first.
        /// </summary>
        EEnumLiteral GetEEnumLiteral(int value);

        /// <summary>
        /// Returns the enum literal with the given literal value, or <code>null</code>.
        /// </summary>
        EEnumLiteral GetEEnumLiteralByLiteral(String literal);
    }
}
