using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EStructuralFeature : ETypedElement
    {
        bool IsTransient { get; set; }

        bool IsVolatile { get; set; }

        bool IsChangeable { get; set; }

        string DefaultValueLiteral { get; set; }

        object DefaultValue { get; set; }

        bool IsUnsettable { get; set; }

        bool IsDerived { get; set; }

        EClass EContainingClass { get; }

        int FeatureID { get; }

        Type ContainerClass { get; }

        bool IsFeatureMap { get; }

        public bool IsID { get; }

        public bool IsResolveProxies { get; }

        public bool IsContainer { get; }

        public bool IsContainment { get; }

        public EReference EOpposite { get; }
    }
}
