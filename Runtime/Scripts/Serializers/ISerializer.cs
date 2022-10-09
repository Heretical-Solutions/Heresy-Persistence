using System.Collections.Generic;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Serializers
{
	/// <summary>
	/// An interface for the classes capable of serializing data to save file(s)
	/// </summary>
	public partial interface ISerializer
	{
        //TODO: implement in Heresy Databases and Repositories as partial
        /*
		/// <summary>
		/// Saves data from dictionary<string, object> to save file(s)
		/// </summary>
		/// <param name="database">Storage</param>
		/// <param name="settings">Serializiation settings</param>
		void Save(Dictionary<string, object> database, SerializationSettings settings);

		/// <summary>
		/// Populates data to dictionary<string, object> from save file(s)
		/// </summary>
		/// <param name="database">Storage</param>
		/// <param name="settings">Serializiation settings</param>
		void Load(Dictionary<string, object> database, SerializationSettings settings);
        */

		/// <summary>
		/// Erases save file(s)
		/// </summary>
		/// <param name="settings">Serializiation settings</param>
		void Erase(SerializationSettings settings);
	}
}