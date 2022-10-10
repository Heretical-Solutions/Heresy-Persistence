namespace HereticalSolutions.Persistence.Visitors
{
	public interface IVisitable
	{
		void Accept(IVisitor visitor);
	}
}