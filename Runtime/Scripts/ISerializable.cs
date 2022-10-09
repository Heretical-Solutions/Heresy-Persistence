using HereticalSolutions.Persistence.Visitors;

namespace HereticalSolutions.Persistence
{
	/// <summary>
	/// An interface for classes that can be serialized with the visitor
	/// </summary>
	public interface ISerializable
	{
		/// <summary>
		/// Accepts the visitor (saves data)
		/// </summary>
		/// <param name="visitor">Visitor</param>
		void Accept(SerializationVisitor visitor);
	}
}