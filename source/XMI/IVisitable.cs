namespace XMI
{
    public interface IVisitable
    {
        void Accept(IXmiVisitor visitor);
    }
}
