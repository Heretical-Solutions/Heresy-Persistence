using HereticalSolutions.Persistence.Visitors;

namespace HereticalSolutions.Persistence
{
	/// <summary>
	/// An interface for classes that can be deserialized with the visitor
	/// </summary>
	public interface IDeserializable
	{
		/// <summary>
		/// Accepts the visitor (loads data)
		/// </summary>
		/// <param name="visitor">Visitor</param>
		void Accept(DeserializationVisitor visitor);
	}
}