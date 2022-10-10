namespace HereticalSolutions.Persistence.Visitors
{
	public interface IConcreteVisitor<TVisitable>
	{
		void Visit(
			TVisitable visitable,
			IVisitor baseVisitor);
	}
}