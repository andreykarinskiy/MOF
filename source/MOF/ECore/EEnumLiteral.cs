using MOF.Common.Util;

namespace MOF.ECore
{
    /// <summary>
    /// A representation of the model object <b>EEnum Literal</b>.
    /// </summary>
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EEnumLiteral.java
    public interface EEnumLiteral : ENamedElement, Enumerator
    {
        /// <summary>
        /// Returns the value of the '<em><b>Value</b></em>' attribute.
        /// It represents the <code>int</code> value of an enumerator.
        /// </summary>
        /// <returns></returns>
        int GetValue();

        void SetValue(int value);

        /// <summary>
        /// Returns the value of the <b>Instance</b> attribute.
        /// </summary>
        Enumerator GetInstance();

        void SetInstance(Enumerator value);

        /// <summary>
        /// Returns the value of the <b>Literal</b> attribute.
        /// This is the literal, string value that represents this enumerator value.
        /// This is used in persisting instances of enumerated type.
        /// If set to<code>null<code>, it will return the ENamedElement Name, instead.
        /// </summary>
        string GetLiteral();

        void SetLiteral(string value);

        /// <summary>
        /// Returns the value of the <b>EEnum</b> container reference.
        /// </summary>
        EEnum getEEnum();
    }
}
