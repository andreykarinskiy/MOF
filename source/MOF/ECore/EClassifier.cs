using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EClassifier : ENamedElement
    {
        string InstanceClassName { get; set; }

        Type InstanceClass { get; set; }

        object DefaultValue { get; }

        String getInstanceTypeName();

        void setInstanceTypeName(String value);

        EPackage EPackage { get; }

        IList<ETypeParameter> ETypeParameters { get; }

        bool IsInstance(object instance);

        int ClassifierID { get; }
    }
}
