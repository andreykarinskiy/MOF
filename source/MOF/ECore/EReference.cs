using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EReference : EStructuralFeature
    {
        //bool IsContainment { get; set; }

        //bool IsContainer { get; }

        //bool IsResolveProxies { get; set; }

        //EReference EOpposite { get; set; }

        EClass EReferenceType { get; }

        IList<EAttribute> EKeys { get; }
    }
}
