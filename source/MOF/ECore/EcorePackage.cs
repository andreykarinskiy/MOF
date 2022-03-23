using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    // https://git.eclipse.org/r/plugins/gitiles/emf/org.eclipse.emf/+/refs/heads/master/plugins/org.eclipse.emf.ecore/src/org/eclipse/emf/ecore/EcorePackage.java
    public interface EcorePackage : EPackage
    {
        /**
   * The package name.
   * @generated
   */
        const string eNAME = "ecore";
        /**
         * The package namespace URI.
         * @generated
         */
        const string eNS_URI = "http://www.eclipse.org/emf/2002/Ecore";
        /**
         * The package namespace name.
         * @generated
         */
        const string eNS_PREFIX = "ecore";
        /**
         * The package content type ID.
         * <!-- begin-user-doc -->
         * @since 2.4
         * <!-- end-user-doc -->
         * @generated
         */
        const string eCONTENT_TYPE = "org.eclipse.emf.ecore";

        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EObjectImpl <em>EObject</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EObjectImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEObject()
         * @generated
         */
        const int EOBJECT = 10;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EModelElementImpl <em>EModel Element</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EModelElementImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEModelElement()
         * @generated
         */
        const int EMODEL_ELEMENT = 8;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EMODEL_ELEMENT__EANNOTATIONS = 0;
        /**
         * The number of structural features of the '<em>EModel Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EMODEL_ELEMENT_FEATURE_COUNT = 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EMODEL_ELEMENT___GET_EANNOTATION__STRING = 0;
        /**
         * The number of operations of the '<em>EModel Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EMODEL_ELEMENT_OPERATION_COUNT = 1;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.ENamedElementImpl <em>ENamed Element</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.ENamedElementImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getENamedElement()
         * @generated
         */
        const int ENAMED_ELEMENT = 9;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ENAMED_ELEMENT__EANNOTATIONS = EMODEL_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ENAMED_ELEMENT__NAME = EMODEL_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>ENamed Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ENAMED_ELEMENT_FEATURE_COUNT = EMODEL_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ENAMED_ELEMENT___GET_EANNOTATION__STRING = EMODEL_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>ENamed Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ENAMED_ELEMENT_OPERATION_COUNT = EMODEL_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EStructuralFeatureImpl <em>EStructural Feature</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EStructuralFeatureImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEStructuralFeature()
         * @generated
         */
        const int ESTRUCTURAL_FEATURE = 15;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EAttributeImpl <em>EAttribute</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EAttributeImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEAttribute()
         * @generated
         */
        const int EATTRIBUTE = 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EClassImpl <em>EClass</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EClassImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEClass()
         * @generated
         */
        const int ECLASS = 2;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.ETypedElementImpl <em>ETyped Element</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.ETypedElementImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getETypedElement()
         * @generated
         */
        const int ETYPED_ELEMENT = 16;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EDataTypeImpl <em>EData Type</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EDataTypeImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEDataType()
         * @generated
         */
        const int EDATA_TYPE = 4;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EEnumImpl <em>EEnum</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EEnumImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEEnum()
         * @generated
         */
        const int EENUM = 5;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EEnumLiteralImpl <em>EEnum Literal</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EEnumLiteralImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEEnumLiteral()
         * @generated
         */
        const int EENUM_LITERAL = 6;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EFactoryImpl <em>EFactory</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EFactoryImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEFactory()
         * @generated
         */
        const int EFACTORY = 7;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EOperationImpl <em>EOperation</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EOperationImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEOperation()
         * @generated
         */
        const int EOPERATION = 11;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EPackageImpl <em>EPackage</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EPackageImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEPackage()
         * @generated
         */
        const int EPACKAGE = 12;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EParameterImpl <em>EParameter</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EParameterImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEParameter()
         * @generated
         */
        const int EPARAMETER = 13;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EReferenceImpl <em>EReference</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EReferenceImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEReference()
         * @generated
         */
        const int EREFERENCE = 14;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__EANNOTATIONS = ENAMED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__NAME = ENAMED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__ORDERED = ENAMED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__UNIQUE = ENAMED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__LOWER_BOUND = ENAMED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__UPPER_BOUND = ENAMED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__MANY = ENAMED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__REQUIRED = ENAMED_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__ETYPE = ENAMED_ELEMENT_FEATURE_COUNT + 6;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT__EGENERIC_TYPE = ENAMED_ELEMENT_FEATURE_COUNT + 7;
        /**
         * The number of structural features of the '<em>ETyped Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT_FEATURE_COUNT = ENAMED_ELEMENT_FEATURE_COUNT + 8;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT___GET_EANNOTATION__STRING = ENAMED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>ETyped Element</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPED_ELEMENT_OPERATION_COUNT = ENAMED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__EANNOTATIONS = ETYPED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__NAME = ETYPED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__ORDERED = ETYPED_ELEMENT__ORDERED;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__UNIQUE = ETYPED_ELEMENT__UNIQUE;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__LOWER_BOUND = ETYPED_ELEMENT__LOWER_BOUND;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__UPPER_BOUND = ETYPED_ELEMENT__UPPER_BOUND;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__MANY = ETYPED_ELEMENT__MANY;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__REQUIRED = ETYPED_ELEMENT__REQUIRED;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__ETYPE = ETYPED_ELEMENT__ETYPE;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__EGENERIC_TYPE = ETYPED_ELEMENT__EGENERIC_TYPE;
        /**
         * The feature id for the '<em><b>Changeable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__CHANGEABLE = ETYPED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Volatile</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__VOLATILE = ETYPED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>Transient</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__TRANSIENT = ETYPED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>Default Value Literal</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__DEFAULT_VALUE_LITERAL = ETYPED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__DEFAULT_VALUE = ETYPED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>Unsettable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__UNSETTABLE = ETYPED_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The feature id for the '<em><b>Derived</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__DERIVED = ETYPED_ELEMENT_FEATURE_COUNT + 6;
        /**
         * The feature id for the '<em><b>EContaining Class</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE__ECONTAINING_CLASS = ETYPED_ELEMENT_FEATURE_COUNT + 7;
        /**
         * The number of structural features of the '<em>EStructural Feature</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE_FEATURE_COUNT = ETYPED_ELEMENT_FEATURE_COUNT + 8;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE___GET_EANNOTATION__STRING = ETYPED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Get Feature ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE___GET_FEATURE_ID = ETYPED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Get Container Class</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE___GET_CONTAINER_CLASS = ETYPED_ELEMENT_OPERATION_COUNT + 1;
        /**
         * The number of operations of the '<em>EStructural Feature</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRUCTURAL_FEATURE_OPERATION_COUNT = ETYPED_ELEMENT_OPERATION_COUNT + 2;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__EANNOTATIONS = ESTRUCTURAL_FEATURE__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__NAME = ESTRUCTURAL_FEATURE__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__ORDERED = ESTRUCTURAL_FEATURE__ORDERED;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__UNIQUE = ESTRUCTURAL_FEATURE__UNIQUE;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__LOWER_BOUND = ESTRUCTURAL_FEATURE__LOWER_BOUND;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__UPPER_BOUND = ESTRUCTURAL_FEATURE__UPPER_BOUND;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__MANY = ESTRUCTURAL_FEATURE__MANY;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__REQUIRED = ESTRUCTURAL_FEATURE__REQUIRED;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__ETYPE = ESTRUCTURAL_FEATURE__ETYPE;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__EGENERIC_TYPE = ESTRUCTURAL_FEATURE__EGENERIC_TYPE;
        /**
         * The feature id for the '<em><b>Changeable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__CHANGEABLE = ESTRUCTURAL_FEATURE__CHANGEABLE;
        /**
         * The feature id for the '<em><b>Volatile</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__VOLATILE = ESTRUCTURAL_FEATURE__VOLATILE;
        /**
         * The feature id for the '<em><b>Transient</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__TRANSIENT = ESTRUCTURAL_FEATURE__TRANSIENT;
        /**
         * The feature id for the '<em><b>Default Value Literal</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__DEFAULT_VALUE_LITERAL = ESTRUCTURAL_FEATURE__DEFAULT_VALUE_LITERAL;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__DEFAULT_VALUE = ESTRUCTURAL_FEATURE__DEFAULT_VALUE;
        /**
         * The feature id for the '<em><b>Unsettable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__UNSETTABLE = ESTRUCTURAL_FEATURE__UNSETTABLE;
        /**
         * The feature id for the '<em><b>Derived</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__DERIVED = ESTRUCTURAL_FEATURE__DERIVED;
        /**
         * The feature id for the '<em><b>EContaining Class</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__ECONTAINING_CLASS = ESTRUCTURAL_FEATURE__ECONTAINING_CLASS;
        /**
         * The feature id for the '<em><b>ID</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__ID = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>EAttribute Type</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE__EATTRIBUTE_TYPE = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 1;
        /**
         * The number of structural features of the '<em>EAttribute</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE_FEATURE_COUNT = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 2;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE___GET_EANNOTATION__STRING = ESTRUCTURAL_FEATURE___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Get Feature ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE___GET_FEATURE_ID = ESTRUCTURAL_FEATURE___GET_FEATURE_ID;
        /**
         * The operation id for the '<em>Get Container Class</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE___GET_CONTAINER_CLASS = ESTRUCTURAL_FEATURE___GET_CONTAINER_CLASS;
        /**
         * The number of operations of the '<em>EAttribute</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EATTRIBUTE_OPERATION_COUNT = ESTRUCTURAL_FEATURE_OPERATION_COUNT + 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EAnnotationImpl <em>EAnnotation</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EAnnotationImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEAnnotation()
         * @generated
         */
        const int EANNOTATION = 1;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__EANNOTATIONS = EMODEL_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Source</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__SOURCE = EMODEL_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Details</b></em>' map.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__DETAILS = EMODEL_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>EModel Element</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__EMODEL_ELEMENT = EMODEL_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>Contents</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__CONTENTS = EMODEL_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>References</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION__REFERENCES = EMODEL_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The number of structural features of the '<em>EAnnotation</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION_FEATURE_COUNT = EMODEL_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION___GET_EANNOTATION__STRING = EMODEL_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>EAnnotation</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EANNOTATION_OPERATION_COUNT = EMODEL_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EClassifierImpl <em>EClassifier</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EClassifierImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEClassifier()
         * @generated
         */
        const int ECLASSIFIER = 3;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__EANNOTATIONS = ENAMED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__NAME = ENAMED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Instance Class Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__INSTANCE_CLASS_NAME = ENAMED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Instance Class</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__INSTANCE_CLASS = ENAMED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__DEFAULT_VALUE = ENAMED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>Instance Type Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__INSTANCE_TYPE_NAME = ENAMED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>EPackage</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__EPACKAGE = ENAMED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>EType Parameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER__ETYPE_PARAMETERS = ENAMED_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The number of structural features of the '<em>EClassifier</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER_FEATURE_COUNT = ENAMED_ELEMENT_FEATURE_COUNT + 6;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER___GET_EANNOTATION__STRING = ENAMED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Is Instance</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER___IS_INSTANCE__OBJECT = ENAMED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Get Classifier ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER___GET_CLASSIFIER_ID = ENAMED_ELEMENT_OPERATION_COUNT + 1;
        /**
         * The number of operations of the '<em>EClassifier</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASSIFIER_OPERATION_COUNT = ENAMED_ELEMENT_OPERATION_COUNT + 2;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EANNOTATIONS = ECLASSIFIER__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__NAME = ECLASSIFIER__NAME;
        /**
         * The feature id for the '<em><b>Instance Class Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__INSTANCE_CLASS_NAME = ECLASSIFIER__INSTANCE_CLASS_NAME;
        /**
         * The feature id for the '<em><b>Instance Class</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__INSTANCE_CLASS = ECLASSIFIER__INSTANCE_CLASS;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__DEFAULT_VALUE = ECLASSIFIER__DEFAULT_VALUE;
        /**
         * The feature id for the '<em><b>Instance Type Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__INSTANCE_TYPE_NAME = ECLASSIFIER__INSTANCE_TYPE_NAME;
        /**
         * The feature id for the '<em><b>EPackage</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EPACKAGE = ECLASSIFIER__EPACKAGE;
        /**
         * The feature id for the '<em><b>EType Parameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__ETYPE_PARAMETERS = ECLASSIFIER__ETYPE_PARAMETERS;
        /**
         * The feature id for the '<em><b>Abstract</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__ABSTRACT = ECLASSIFIER_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Interface</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__INTERFACE = ECLASSIFIER_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>ESuper Types</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__ESUPER_TYPES = ECLASSIFIER_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>EOperations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EOPERATIONS = ECLASSIFIER_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>EAll Attributes</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_ATTRIBUTES = ECLASSIFIER_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>EAll References</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_REFERENCES = ECLASSIFIER_FEATURE_COUNT + 5;
        /**
         * The feature id for the '<em><b>EReferences</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EREFERENCES = ECLASSIFIER_FEATURE_COUNT + 6;
        /**
         * The feature id for the '<em><b>EAttributes</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EATTRIBUTES = ECLASSIFIER_FEATURE_COUNT + 7;
        /**
         * The feature id for the '<em><b>EAll Containments</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_CONTAINMENTS = ECLASSIFIER_FEATURE_COUNT + 8;
        /**
         * The feature id for the '<em><b>EAll Operations</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_OPERATIONS = ECLASSIFIER_FEATURE_COUNT + 9;
        /**
         * The feature id for the '<em><b>EAll Structural Features</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_STRUCTURAL_FEATURES = ECLASSIFIER_FEATURE_COUNT + 10;
        /**
         * The feature id for the '<em><b>EAll Super Types</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_SUPER_TYPES = ECLASSIFIER_FEATURE_COUNT + 11;
        /**
         * The feature id for the '<em><b>EID Attribute</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EID_ATTRIBUTE = ECLASSIFIER_FEATURE_COUNT + 12;
        /**
         * The feature id for the '<em><b>EStructural Features</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__ESTRUCTURAL_FEATURES = ECLASSIFIER_FEATURE_COUNT + 13;
        /**
         * The feature id for the '<em><b>EGeneric Super Types</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EGENERIC_SUPER_TYPES = ECLASSIFIER_FEATURE_COUNT + 14;
        /**
         * The feature id for the '<em><b>EAll Generic Super Types</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS__EALL_GENERIC_SUPER_TYPES = ECLASSIFIER_FEATURE_COUNT + 15;
        /**
         * The number of structural features of the '<em>EClass</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS_FEATURE_COUNT = ECLASSIFIER_FEATURE_COUNT + 16;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_EANNOTATION__STRING = ECLASSIFIER___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Is Instance</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___IS_INSTANCE__OBJECT = ECLASSIFIER___IS_INSTANCE__OBJECT;
        /**
         * The operation id for the '<em>Get Classifier ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_CLASSIFIER_ID = ECLASSIFIER___GET_CLASSIFIER_ID;
        /**
         * The operation id for the '<em>Is Super Type Of</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___IS_SUPER_TYPE_OF__ECLASS = ECLASSIFIER_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Get Feature Count</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_FEATURE_COUNT = ECLASSIFIER_OPERATION_COUNT + 1;
        /**
         * The operation id for the '<em>Get EStructural Feature</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_ESTRUCTURAL_FEATURE__INT = ECLASSIFIER_OPERATION_COUNT + 2;
        /**
         * The operation id for the '<em>Get Feature ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_FEATURE_ID__ESTRUCTURALFEATURE = ECLASSIFIER_OPERATION_COUNT + 3;
        /**
         * The operation id for the '<em>Get EStructural Feature</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_ESTRUCTURAL_FEATURE__STRING = ECLASSIFIER_OPERATION_COUNT + 4;
        /**
         * The operation id for the '<em>Get Operation Count</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_OPERATION_COUNT = ECLASSIFIER_OPERATION_COUNT + 5;
        /**
         * The operation id for the '<em>Get EOperation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_EOPERATION__INT = ECLASSIFIER_OPERATION_COUNT + 6;
        /**
         * The operation id for the '<em>Get Operation ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_OPERATION_ID__EOPERATION = ECLASSIFIER_OPERATION_COUNT + 7;
        /**
         * The operation id for the '<em>Get Override</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_OVERRIDE__EOPERATION = ECLASSIFIER_OPERATION_COUNT + 8;
        /**
         * The operation id for the '<em>Get Feature Type</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS___GET_FEATURE_TYPE__ESTRUCTURALFEATURE = ECLASSIFIER_OPERATION_COUNT + 9;
        /**
         * The number of operations of the '<em>EClass</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ECLASS_OPERATION_COUNT = ECLASSIFIER_OPERATION_COUNT + 10;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__EANNOTATIONS = ECLASSIFIER__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__NAME = ECLASSIFIER__NAME;
        /**
         * The feature id for the '<em><b>Instance Class Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__INSTANCE_CLASS_NAME = ECLASSIFIER__INSTANCE_CLASS_NAME;
        /**
         * The feature id for the '<em><b>Instance Class</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__INSTANCE_CLASS = ECLASSIFIER__INSTANCE_CLASS;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__DEFAULT_VALUE = ECLASSIFIER__DEFAULT_VALUE;
        /**
         * The feature id for the '<em><b>Instance Type Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__INSTANCE_TYPE_NAME = ECLASSIFIER__INSTANCE_TYPE_NAME;
        /**
         * The feature id for the '<em><b>EPackage</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__EPACKAGE = ECLASSIFIER__EPACKAGE;
        /**
         * The feature id for the '<em><b>EType Parameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__ETYPE_PARAMETERS = ECLASSIFIER__ETYPE_PARAMETERS;
        /**
         * The feature id for the '<em><b>Serializable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE__SERIALIZABLE = ECLASSIFIER_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>EData Type</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE_FEATURE_COUNT = ECLASSIFIER_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE___GET_EANNOTATION__STRING = ECLASSIFIER___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Is Instance</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE___IS_INSTANCE__OBJECT = ECLASSIFIER___IS_INSTANCE__OBJECT;
        /**
         * The operation id for the '<em>Get Classifier ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE___GET_CLASSIFIER_ID = ECLASSIFIER___GET_CLASSIFIER_ID;
        /**
         * The number of operations of the '<em>EData Type</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EDATA_TYPE_OPERATION_COUNT = ECLASSIFIER_OPERATION_COUNT + 0;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__EANNOTATIONS = EDATA_TYPE__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__NAME = EDATA_TYPE__NAME;
        /**
         * The feature id for the '<em><b>Instance Class Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__INSTANCE_CLASS_NAME = EDATA_TYPE__INSTANCE_CLASS_NAME;
        /**
         * The feature id for the '<em><b>Instance Class</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__INSTANCE_CLASS = EDATA_TYPE__INSTANCE_CLASS;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__DEFAULT_VALUE = EDATA_TYPE__DEFAULT_VALUE;
        /**
         * The feature id for the '<em><b>Instance Type Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__INSTANCE_TYPE_NAME = EDATA_TYPE__INSTANCE_TYPE_NAME;
        /**
         * The feature id for the '<em><b>EPackage</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__EPACKAGE = EDATA_TYPE__EPACKAGE;
        /**
         * The feature id for the '<em><b>EType Parameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__ETYPE_PARAMETERS = EDATA_TYPE__ETYPE_PARAMETERS;
        /**
         * The feature id for the '<em><b>Serializable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__SERIALIZABLE = EDATA_TYPE__SERIALIZABLE;
        /**
         * The feature id for the '<em><b>ELiterals</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM__ELITERALS = EDATA_TYPE_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>EEnum</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_FEATURE_COUNT = EDATA_TYPE_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___GET_EANNOTATION__STRING = EDATA_TYPE___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Is Instance</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___IS_INSTANCE__OBJECT = EDATA_TYPE___IS_INSTANCE__OBJECT;
        /**
         * The operation id for the '<em>Get Classifier ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___GET_CLASSIFIER_ID = EDATA_TYPE___GET_CLASSIFIER_ID;
        /**
         * The operation id for the '<em>Get EEnum Literal</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___GET_EENUM_LITERAL__STRING = EDATA_TYPE_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Get EEnum Literal</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___GET_EENUM_LITERAL__INT = EDATA_TYPE_OPERATION_COUNT + 1;
        /**
         * The operation id for the '<em>Get EEnum Literal By Literal</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM___GET_EENUM_LITERAL_BY_LITERAL__STRING = EDATA_TYPE_OPERATION_COUNT + 2;
        /**
         * The number of operations of the '<em>EEnum</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_OPERATION_COUNT = EDATA_TYPE_OPERATION_COUNT + 3;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__EANNOTATIONS = ENAMED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__NAME = ENAMED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__VALUE = ENAMED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Instance</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__INSTANCE = ENAMED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>Literal</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__LITERAL = ENAMED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>EEnum</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL__EENUM = ENAMED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The number of structural features of the '<em>EEnum Literal</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL_FEATURE_COUNT = ENAMED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL___GET_EANNOTATION__STRING = ENAMED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>EEnum Literal</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EENUM_LITERAL_OPERATION_COUNT = ENAMED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY__EANNOTATIONS = EMODEL_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>EPackage</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY__EPACKAGE = EMODEL_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>EFactory</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY_FEATURE_COUNT = EMODEL_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY___GET_EANNOTATION__STRING = EMODEL_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Create</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY___CREATE__ECLASS = EMODEL_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Create From String</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY___CREATE_FROM_STRING__EDATATYPE_STRING = EMODEL_ELEMENT_OPERATION_COUNT + 1;
        /**
         * The operation id for the '<em>Convert To String</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY___CONVERT_TO_STRING__EDATATYPE_OBJECT = EMODEL_ELEMENT_OPERATION_COUNT + 2;
        /**
         * The number of operations of the '<em>EFactory</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EFACTORY_OPERATION_COUNT = EMODEL_ELEMENT_OPERATION_COUNT + 3;
        /**
         * The number of structural features of the '<em>EObject</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT_FEATURE_COUNT = 0;
        /**
         * The operation id for the '<em>EClass</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECLASS = 0;
        /**
         * The operation id for the '<em>EIs Proxy</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EIS_PROXY = 1;
        /**
         * The operation id for the '<em>EResource</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ERESOURCE = 2;
        /**
         * The operation id for the '<em>EContainer</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECONTAINER = 3;
        /**
         * The operation id for the '<em>EContaining Feature</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECONTAINING_FEATURE = 4;
        /**
         * The operation id for the '<em>EContainment Feature</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECONTAINMENT_FEATURE = 5;
        /**
         * The operation id for the '<em>EContents</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECONTENTS = 6;
        /**
         * The operation id for the '<em>EAll Contents</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EALL_CONTENTS = 7;
        /**
         * The operation id for the '<em>ECross References</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ECROSS_REFERENCES = 8;
        /**
         * The operation id for the '<em>EGet</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EGET__ESTRUCTURALFEATURE = 9;
        /**
         * The operation id for the '<em>EGet</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EGET__ESTRUCTURALFEATURE_BOOLEAN = 10;
        /**
         * The operation id for the '<em>ESet</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___ESET__ESTRUCTURALFEATURE_OBJECT = 11;
        /**
         * The operation id for the '<em>EIs Set</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EIS_SET__ESTRUCTURALFEATURE = 12;
        /**
         * The operation id for the '<em>EUnset</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EUNSET__ESTRUCTURALFEATURE = 13;
        /**
         * The operation id for the '<em>EInvoke</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT___EINVOKE__EOPERATION_ELIST = 14;
        /**
         * The number of operations of the '<em>EObject</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOBJECT_OPERATION_COUNT = 15;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__EANNOTATIONS = ETYPED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__NAME = ETYPED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__ORDERED = ETYPED_ELEMENT__ORDERED;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__UNIQUE = ETYPED_ELEMENT__UNIQUE;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__LOWER_BOUND = ETYPED_ELEMENT__LOWER_BOUND;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__UPPER_BOUND = ETYPED_ELEMENT__UPPER_BOUND;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__MANY = ETYPED_ELEMENT__MANY;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__REQUIRED = ETYPED_ELEMENT__REQUIRED;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__ETYPE = ETYPED_ELEMENT__ETYPE;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__EGENERIC_TYPE = ETYPED_ELEMENT__EGENERIC_TYPE;
        /**
         * The feature id for the '<em><b>EContaining Class</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__ECONTAINING_CLASS = ETYPED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>EType Parameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__ETYPE_PARAMETERS = ETYPED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>EParameters</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__EPARAMETERS = ETYPED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>EExceptions</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__EEXCEPTIONS = ETYPED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>EGeneric Exceptions</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION__EGENERIC_EXCEPTIONS = ETYPED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The number of structural features of the '<em>EOperation</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION_FEATURE_COUNT = ETYPED_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION___GET_EANNOTATION__STRING = ETYPED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Get Operation ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION___GET_OPERATION_ID = ETYPED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The operation id for the '<em>Is Override Of</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION___IS_OVERRIDE_OF__EOPERATION = ETYPED_ELEMENT_OPERATION_COUNT + 1;
        /**
         * The number of operations of the '<em>EOperation</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EOPERATION_OPERATION_COUNT = ETYPED_ELEMENT_OPERATION_COUNT + 2;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__EANNOTATIONS = ENAMED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__NAME = ENAMED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Ns URI</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__NS_URI = ENAMED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Ns Prefix</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__NS_PREFIX = ENAMED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>EFactory Instance</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__EFACTORY_INSTANCE = ENAMED_ELEMENT_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>EClassifiers</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__ECLASSIFIERS = ENAMED_ELEMENT_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>ESubpackages</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__ESUBPACKAGES = ENAMED_ELEMENT_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>ESuper Package</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE__ESUPER_PACKAGE = ENAMED_ELEMENT_FEATURE_COUNT + 5;
        /**
         * The number of structural features of the '<em>EPackage</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE_FEATURE_COUNT = ENAMED_ELEMENT_FEATURE_COUNT + 6;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE___GET_EANNOTATION__STRING = ENAMED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Get EClassifier</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE___GET_ECLASSIFIER__STRING = ENAMED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The number of operations of the '<em>EPackage</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPACKAGE_OPERATION_COUNT = ENAMED_ELEMENT_OPERATION_COUNT + 1;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__EANNOTATIONS = ETYPED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__NAME = ETYPED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__ORDERED = ETYPED_ELEMENT__ORDERED;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__UNIQUE = ETYPED_ELEMENT__UNIQUE;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__LOWER_BOUND = ETYPED_ELEMENT__LOWER_BOUND;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__UPPER_BOUND = ETYPED_ELEMENT__UPPER_BOUND;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__MANY = ETYPED_ELEMENT__MANY;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__REQUIRED = ETYPED_ELEMENT__REQUIRED;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__ETYPE = ETYPED_ELEMENT__ETYPE;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__EGENERIC_TYPE = ETYPED_ELEMENT__EGENERIC_TYPE;
        /**
         * The feature id for the '<em><b>EOperation</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER__EOPERATION = ETYPED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>EParameter</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER_FEATURE_COUNT = ETYPED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER___GET_EANNOTATION__STRING = ETYPED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>EParameter</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EPARAMETER_OPERATION_COUNT = ETYPED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__EANNOTATIONS = ESTRUCTURAL_FEATURE__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__NAME = ESTRUCTURAL_FEATURE__NAME;
        /**
         * The feature id for the '<em><b>Ordered</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__ORDERED = ESTRUCTURAL_FEATURE__ORDERED;
        /**
         * The feature id for the '<em><b>Unique</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__UNIQUE = ESTRUCTURAL_FEATURE__UNIQUE;
        /**
         * The feature id for the '<em><b>Lower Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__LOWER_BOUND = ESTRUCTURAL_FEATURE__LOWER_BOUND;
        /**
         * The feature id for the '<em><b>Upper Bound</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__UPPER_BOUND = ESTRUCTURAL_FEATURE__UPPER_BOUND;
        /**
         * The feature id for the '<em><b>Many</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__MANY = ESTRUCTURAL_FEATURE__MANY;
        /**
         * The feature id for the '<em><b>Required</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__REQUIRED = ESTRUCTURAL_FEATURE__REQUIRED;
        /**
         * The feature id for the '<em><b>EType</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__ETYPE = ESTRUCTURAL_FEATURE__ETYPE;
        /**
         * The feature id for the '<em><b>EGeneric Type</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__EGENERIC_TYPE = ESTRUCTURAL_FEATURE__EGENERIC_TYPE;
        /**
         * The feature id for the '<em><b>Changeable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__CHANGEABLE = ESTRUCTURAL_FEATURE__CHANGEABLE;
        /**
         * The feature id for the '<em><b>Volatile</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__VOLATILE = ESTRUCTURAL_FEATURE__VOLATILE;
        /**
         * The feature id for the '<em><b>Transient</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__TRANSIENT = ESTRUCTURAL_FEATURE__TRANSIENT;
        /**
         * The feature id for the '<em><b>Default Value Literal</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__DEFAULT_VALUE_LITERAL = ESTRUCTURAL_FEATURE__DEFAULT_VALUE_LITERAL;
        /**
         * The feature id for the '<em><b>Default Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__DEFAULT_VALUE = ESTRUCTURAL_FEATURE__DEFAULT_VALUE;
        /**
         * The feature id for the '<em><b>Unsettable</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__UNSETTABLE = ESTRUCTURAL_FEATURE__UNSETTABLE;
        /**
         * The feature id for the '<em><b>Derived</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__DERIVED = ESTRUCTURAL_FEATURE__DERIVED;
        /**
         * The feature id for the '<em><b>EContaining Class</b></em>' container reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__ECONTAINING_CLASS = ESTRUCTURAL_FEATURE__ECONTAINING_CLASS;
        /**
         * The feature id for the '<em><b>Containment</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__CONTAINMENT = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 0;
        /**
         * The feature id for the '<em><b>Container</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__CONTAINER = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 1;
        /**
         * The feature id for the '<em><b>Resolve Proxies</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__RESOLVE_PROXIES = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 2;
        /**
         * The feature id for the '<em><b>EOpposite</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__EOPPOSITE = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 3;
        /**
         * The feature id for the '<em><b>EReference Type</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__EREFERENCE_TYPE = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 4;
        /**
         * The feature id for the '<em><b>EKeys</b></em>' reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE__EKEYS = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 5;
        /**
         * The number of structural features of the '<em>EReference</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE_FEATURE_COUNT = ESTRUCTURAL_FEATURE_FEATURE_COUNT + 6;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE___GET_EANNOTATION__STRING = ESTRUCTURAL_FEATURE___GET_EANNOTATION__STRING;
        /**
         * The operation id for the '<em>Get Feature ID</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE___GET_FEATURE_ID = ESTRUCTURAL_FEATURE___GET_FEATURE_ID;
        /**
         * The operation id for the '<em>Get Container Class</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE___GET_CONTAINER_CLASS = ESTRUCTURAL_FEATURE___GET_CONTAINER_CLASS;
        /**
         * The number of operations of the '<em>EReference</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EREFERENCE_OPERATION_COUNT = ESTRUCTURAL_FEATURE_OPERATION_COUNT + 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EStringToStringMapEntryImpl <em>EString To String Map Entry</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EStringToStringMapEntryImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEStringToStringMapEntry()
         * @generated
         */
        const int ESTRING_TO_STRING_MAP_ENTRY = 17;
        /**
         * The feature id for the '<em><b>Key</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRING_TO_STRING_MAP_ENTRY__KEY = 0;
        /**
         * The feature id for the '<em><b>Value</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRING_TO_STRING_MAP_ENTRY__VALUE = 1;
        /**
         * The number of structural features of the '<em>EString To String Map Entry</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRING_TO_STRING_MAP_ENTRY_FEATURE_COUNT = 2;
        /**
         * The number of operations of the '<em>EString To String Map Entry</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ESTRING_TO_STRING_MAP_ENTRY_OPERATION_COUNT = 0;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.EGenericTypeImpl <em>EGeneric Type</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EGenericTypeImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEGenericType()
         * @generated
         */
        const int EGENERIC_TYPE = 18;
        /**
         * The feature id for the '<em><b>EUpper Bound</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__EUPPER_BOUND = 0;
        /**
         * The feature id for the '<em><b>EType Arguments</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__ETYPE_ARGUMENTS = 1;
        /**
         * The feature id for the '<em><b>ERaw Type</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__ERAW_TYPE = 2;
        /**
         * The feature id for the '<em><b>ELower Bound</b></em>' containment reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__ELOWER_BOUND = 3;
        /**
         * The feature id for the '<em><b>EType Parameter</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__ETYPE_PARAMETER = 4;
        /**
         * The feature id for the '<em><b>EClassifier</b></em>' reference.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE__ECLASSIFIER = 5;
        /**
         * The number of structural features of the '<em>EGeneric Type</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE_FEATURE_COUNT = 6;
        /**
         * The operation id for the '<em>Is Instance</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE___IS_INSTANCE__OBJECT = 0;
        /**
         * The number of operations of the '<em>EGeneric Type</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int EGENERIC_TYPE_OPERATION_COUNT = 1;
        /**
         * The meta object id for the '{@link org.eclipse.emf.ecore.impl.ETypeParameterImpl <em>EType Parameter</em>}' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.ETypeParameterImpl
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getETypeParameter()
         * @generated
         */
        const int ETYPE_PARAMETER = 19;
        /**
         * The feature id for the '<em><b>EAnnotations</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER__EANNOTATIONS = ENAMED_ELEMENT__EANNOTATIONS;
        /**
         * The feature id for the '<em><b>Name</b></em>' attribute.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER__NAME = ENAMED_ELEMENT__NAME;
        /**
         * The feature id for the '<em><b>EBounds</b></em>' containment reference list.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER__EBOUNDS = ENAMED_ELEMENT_FEATURE_COUNT + 0;
        /**
         * The number of structural features of the '<em>EType Parameter</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER_FEATURE_COUNT = ENAMED_ELEMENT_FEATURE_COUNT + 1;
        /**
         * The operation id for the '<em>Get EAnnotation</em>' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER___GET_EANNOTATION__STRING = ENAMED_ELEMENT___GET_EANNOTATION__STRING;
        /**
         * The number of operations of the '<em>EType Parameter</em>' class.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @generated
         * @ordered
         */
        const int ETYPE_PARAMETER_OPERATION_COUNT = ENAMED_ELEMENT_OPERATION_COUNT + 0;
        /**
         * The meta object id for the '<em>EBig Decimal</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.math.BigDecimal
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEBigDecimal()
         * @generated
         */
        const int EBIG_DECIMAL = 20;
        /**
         * The meta object id for the '<em>EBig Integer</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.math.BigInteger
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEBigInteger()
         * @generated
         */
        const int EBIG_INTEGER = 21;
        /**
         * The meta object id for the '<em>EE List</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.common.util.EList
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEEList()
         * @generated
         */
        const int EE_LIST = 33;
        /**
         * The meta object id for the '<em>EResource</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.resource.Resource
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEResource()
         * @generated
         */
        const int ERESOURCE = 46;
        /**
         * The meta object id for the '<em>EResource Set</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.resource.ResourceSet
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEResourceSet()
         * @generated
         */
        const int ERESOURCE_SET = 47;
        /**
         * The meta object id for the '<em>EBoolean Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Boolean
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEBooleanObject()
         * @generated
         */
        const int EBOOLEAN_OBJECT = 23;
        /**
         * The meta object id for the '<em>ECharacter Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Character
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getECharacterObject()
         * @generated
         */
        const int ECHARACTER_OBJECT = 28;
        /**
         * The meta object id for the '<em>EDate</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.util.Date
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEDate()
         * @generated
         */
        const int EDATE = 29;
        /**
         * The meta object id for the '<em>EDiagnostic Chain</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.common.util.DiagnosticChain
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEDiagnosticChain()
         * @generated
         */
        const int EDIAGNOSTIC_CHAIN = 30;
        /**
         * The meta object id for the '<em>EDouble Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Double
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEDoubleObject()
         * @generated
         */
        const int EDOUBLE_OBJECT = 32;
        /**
         * The meta object id for the '<em>EFloat Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Float
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEFloatObject()
         * @generated
         */
        const int EFLOAT_OBJECT = 38;
        /**
         * The meta object id for the '<em>EInteger Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Integer
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEIntegerObject()
         * @generated
         */
        const int EINTEGER_OBJECT = 40;
        /**
         * The meta object id for the '<em>EBoolean</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEBoolean()
         * @generated
         */
        const int EBOOLEAN = 22;
        /**
         * The meta object id for the '<em>EByte Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Byte
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEByteObject()
         * @generated
         */
        const int EBYTE_OBJECT = 26;
        /**
         * The meta object id for the '<em>EByte</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEByte()
         * @generated
         */
        const int EBYTE = 24;
        /**
         * The meta object id for the '<em>EByte Array</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEByteArray()
         * @generated
         */
        const int EBYTE_ARRAY = 25;
        /**
         * The meta object id for the '<em>EChar</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEChar()
         * @generated
         */
        const int ECHAR = 27;
        /**
         * The meta object id for the '<em>EDouble</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEDouble()
         * @generated
         */
        const int EDOUBLE = 31;
        /**
         * The meta object id for the '<em>EFloat</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEFloat()
         * @generated
         */
        const int EFLOAT = 37;
        /**
         * The meta object id for the '<em>EInt</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEInt()
         * @generated
         */
        const int EINT = 39;
        /**
         * The meta object id for the '<em>EJava Class</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Class
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEJavaClass()
         * @generated
         */
        const int EJAVA_CLASS = 41;
        /**
         * The meta object id for the '<em>EJava Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Object
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEJavaObject()
         * @generated
         */
        const int EJAVA_OBJECT = 42;
        /**
         * The meta object id for the '<em>ELong Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Long
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getELongObject()
         * @generated
         */
        const int ELONG_OBJECT = 44;
        /**
         * The meta object id for the '<em>EMap</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.util.Map
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEMap()
         * @generated
         */
        const int EMAP = 45;
        /**
         * The meta object id for the '<em>EShort Object</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.Short
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEShortObject()
         * @generated
         */
        const int ESHORT_OBJECT = 49;
        /**
         * The meta object id for the '<em>ELong</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getELong()
         * @generated
         */
        const int ELONG = 43;
        /**
         * The meta object id for the '<em>EShort</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEShort()
         * @generated
         */
        const int ESHORT = 48;
        /**
         * The meta object id for the '<em>ETree Iterator</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.common.util.TreeIterator
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getETreeIterator()
         * @generated
         */
        const int ETREE_ITERATOR = 51;
        /**
         * The meta object id for the '<em>EInvocation Target Exception</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.reflect.InvocationTargetException
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEInvocationTargetException()
         * @generated
         */
        const int EINVOCATION_TARGET_EXCEPTION = 52;
        /**
         * The meta object id for the '<em>EFeature Map Entry</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.util.FeatureMap.Entry
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEFeatureMapEntry()
         * @generated
         */
        const int EFEATURE_MAP_ENTRY = 36;
        /**
         * The meta object id for the '<em>EEnumerator</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.common.util.Enumerator
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEEnumerator()
         * @generated
         */
        const int EENUMERATOR = 34;
        /**
         * The meta object id for the '<em>EFeature Map</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see org.eclipse.emf.ecore.util.FeatureMap
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEFeatureMap()
         * @generated
         */
        const int EFEATURE_MAP = 35;
        /**
         * The meta object id for the '<em>EString</em>' data type.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @see java.lang.String
         * @see org.eclipse.emf.ecore.impl.EcorePackageImpl#getEString()
         * @generated
         */
        const int ESTRING = 50;
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EAttribute <em>EAttribute</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EAttribute</em>'.
         * @see org.eclipse.emf.ecore.EAttribute
         * @generated
         */
        EClass GetEAttribute();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EAttribute#isID <em>ID</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>ID</em>'.
         * @see org.eclipse.emf.ecore.EAttribute#isID()
         * @see #getEAttribute()
         * @generated
         */
        EAttribute GetEAttribute_ID();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EAttribute#getEAttributeType <em>EAttribute Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EAttribute Type</em>'.
         * @see org.eclipse.emf.ecore.EAttribute#getEAttributeType()
         * @see #getEAttribute()
         * @generated
         */
        EReference GetEAttribute_EAttributeType();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EAnnotation <em>EAnnotation</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EAnnotation</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation
         * @generated
         */
        EClass GetEAnnotation();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EAnnotation#getSource <em>Source</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Source</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation#getSource()
         * @see #getEAnnotation()
         * @generated
         */
        EAttribute GetEAnnotation_Source();
        /**
         * Returns the meta object for the map '{@link org.eclipse.emf.ecore.EAnnotation#getDetails <em>Details</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the map '<em>Details</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation#getDetails()
         * @see #getEAnnotation()
         * @generated
         */
        EReference GetEAnnotation_Details();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EAnnotation#getEModelElement <em>EModel Element</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EModel Element</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation#getEModelElement()
         * @see #getEAnnotation()
         * @generated
         */
        EReference GetEAnnotation_EModelElement();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EAnnotation#getContents <em>Contents</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>Contents</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation#getContents()
         * @see #getEAnnotation()
         * @generated
         */
        EReference GetEAnnotation_Contents();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EAnnotation#getReferences <em>References</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>References</em>'.
         * @see org.eclipse.emf.ecore.EAnnotation#getReferences()
         * @see #getEAnnotation()
         * @generated
         */
        EReference GetEAnnotation_References();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EClass <em>EClass</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EClass</em>'.
         * @see org.eclipse.emf.ecore.EClass
         * @generated
         */
        EClass GetEClass();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClass#isAbstract <em>Abstract</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Abstract</em>'.
         * @see org.eclipse.emf.ecore.EClass#isAbstract()
         * @see #getEClass()
         * @generated
         */
        EAttribute GetEClass_Abstract();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClass#isInterface <em>Interface</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Interface</em>'.
         * @see org.eclipse.emf.ecore.EClass#isInterface()
         * @see #getEClass()
         * @generated
         */
        EAttribute GetEClass_Interface();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getESuperTypes <em>ESuper Types</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>ESuper Types</em>'.
         * @see org.eclipse.emf.ecore.EClass#getESuperTypes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_ESuperTypes();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EClass#getEOperations <em>EOperations</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EOperations</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEOperations()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EOperations();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllAttributes <em>EAll Attributes</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Attributes</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllAttributes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllAttributes();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllReferences <em>EAll References</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll References</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllReferences()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllReferences();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEReferences <em>EReferences</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EReferences</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEReferences()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EReferences();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAttributes <em>EAttributes</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAttributes</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAttributes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAttributes();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllContainments <em>EAll Containments</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Containments</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllContainments()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllContainments();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllOperations <em>EAll Operations</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Operations</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllOperations()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllOperations();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllStructuralFeatures <em>EAll Structural Features</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Structural Features</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllStructuralFeatures()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllStructuralFeatures();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllSuperTypes <em>EAll Super Types</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Super Types</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllSuperTypes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllSuperTypes();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EClass#getEIDAttribute <em>EID Attribute</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EID Attribute</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEIDAttribute()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EIDAttribute();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EClass#getEStructuralFeatures <em>EStructural Features</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EStructural Features</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEStructuralFeatures()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EStructuralFeatures();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EClass#getEGenericSuperTypes <em>EGeneric Super Types</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EGeneric Super Types</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEGenericSuperTypes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EGenericSuperTypes();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EClass#getEAllGenericSuperTypes <em>EAll Generic Super Types</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EAll Generic Super Types</em>'.
         * @see org.eclipse.emf.ecore.EClass#getEAllGenericSuperTypes()
         * @see #getEClass()
         * @generated
         */
        EReference GetEClass_EAllGenericSuperTypes();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#isSuperTypeOf(org.eclipse.emf.ecore.EClass) <em>Is Super Type Of</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Is Super Type Of</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#isSuperTypeOf(org.eclipse.emf.ecore.EClass)
         * @generated
         */
        EOperation GetEClass__IsSuperTypeOf__EClass();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getFeatureCount() <em>Get Feature Count</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Feature Count</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getFeatureCount()
         * @generated
         */
        EOperation GetEClass__GetFeatureCount();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getEStructuralFeature(int) <em>Get EStructural Feature</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EStructural Feature</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getEStructuralFeature(int)
         * @generated
         */
        EOperation GetEClass__GetEStructuralFeature__int();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getFeatureID(org.eclipse.emf.ecore.EStructuralFeature) <em>Get Feature ID</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Feature ID</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getFeatureID(org.eclipse.emf.ecore.EStructuralFeature)
         * @generated
         */
        EOperation GetEClass__GetFeatureID__EStructuralFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getEStructuralFeature(java.lang.String) <em>Get EStructural Feature</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EStructural Feature</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getEStructuralFeature(java.lang.String)
         * @generated
         */
        EOperation GetEClass__GetEStructuralFeature__String();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getOperationCount() <em>Get Operation Count</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Operation Count</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getOperationCount()
         * @generated
         */
        EOperation GetEClass__GetOperationCount();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getEOperation(int) <em>Get EOperation</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EOperation</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getEOperation(int)
         * @generated
         */
        EOperation GetEClass__GetEOperation__int();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getOperationID(org.eclipse.emf.ecore.EOperation) <em>Get Operation ID</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Operation ID</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getOperationID(org.eclipse.emf.ecore.EOperation)
         * @generated
         */
        EOperation GetEClass__GetOperationID__EOperation();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getOverride(org.eclipse.emf.ecore.EOperation) <em>Get Override</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Override</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getOverride(org.eclipse.emf.ecore.EOperation)
         * @generated
         */
        EOperation GetEClass__GetOverride__EOperation();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClass#getFeatureType(org.eclipse.emf.ecore.EStructuralFeature) <em>Get Feature Type</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Feature Type</em>' operation.
         * @see org.eclipse.emf.ecore.EClass#getFeatureType(org.eclipse.emf.ecore.EStructuralFeature)
         * @generated
         */
        EOperation GetEClass__GetFeatureType__EStructuralFeature();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EDataType <em>EData Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EData Type</em>'.
         * @see org.eclipse.emf.ecore.EDataType
         * @generated
         */
        EClass GetEDataType();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EDataType#isSerializable <em>Serializable</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Serializable</em>'.
         * @see org.eclipse.emf.ecore.EDataType#isSerializable()
         * @see #getEDataType()
         * @generated
         */
        EAttribute GetEDataType_Serializable();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EEnum <em>EEnum</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EEnum</em>'.
         * @see org.eclipse.emf.ecore.EEnum
         * @generated
         */
        EClass GetEEnum();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EEnum#getELiterals <em>ELiterals</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>ELiterals</em>'.
         * @see org.eclipse.emf.ecore.EEnum#getELiterals()
         * @see #getEEnum()
         * @generated
         */
        EReference GetEEnum_ELiterals();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EEnum#getEEnumLiteral(java.lang.String) <em>Get EEnum Literal</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EEnum Literal</em>' operation.
         * @see org.eclipse.emf.ecore.EEnum#getEEnumLiteral(java.lang.String)
         * @generated
         */
        EOperation GetEEnum__GetEEnumLiteral__String();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EEnum#getEEnumLiteral(int) <em>Get EEnum Literal</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EEnum Literal</em>' operation.
         * @see org.eclipse.emf.ecore.EEnum#getEEnumLiteral(int)
         * @generated
         */
        EOperation GetEEnum__GetEEnumLiteral__int();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EEnum#getEEnumLiteralByLiteral(java.lang.String) <em>Get EEnum Literal By Literal</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EEnum Literal By Literal</em>' operation.
         * @see org.eclipse.emf.ecore.EEnum#getEEnumLiteralByLiteral(java.lang.String)
         * @generated
         */
        EOperation GetEEnum__GetEEnumLiteralByLiteral__String();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EEnumLiteral <em>EEnum Literal</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EEnum Literal</em>'.
         * @see org.eclipse.emf.ecore.EEnumLiteral
         * @generated
         */
        EClass GetEEnumLiteral();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EEnumLiteral#getValue <em>Value</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Value</em>'.
         * @see org.eclipse.emf.ecore.EEnumLiteral#getValue()
         * @see #getEEnumLiteral()
         * @generated
         */
        EAttribute GetEEnumLiteral_Value();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EEnumLiteral#getInstance <em>Instance</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Instance</em>'.
         * @see org.eclipse.emf.ecore.EEnumLiteral#getInstance()
         * @see #getEEnumLiteral()
         * @generated
         */
        EAttribute GetEEnumLiteral_Instance();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EEnumLiteral#getLiteral <em>Literal</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Literal</em>'.
         * @see org.eclipse.emf.ecore.EEnumLiteral#getLiteral()
         * @see #getEEnumLiteral()
         * @generated
         */
        EAttribute GetEEnumLiteral_Literal();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EEnumLiteral#getEEnum <em>EEnum</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EEnum</em>'.
         * @see org.eclipse.emf.ecore.EEnumLiteral#getEEnum()
         * @see #getEEnumLiteral()
         * @generated
         */
        EReference GetEEnumLiteral_EEnum();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EFactory <em>EFactory</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EFactory</em>'.
         * @see org.eclipse.emf.ecore.EFactory
         * @generated
         */
        EClass GetEFactory();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EFactory#getEPackage <em>EPackage</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EPackage</em>'.
         * @see org.eclipse.emf.ecore.EFactory#getEPackage()
         * @see #getEFactory()
         * @generated
         */
        EReference GetEFactory_EPackage();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EFactory#create(org.eclipse.emf.ecore.EClass) <em>Create</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Create</em>' operation.
         * @see org.eclipse.emf.ecore.EFactory#create(org.eclipse.emf.ecore.EClass)
         * @generated
         */
        EOperation GetEFactory__Create__EClass();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EFactory#createFromString(org.eclipse.emf.ecore.EDataType, java.lang.String) <em>Create From String</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Create From String</em>' operation.
         * @see org.eclipse.emf.ecore.EFactory#createFromString(org.eclipse.emf.ecore.EDataType, java.lang.String)
         * @generated
         */
        EOperation GetEFactory__CreateFromString__EDataType_String();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EFactory#convertToString(org.eclipse.emf.ecore.EDataType, java.lang.Object) <em>Convert To String</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Convert To String</em>' operation.
         * @see org.eclipse.emf.ecore.EFactory#convertToString(org.eclipse.emf.ecore.EDataType, java.lang.Object)
         * @generated
         */
        EOperation GetEFactory__ConvertToString__EDataType_Object();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EClassifier <em>EClassifier</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EClassifier</em>'.
         * @see org.eclipse.emf.ecore.EClassifier
         * @generated
         */
        EClass GetEClassifier();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClassifier#getInstanceClassName <em>Instance Class Name</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Instance Class Name</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getInstanceClassName()
         * @see #getEClassifier()
         * @generated
         */
        EAttribute GetEClassifier_InstanceClassName();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClassifier#getInstanceClass <em>Instance Class</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Instance Class</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getInstanceClass()
         * @see #getEClassifier()
         * @generated
         */
        EAttribute GetEClassifier_InstanceClass();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClassifier#getDefaultValue <em>Default Value</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Default Value</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getDefaultValue()
         * @see #getEClassifier()
         * @generated
         */
        EAttribute GetEClassifier_DefaultValue();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EClassifier#getInstanceTypeName <em>Instance Type Name</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Instance Type Name</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getInstanceTypeName()
         * @see #getEClassifier()
         * @generated
         */
        EAttribute GetEClassifier_InstanceTypeName();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EClassifier#getEPackage <em>EPackage</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EPackage</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getEPackage()
         * @see #getEClassifier()
         * @generated
         */
        EReference GetEClassifier_EPackage();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EClassifier#getETypeParameters <em>EType Parameters</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EType Parameters</em>'.
         * @see org.eclipse.emf.ecore.EClassifier#getETypeParameters()
         * @see #getEClassifier()
         * @generated
         */
        EReference GetEClassifier_ETypeParameters();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClassifier#isInstance(java.lang.Object) <em>Is Instance</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Is Instance</em>' operation.
         * @see org.eclipse.emf.ecore.EClassifier#isInstance(java.lang.Object)
         * @generated
         */
        EOperation GetEClassifier__IsInstance__Object();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EClassifier#getClassifierID() <em>Get Classifier ID</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Classifier ID</em>' operation.
         * @see org.eclipse.emf.ecore.EClassifier#getClassifierID()
         * @generated
         */
        EOperation GetEClassifier__GetClassifierID();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EModelElement <em>EModel Element</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EModel Element</em>'.
         * @see org.eclipse.emf.ecore.EModelElement
         * @generated
         */
        EClass GetEModelElement();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EModelElement#getEAnnotations <em>EAnnotations</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EAnnotations</em>'.
         * @see org.eclipse.emf.ecore.EModelElement#getEAnnotations()
         * @see #getEModelElement()
         * @generated
         */
        EReference GetEModelElement_EAnnotations();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EModelElement#getEAnnotation(java.lang.String) <em>Get EAnnotation</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EAnnotation</em>' operation.
         * @see org.eclipse.emf.ecore.EModelElement#getEAnnotation(java.lang.String)
         * @generated
         */
        EOperation GetEModelElement__GetEAnnotation__String();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.ENamedElement <em>ENamed Element</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>ENamed Element</em>'.
         * @see org.eclipse.emf.ecore.ENamedElement
         * @generated
         */
        EClass GetENamedElement();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ENamedElement#getName <em>Name</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Name</em>'.
         * @see org.eclipse.emf.ecore.ENamedElement#getName()
         * @see #getENamedElement()
         * @generated
         */
        EAttribute GetENamedElement_Name();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EObject <em>EObject</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EObject</em>'.
         * @see org.eclipse.emf.ecore.EObject
         * @generated
         */
        EClass GetEObject();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eClass() <em>EClass</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EClass</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eClass()
         * @generated
         */
        EOperation GetEObject__EClass();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eIsProxy() <em>EIs Proxy</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EIs Proxy</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eIsProxy()
         * @generated
         */
        EOperation GetEObject__EIsProxy();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eResource() <em>EResource</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EResource</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eResource()
         * @generated
         */
        EOperation GetEObject__EResource();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eContainer() <em>EContainer</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EContainer</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eContainer()
         * @generated
         */
        EOperation GetEObject__EContainer();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eContainingFeature() <em>EContaining Feature</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EContaining Feature</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eContainingFeature()
         * @generated
         */
        EOperation GetEObject__EContainingFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eContainmentFeature() <em>EContainment Feature</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EContainment Feature</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eContainmentFeature()
         * @generated
         */
        EOperation GetEObject__EContainmentFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eContents() <em>EContents</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EContents</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eContents()
         * @generated
         */
        EOperation GetEObject__EContents();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eAllContents() <em>EAll Contents</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EAll Contents</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eAllContents()
         * @generated
         */
        EOperation GetEObject__EAllContents();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eCrossReferences() <em>ECross References</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>ECross References</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eCrossReferences()
         * @generated
         */
        EOperation GetEObject__ECrossReferences();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eGet(org.eclipse.emf.ecore.EStructuralFeature) <em>EGet</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EGet</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eGet(org.eclipse.emf.ecore.EStructuralFeature)
         * @generated
         */
        EOperation GetEObject__EGet__EStructuralFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eGet(org.eclipse.emf.ecore.EStructuralFeature, boolean) <em>EGet</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EGet</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eGet(org.eclipse.emf.ecore.EStructuralFeature, boolean)
         * @generated
         */
        EOperation GetEObject__EGet__EStructuralFeature_boolean();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eSet(org.eclipse.emf.ecore.EStructuralFeature, java.lang.Object) <em>ESet</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>ESet</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eSet(org.eclipse.emf.ecore.EStructuralFeature, java.lang.Object)
         * @generated
         */
        EOperation GetEObject__ESet__EStructuralFeature_Object();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eIsSet(org.eclipse.emf.ecore.EStructuralFeature) <em>EIs Set</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EIs Set</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eIsSet(org.eclipse.emf.ecore.EStructuralFeature)
         * @generated
         */
        EOperation GetEObject__EIsSet__EStructuralFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eUnset(org.eclipse.emf.ecore.EStructuralFeature) <em>EUnset</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EUnset</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eUnset(org.eclipse.emf.ecore.EStructuralFeature)
         * @generated
         */
        EOperation GetEObject__EUnset__EStructuralFeature();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EObject#eInvoke(org.eclipse.emf.ecore.EOperation, org.eclipse.emf.common.util.EList) <em>EInvoke</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>EInvoke</em>' operation.
         * @see org.eclipse.emf.ecore.EObject#eInvoke(org.eclipse.emf.ecore.EOperation, org.eclipse.emf.common.util.EList)
         * @generated
         */
        EOperation GetEObject__EInvoke__EOperation_EList();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EOperation <em>EOperation</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EOperation</em>'.
         * @see org.eclipse.emf.ecore.EOperation
         * @generated
         */
        EClass GetEOperation();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EOperation#getEContainingClass <em>EContaining Class</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EContaining Class</em>'.
         * @see org.eclipse.emf.ecore.EOperation#getEContainingClass()
         * @see #getEOperation()
         * @generated
         */
        EReference GetEOperation_EContainingClass();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EOperation#getEParameters <em>EParameters</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EParameters</em>'.
         * @see org.eclipse.emf.ecore.EOperation#getEParameters()
         * @see #getEOperation()
         * @generated
         */
        EReference GetEOperation_EParameters();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EOperation#getEExceptions <em>EExceptions</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EExceptions</em>'.
         * @see org.eclipse.emf.ecore.EOperation#getEExceptions()
         * @see #getEOperation()
         * @generated
         */
        EReference GetEOperation_EExceptions();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EOperation#getEGenericExceptions <em>EGeneric Exceptions</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EGeneric Exceptions</em>'.
         * @see org.eclipse.emf.ecore.EOperation#getEGenericExceptions()
         * @see #getEOperation()
         * @generated
         */
        EReference GetEOperation_EGenericExceptions();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EOperation#getOperationID() <em>Get Operation ID</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Operation ID</em>' operation.
         * @see org.eclipse.emf.ecore.EOperation#getOperationID()
         * @generated
         */
        EOperation GetEOperation__GetOperationID();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EOperation#isOverrideOf(org.eclipse.emf.ecore.EOperation) <em>Is Override Of</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Is Override Of</em>' operation.
         * @see org.eclipse.emf.ecore.EOperation#isOverrideOf(org.eclipse.emf.ecore.EOperation)
         * @generated
         */
        EOperation GetEOperation__IsOverrideOf__EOperation();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EOperation#getETypeParameters <em>EType Parameters</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EType Parameters</em>'.
         * @see org.eclipse.emf.ecore.EOperation#getETypeParameters()
         * @see #getEOperation()
         * @generated
         */
        EReference GetEOperation_ETypeParameters();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EPackage <em>EPackage</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EPackage</em>'.
         * @see org.eclipse.emf.ecore.EPackage
         * @generated
         */
        EClass GetEPackage();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EPackage#getNsURI <em>Ns URI</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Ns URI</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getNsURI()
         * @see #getEPackage()
         * @generated
         */
        EAttribute GetEPackage_NsURI();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EPackage#getNsPrefix <em>Ns Prefix</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Ns Prefix</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getNsPrefix()
         * @see #getEPackage()
         * @generated
         */
        EAttribute GetEPackage_NsPrefix();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EPackage#getEFactoryInstance <em>EFactory Instance</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EFactory Instance</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getEFactoryInstance()
         * @see #getEPackage()
         * @generated
         */
        EReference GetEPackage_EFactoryInstance();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EPackage#getEClassifiers <em>EClassifiers</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EClassifiers</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getEClassifiers()
         * @see #getEPackage()
         * @generated
         */
        EReference GetEPackage_EClassifiers();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EPackage#getESubpackages <em>ESubpackages</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>ESubpackages</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getESubpackages()
         * @see #getEPackage()
         * @generated
         */
        EReference GetEPackage_ESubpackages();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EPackage#getESuperPackage <em>ESuper Package</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>ESuper Package</em>'.
         * @see org.eclipse.emf.ecore.EPackage#getESuperPackage()
         * @see #getEPackage()
         * @generated
         */
        EReference GetEPackage_ESuperPackage();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EPackage#getEClassifier(java.lang.String) <em>Get EClassifier</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get EClassifier</em>' operation.
         * @see org.eclipse.emf.ecore.EPackage#getEClassifier(java.lang.String)
         * @generated
         */
        EOperation GetEPackage__GetEClassifier__String();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EParameter <em>EParameter</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EParameter</em>'.
         * @see org.eclipse.emf.ecore.EParameter
         * @generated
         */
        EClass GetEParameter();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EParameter#getEOperation <em>EOperation</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EOperation</em>'.
         * @see org.eclipse.emf.ecore.EParameter#getEOperation()
         * @see #getEParameter()
         * @generated
         */
        EReference GetEParameter_EOperation();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EReference <em>EReference</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EReference</em>'.
         * @see org.eclipse.emf.ecore.EReference
         * @generated
         */
        EClass GetEReference();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EReference#isContainment <em>Containment</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Containment</em>'.
         * @see org.eclipse.emf.ecore.EReference#isContainment()
         * @see #getEReference()
         * @generated
         */
        EAttribute GetEReference_Containment();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EReference#isContainer <em>Container</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Container</em>'.
         * @see org.eclipse.emf.ecore.EReference#isContainer()
         * @see #getEReference()
         * @generated
         */
        EAttribute GetEReference_Container();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EReference#isResolveProxies <em>Resolve Proxies</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Resolve Proxies</em>'.
         * @see org.eclipse.emf.ecore.EReference#isResolveProxies()
         * @see #getEReference()
         * @generated
         */
        EAttribute GetEReference_ResolveProxies();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EReference#getEOpposite <em>EOpposite</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EOpposite</em>'.
         * @see org.eclipse.emf.ecore.EReference#getEOpposite()
         * @see #getEReference()
         * @generated
         */
        EReference GetEReference_EOpposite();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EReference#getEReferenceType <em>EReference Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EReference Type</em>'.
         * @see org.eclipse.emf.ecore.EReference#getEReferenceType()
         * @see #getEReference()
         * @generated
         */
        EReference GetEReference_EReferenceType();
        /**
         * Returns the meta object for the reference list '{@link org.eclipse.emf.ecore.EReference#getEKeys <em>EKeys</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference list '<em>EKeys</em>'.
         * @see org.eclipse.emf.ecore.EReference#getEKeys()
         * @see #getEReference()
         * @generated
         */
        EReference GetEReference_EKeys();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EStructuralFeature <em>EStructural Feature</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EStructural Feature</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature
         * @generated
         */
        EClass GetEStructuralFeature();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#isTransient <em>Transient</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Transient</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#isTransient()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_Transient();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#isVolatile <em>Volatile</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Volatile</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#isVolatile()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_Volatile();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#isChangeable <em>Changeable</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Changeable</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#isChangeable()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_Changeable();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#getDefaultValueLiteral <em>Default Value Literal</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Default Value Literal</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#getDefaultValueLiteral()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_DefaultValueLiteral();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#getDefaultValue <em>Default Value</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Default Value</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#getDefaultValue()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_DefaultValue();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#isUnsettable <em>Unsettable</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Unsettable</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#isUnsettable()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_Unsettable();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.EStructuralFeature#isDerived <em>Derived</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Derived</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#isDerived()
         * @see #getEStructuralFeature()
         * @generated
         */
        EAttribute GetEStructuralFeature_Derived();
        /**
         * Returns the meta object for the container reference '{@link org.eclipse.emf.ecore.EStructuralFeature#getEContainingClass <em>EContaining Class</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the container reference '<em>EContaining Class</em>'.
         * @see org.eclipse.emf.ecore.EStructuralFeature#getEContainingClass()
         * @see #getEStructuralFeature()
         * @generated
         */
        EReference GetEStructuralFeature_EContainingClass();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EStructuralFeature#getFeatureID() <em>Get Feature ID</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Feature ID</em>' operation.
         * @see org.eclipse.emf.ecore.EStructuralFeature#getFeatureID()
         * @generated
         */
        EOperation GetEStructuralFeature__GetFeatureID();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EStructuralFeature#getContainerClass() <em>Get Container Class</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Get Container Class</em>' operation.
         * @see org.eclipse.emf.ecore.EStructuralFeature#getContainerClass()
         * @generated
         */
        EOperation GetEStructuralFeature__GetContainerClass();
        /**
         * @deprecated
         * replaced by getETypedElement_Unique()
         */
        EAttribute GetEStructuralFeature_Unique();
        /**
         * @deprecated
         * replaced by getETypedElement_LowerBound()
         */
        EAttribute GetEStructuralFeature_LowerBound();
        /**
         * @deprecated
         * replaced by getETypedElement_UpperBound()
         */
        EAttribute GetEStructuralFeature_UpperBound();
        /**
         * @deprecated
         * replaced by getETypedElement_Many()
         */
        EAttribute GetEStructuralFeature_Many();
        /**
         * @deprecated
         * replaced by getETypedElement_Required()
         */
        EAttribute GetEStructuralFeature_Required();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.ETypedElement <em>ETyped Element</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>ETyped Element</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement
         * @generated
         */
        EClass getETypedElement();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#isOrdered <em>Ordered</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Ordered</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#isOrdered()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_Ordered();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#isUnique <em>Unique</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Unique</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#isUnique()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_Unique();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#getLowerBound <em>Lower Bound</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Lower Bound</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#getLowerBound()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_LowerBound();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#getUpperBound <em>Upper Bound</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Upper Bound</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#getUpperBound()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_UpperBound();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#isMany <em>Many</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Many</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#isMany()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_Many();
        /**
         * Returns the meta object for the attribute '{@link org.eclipse.emf.ecore.ETypedElement#isRequired <em>Required</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Required</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#isRequired()
         * @see #getETypedElement()
         * @generated
         */
        EAttribute GetETypedElement_Required();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.ETypedElement#getEType <em>EType</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EType</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#getEType()
         * @see #getETypedElement()
         * @generated
         */
        EReference GetETypedElement_EType();
        /**
         * Returns the meta object for the containment reference '{@link org.eclipse.emf.ecore.ETypedElement#getEGenericType <em>EGeneric Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference '<em>EGeneric Type</em>'.
         * @see org.eclipse.emf.ecore.ETypedElement#getEGenericType()
         * @see #getETypedElement()
         * @generated
         */
        EReference GetETypedElement_EGenericType();
        /**
         * Returns the meta object for class '{@link java.util.Map.Entry <em>EString To String Map Entry</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EString To String Map Entry</em>'.
         * @see java.util.Map.Entry
         * @model keyDataType="org.eclipse.emf.ecore.EString"
         *        valueDataType="org.eclipse.emf.ecore.EString"
         * @generated
         */
        EClass GetEStringToStringMapEntry();
        /**
         * Returns the meta object for the attribute '{@link java.util.Map.Entry <em>Key</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Key</em>'.
         * @see java.util.Map.Entry
         * @see #getEStringToStringMapEntry()
         * @generated
         */
        EAttribute GetEStringToStringMapEntry_Key();
        /**
         * Returns the meta object for the attribute '{@link java.util.Map.Entry <em>Value</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the attribute '<em>Value</em>'.
         * @see java.util.Map.Entry
         * @see #getEStringToStringMapEntry()
         * @generated
         */
        EAttribute GetEStringToStringMapEntry_Value();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.EGenericType <em>EGeneric Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EGeneric Type</em>'.
         * @see org.eclipse.emf.ecore.EGenericType
         * @generated
         */
        EClass GetEGenericType();
        /**
         * Returns the meta object for the containment reference '{@link org.eclipse.emf.ecore.EGenericType#getEUpperBound <em>EUpper Bound</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference '<em>EUpper Bound</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getEUpperBound()
         * @see #getEGenericType()
         * @generated
         */
        EReference GetEGenericType_EUpperBound();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.EGenericType#getETypeArguments <em>EType Arguments</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EType Arguments</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getETypeArguments()
         * @see #getEGenericType()
         * @generated
         */
        EReference GgetEGenericType_ETypeArguments();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EGenericType#getERawType <em>ERaw Type</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>ERaw Type</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getERawType()
         * @see #getEGenericType()
         * @generated
         */
        EReference GetEGenericType_ERawType();
        /**
         * Returns the meta object for the containment reference '{@link org.eclipse.emf.ecore.EGenericType#getELowerBound <em>ELower Bound</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference '<em>ELower Bound</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getELowerBound()
         * @see #getEGenericType()
         * @generated
         */
        EReference GetEGenericType_ELowerBound();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EGenericType#getETypeParameter <em>EType Parameter</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EType Parameter</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getETypeParameter()
         * @see #getEGenericType()
         * @generated
         */
        EReference GetEGenericType_ETypeParameter();
        /**
         * Returns the meta object for the reference '{@link org.eclipse.emf.ecore.EGenericType#getEClassifier <em>EClassifier</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the reference '<em>EClassifier</em>'.
         * @see org.eclipse.emf.ecore.EGenericType#getEClassifier()
         * @see #getEGenericType()
         * @generated
         */
        EReference GetEGenericType_EClassifier();
        /**
         * Returns the meta object for the '{@link org.eclipse.emf.ecore.EGenericType#isInstance(java.lang.Object) <em>Is Instance</em>}' operation.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the '<em>Is Instance</em>' operation.
         * @see org.eclipse.emf.ecore.EGenericType#isInstance(java.lang.Object)
         * @generated
         */
        EOperation GetEGenericType__IsInstance__Object();
        /**
         * Returns the meta object for class '{@link org.eclipse.emf.ecore.ETypeParameter <em>EType Parameter</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for class '<em>EType Parameter</em>'.
         * @see org.eclipse.emf.ecore.ETypeParameter
         * @generated
         */
        EClass GetETypeParameter();
        /**
         * Returns the meta object for the containment reference list '{@link org.eclipse.emf.ecore.ETypeParameter#getEBounds <em>EBounds</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for the containment reference list '<em>EBounds</em>'.
         * @see org.eclipse.emf.ecore.ETypeParameter#getEBounds()
         * @see #getETypeParameter()
         * @generated
         */
        EReference GetETypeParameter_EBounds();
        /**
         * Returns the meta object for data type '{@link java.math.BigDecimal <em>EBig Decimal</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EBig Decimal</em>'.
         * @see java.math.BigDecimal
         * @model instanceClass="java.math.BigDecimal"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#decimal'"
         * @generated
         */
        EDataType GetEBigDecimal();
        /**
         * Returns the meta object for data type '{@link java.math.BigInteger <em>EBig Integer</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EBig Integer</em>'.
         * @see java.math.BigInteger
         * @model instanceClass="java.math.BigInteger"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#integer'"
         * @generated
         */
        EDataType getEBigInteger();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.common.util.EList <em>EE List</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EE List</em>'.
         * @see org.eclipse.emf.common.util.EList
         * @model instanceClass="org.eclipse.emf.common.util.EList" serializeable="false" typeParameters="E"
         * @generated
         */
        EDataType getEEList();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.ecore.resource.Resource <em>EResource</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EResource</em>'.
         * @see org.eclipse.emf.ecore.resource.Resource
         * @model instanceClass="org.eclipse.emf.ecore.resource.Resource" serializeable="false"
         * @generated
         */
        EDataType getEResource();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.ecore.resource.ResourceSet <em>EResource Set</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EResource Set</em>'.
         * @see org.eclipse.emf.ecore.resource.ResourceSet
         * @model instanceClass="org.eclipse.emf.ecore.resource.ResourceSet" serializeable="false"
         * @generated
         */
        EDataType getEResourceSet();
        /**
         * Returns the meta object for data type '{@link java.lang.Boolean <em>EBoolean Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EBoolean Object</em>'.
         * @see java.lang.Boolean
         * @model instanceClass="java.lang.Boolean"
         *        extendedMetaData="baseType='EBoolean' name='EBoolean:Object'"
         * @generated
         */
        EDataType getEBooleanObject();
        /**
         * Returns the meta object for data type '{@link java.lang.Character <em>ECharacter Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>ECharacter Object</em>'.
         * @see java.lang.Character
         * @model instanceClass="java.lang.Character"
         *        extendedMetaData="baseType='EChar' name='EChar:Object'"
         * @generated
         */
        EDataType getECharacterObject();
        /**
         * Returns the meta object for data type '{@link java.util.Date <em>EDate</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EDate</em>'.
         * @see java.util.Date
         * @model instanceClass="java.util.Date"
         * @generated
         */
        EDataType getEDate();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.common.util.DiagnosticChain <em>EDiagnostic Chain</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EDiagnostic Chain</em>'.
         * @see org.eclipse.emf.common.util.DiagnosticChain
         * @model instanceClass="org.eclipse.emf.common.util.DiagnosticChain" serializeable="false"
         * @generated
         */
        EDataType getEDiagnosticChain();
        /**
         * Returns the meta object for data type '{@link java.lang.Double <em>EDouble Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EDouble Object</em>'.
         * @see java.lang.Double
         * @model instanceClass="java.lang.Double"
         *        extendedMetaData="baseType='EDouble' name='EDouble:Object'"
         * @generated
         */
        EDataType getEDoubleObject();
        /**
         * Returns the meta object for data type '{@link java.lang.Float <em>EFloat Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EFloat Object</em>'.
         * @see java.lang.Float
         * @model instanceClass="java.lang.Float"
         *        extendedMetaData="baseType='EFloat' name='EFloat:Object'"
         * @generated
         */
        EDataType getEFloatObject();
        /**
         * Returns the meta object for data type '{@link java.lang.Integer <em>EInteger Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EInteger Object</em>'.
         * @see java.lang.Integer
         * @model instanceClass="java.lang.Integer"
         *        extendedMetaData="baseType='EInt' name='EInt:Object'"
         * @generated
         */
        EDataType getEIntegerObject();
        /**
         * Returns the meta object for data type '<em>EBoolean</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EBoolean</em>'.
         * @model instanceClass="boolean"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#boolean'"
         * @generated
         */
        EDataType getEBoolean();
        /**
         * Returns the meta object for data type '{@link java.lang.Byte <em>EByte Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EByte Object</em>'.
         * @see java.lang.Byte
         * @model instanceClass="java.lang.Byte"
         *        extendedMetaData="baseType='EByte' name='EByte:Object'"
         * @generated
         */
        EDataType getEByteObject();
        /**
         * Returns the meta object for data type '<em>EByte</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EByte</em>'.
         * @model instanceClass="byte"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#byte'"
         * @generated
         */
        EDataType getEByte();
        /**
         * Returns the meta object for data type '<em>EByte Array</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EByte Array</em>'.
         * @model instanceClass="byte[]"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#hexBinary'"
         * @generated
         */
        EDataType getEByteArray();
        /**
         * Returns the meta object for data type '<em>EChar</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EChar</em>'.
         * @model instanceClass="char"
         * @generated
         */
        EDataType getEChar();
        /**
         * Returns the meta object for data type '<em>EDouble</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EDouble</em>'.
         * @model instanceClass="double"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#double'"
         * @generated
         */
        EDataType getEDouble();
        /**
         * Returns the meta object for data type '<em>EFloat</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EFloat</em>'.
         * @model instanceClass="float"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#float'"
         * @generated
         */
        EDataType getEFloat();
        /**
         * Returns the meta object for data type '<em>EInt</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EInt</em>'.
         * @model instanceClass="int"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#int'"
         * @generated
         */
        EDataType getEInt();
        /**
         * Returns the meta object for data type '{@link java.lang.Class <em>EJava Class</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EJava Class</em>'.
         * @see java.lang.Class
         * @model instanceClass="java.lang.Class" typeParameters="T"
         * @generated
         */
        EDataType getEJavaClass();
        /**
         * Returns the meta object for data type '{@link java.lang.Object <em>EJava Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EJava Object</em>'.
         * @see java.lang.Object
         * @model instanceClass="java.lang.Object"
         * @generated
         */
        EDataType getEJavaObject();
        /**
         * Returns the meta object for data type '{@link java.lang.Long <em>ELong Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>ELong Object</em>'.
         * @see java.lang.Long
         * @model instanceClass="java.lang.Long"
         *        extendedMetaData="baseType='ELong' name='ELong:Object'"
         * @generated
         */
        EDataType getELongObject();
        /**
         * Returns the meta object for data type '{@link java.util.Map <em>EMap</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EMap</em>'.
         * @see java.util.Map
         * @model instanceClass="java.util.Map" serializeable="false" typeParameters="K V"
         * @generated
         */
        EDataType getEMap();
        /**
         * Returns the meta object for data type '{@link java.lang.Short <em>EShort Object</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EShort Object</em>'.
         * @see java.lang.Short
         * @model instanceClass="java.lang.Short"
         *        extendedMetaData="baseType='EShort' name='EShort:Object'"
         * @generated
         */
        EDataType getEShortObject();
        /**
         * Returns the meta object for data type '<em>ELong</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>ELong</em>'.
         * @model instanceClass="long"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#long'"
         * @generated
         */
        EDataType getELong();
        /**
         * Returns the meta object for data type '<em>EShort</em>'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EShort</em>'.
         * @model instanceClass="short"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#short'"
         * @generated
         */
        EDataType getEShort();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.common.util.TreeIterator <em>ETree Iterator</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>ETree Iterator</em>'.
         * @see org.eclipse.emf.common.util.TreeIterator
         * @model instanceClass="org.eclipse.emf.common.util.TreeIterator" serializeable="false" typeParameters="E"
         * @generated
         */
        EDataType getETreeIterator();
        /**
         * Returns the meta object for data type '{@link java.lang.reflect.InvocationTargetException <em>EInvocation Target Exception</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EInvocation Target Exception</em>'.
         * @see java.lang.reflect.InvocationTargetException
         * @model instanceClass="java.lang.reflect.InvocationTargetException" serializeable="false"
         * @generated
         */
        EDataType getEInvocationTargetException();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.ecore.util.FeatureMap.Entry <em>EFeature Map Entry</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EFeature Map Entry</em>'.
         * @see org.eclipse.emf.ecore.util.FeatureMap.Entry
         * @model instanceClass="org.eclipse.emf.ecore.util.FeatureMap$Entry" serializeable="false"
         * @generated
         */
        EDataType getEFeatureMapEntry();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.common.util.Enumerator <em>EEnumerator</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EEnumerator</em>'.
         * @see org.eclipse.emf.common.util.Enumerator
         * @model instanceClass="org.eclipse.emf.common.util.Enumerator" serializeable="false"
         * @generated
         */
        EDataType GetEEnumerator();
        /**
         * Returns the meta object for data type '{@link org.eclipse.emf.ecore.util.FeatureMap <em>EFeature Map</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EFeature Map</em>'.
         * @see org.eclipse.emf.ecore.util.FeatureMap
         * @model instanceClass="org.eclipse.emf.ecore.util.FeatureMap" serializeable="false"
         * @generated
         */
        EDataType GetEFeatureMap();
        /**
         * Returns the meta object for data type '{@link java.lang.String <em>EString</em>}'.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the meta object for data type '<em>EString</em>'.
         * @see java.lang.String
         * @model instanceClass="java.lang.String"
         *        extendedMetaData="baseType='http://www.w3.org/2001/XMLSchema#string'"
         * @generated
         */

        EDataType getEString();
        /**
         * Returns the factory that creates the instances of the model.
         * <!-- begin-user-doc -->
         * <!-- end-user-doc -->
         * @return the factory that creates the instances of the model.
         * @generated
         */
        EcoreFactory GetEcoreFactory();
    }
}
