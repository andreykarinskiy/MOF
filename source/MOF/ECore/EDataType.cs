namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EDataType.java
    public interface EDataType : EClassifier
    {
        /// <summary>
        /// Returns the value of the '<em><b>Serializable</b></em>' attribute.
        /// </summary>
        /// <returns></returns>
        bool IsSerializable();
        
        /**
         * Sets the value of the '{@link org.eclipse.emf.ecore.EDataType#isSerializable <em>Serializable</em>}' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @param value the new value of the '<em>Serializable</em>' attribute.
         * @see #isSerializable()
         * @generated
         */
        void SetSerializable(bool value);

        /**
         * Converts a value of the data type to a string literal.
         * @param value the value to be converted.
         * @return the literal representation of the value.
         */
        string ConvertToString(object value);
        
        /**
         * Creates a value of the data type from a string literal.
         * @param literal the string literal to be converted.
         * @return the value of the literal representation.
         */
        object CreateFromString(string literal);
    }
}