using MOF.ECore;

namespace MOF.Impl
{
    public abstract class ENamedElementImpl : EModelElementImpl, ENamedElement
    {
        public string Name { get; set; }
    }
}
