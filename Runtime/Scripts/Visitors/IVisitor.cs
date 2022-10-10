namespace HereticalSolutions.Persistence.Visitors
{
	public interface IVisitor
	{
        void Visit<TVisitable>(TVisitable visitable);
	}
}