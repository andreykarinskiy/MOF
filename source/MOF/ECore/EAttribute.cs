using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF.ECore
{
    public interface EAttribute : EStructuralFeature
    {
        bool IsID { get; set; }

        EDataType EAttributeType { get; }
    }
}
