namespace XMI
{
    public interface IXmiVisitor
    {
        void Visit(XMI element);

        void Visit(Documentation element);

        void Visit(Extension element);

        void Visit(Difference element);

        void Visit(Add element);

        void Visit(Replace element);

        void Visit(Delete element);
    }
}
