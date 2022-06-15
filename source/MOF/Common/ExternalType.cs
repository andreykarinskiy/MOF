using MOF.ECore;
using MOF.Impl;
using System.Runtime.CompilerServices;

namespace MOF.Common
{
    public static class ExternalType
    {
        private static readonly Dictionary<string, EDataType> externalTypes = new();
        private static readonly EPackage externalTypesPackage;

        static ExternalType()
        {
            externalTypesPackage = new EPackageImpl
            {
                NsPrefix = ECorePackage.eNS_PREFIX,
                NsURI = ECorePackage.eNS_URI,
                Name = "ExternalTypes"
            };

            RegisterType(ECorePackage.EBigDecimal, typeof(decimal));
            RegisterType(ECorePackage.EBigInteger, typeof(long));
            RegisterType(ECorePackage.EBoolean, typeof(bool));
            RegisterType(ECorePackage.EByte, typeof(byte));
            RegisterType(ECorePackage.EChar, typeof(char));
            RegisterType(ECorePackage.EDate, typeof(DateTime));
            RegisterType(ECorePackage.EDouble, typeof(double));
            RegisterType(ECorePackage.EFloat, typeof(int));
            RegisterType(ECorePackage.ELong, typeof(long));
            RegisterType(ECorePackage.EShort, typeof(short));
            RegisterType(ECorePackage.EString, typeof(string));
        }

        public static EDataType GetTypeByName(string dataTypeName) => externalTypes[dataTypeName];

        public static EDataType EString => externalTypes[nameof(ECorePackage.EString)];

        private static void RegisterType(int classifierId, Type platformType, [CallerArgumentExpression("classifierId")] string fullTypeName = "")
        {
            // Get short name of ClassifierID constant from ECorePackage.
            var typeName = fullTypeName.Split(".").Last();

            var primitiveType = new EDataTypeImpl
            {
                Name = typeName,
                InstanceClass = platformType,
                InstanceTypeName = platformType.FullName!.ToString(),
                IsSerializable = true,
                ClassifierID = classifierId,
                EPackage = externalTypesPackage
            };

            externalTypesPackage.EClassifiers.Add(primitiveType);

            externalTypes[typeName] = primitiveType;
        }
    }
}
