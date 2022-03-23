namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EParameter.java
    public interface EParameter : ETypedElement
    {
        /**
   * Returns the value of the '<em><b>EOperation</b></em>' container reference.
   * It is bidirectional and its opposite is '{@link org.eclipse.emf.ecore.EOperation#getEParameters <em>EParameters</em>}'.
   * <!-- begin-user-doc -->
   * <p>
   * It represents the containing operation.
   * </p>
   * <!-- end-user-doc -->
   * @return the value of the '<em>EOperation</em>' container reference.
   * @see org.eclipse.emf.ecore.EcorePackage#getEParameter_EOperation()
   * @see org.eclipse.emf.ecore.EOperation#getEParameters
   * @model opposite="eParameters" resolveProxies="false" changeable="false"
   * @generated
   */
        EOperation getEOperation();
    }
}
