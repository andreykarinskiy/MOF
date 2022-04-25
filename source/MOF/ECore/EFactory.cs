using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EFactory : EModelElement
    {
        EPackage getEPackage();

        void setEPackage(EPackage value);

        EObject create(EClass eClass);

        Object createFromString(EDataType eDataType, String literalValue);
        
        String convertToString(EDataType eDataType, Object instanceValue);

        EObject createEObject();

        EAttribute createEAttribute();

        EAnnotation createEAnnotation();

        EClass createEClass();
        
        EDataType createEDataType();

        EParameter createEParameter();

        EOperation createEOperation();

        EPackage createEPackage();

        EFactory createEFactory();

        EEnumLiteral createEEnumLiteral();

        EEnum createEEnum();

        EReference createEReference();

        EGenericType createEGenericType();

        ETypeParameter createETypeParameter();
        
        // EcorePackage getEcorePackage();
    }
}
