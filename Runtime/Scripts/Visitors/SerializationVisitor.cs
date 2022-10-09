using System.Collections.Generic;
using HereticalSolutions.Persistence.Serializers;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Visitors
{
	/// <summary>
	/// A visitor that retrieves data from visitees and saves it with serializer
	/// </summary>
	public partial class SerializationVisitor
	{
		/// <summary>
		/// Serializer dependency
		/// </summary>
		private ISerializer serializer;

		/// <summary>
		/// Serialization settings dependency
		/// </summary>
		private SerializationSettings settings;

		public SerializationVisitor(
			ISerializer serializer,
			SerializationSettings settings)
		{
			this.serializer = serializer;

			this.settings = settings;
		}

		//TODO: implement in Heresy Databases and Repositories as partial
		/*
		/// <summary>
		/// Retrieve data from persistent data repository
		/// </summary>
		/// <param name="storage">Storage</param>
		public void VisitPersistentDataRepository(Dictionary<string, object> storage)
		{
			serializer.Save(storage, settings);
		}
        */
	}
}