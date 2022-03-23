using MOF.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EModelElement.java
    public interface EModelElement : EObject
    {
        /**
   * Returns the value of the '<em><b>EAnnotations</b></em>' containment reference list.
   * The list contents are of type {@link org.eclipse.emf.ecore.EAnnotation}.
   * It is bidirectional and its opposite is '{@link org.eclipse.emf.ecore.EAnnotation#getEModelElement <em>EModel Element</em>}'.
   * <!-- begin-user-doc -->
   * It represents additional associated information
   * @see #getEAnnotation(String)
   * @ignore
   * <!-- end-user-doc -->
   * @return the value of the '<em>EAnnotations</em>' containment reference list.
   * @see org.eclipse.emf.ecore.EcorePackage#getEModelElement_EAnnotations()
   * @see org.eclipse.emf.ecore.EAnnotation#getEModelElement
   * @model opposite="eModelElement" containment="true"
   * @generated
   */
        EList<EAnnotation> getEAnnotations();
        /**
         * <!-- begin-user-doc -->
         * Return the annotation with a matching {@link org.eclipse.emf.ecore.EAnnotation#getSource() source} attribute.
         * @return The annotation with a matching source attribute.
         * @see #getEAnnotations()
         * @see org.eclipse.emf.ecore.EAnnotation#getSource()
         * @ignore
         * <!-- end-user-doc -->
         * @model
         * @generated
         */
        EAnnotation getEAnnotation(string source);
    }
}
