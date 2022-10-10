using System.Collections.Generic;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Serializers
{
	/// <summary>
	/// An interface for the classes capable of serializing data to save file(s)
	/// </summary>
	public interface ISerializer
	{
		/// <summary>
		/// Saves data from dictionary<string, object> to save file(s)
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="settings">Serializiation settings</param>
		void Save(object target, SerializationSettings settings);

		void Save<TValue>(TValue target, SerializationSettings settings);

		/// <summary>
		/// Populates data to dictionary<string, object> from save file(s)
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="settings">Serializiation settings</param>
		void Load(object target, SerializationSettings settings);

		void Load<TValue>(TValue target, SerializationSettings settings);

		/// <summary>
		/// Erases save file(s)
		/// </summary>
		/// <param name="settings">Serializiation settings</param>
		void Erase(SerializationSettings settings);
	}
}