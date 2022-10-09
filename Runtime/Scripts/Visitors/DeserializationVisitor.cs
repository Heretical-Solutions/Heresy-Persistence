using System.Collections.Generic;
using HereticalSolutions.Persistence.Serializers;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Visitors
{
	/// <summary>
	/// A visitor that loads data from serializer and provides it to the visitees
	/// </summary>
	public partial class DeserializationVisitor
	{
		/// <summary>
		/// Serializer dependency
		/// </summary>
		private ISerializer serializer;

		/// <summary>
		/// Serialization settings dependency
		/// </summary>
		private SerializationSettings settings;

		public DeserializationVisitor(
			ISerializer serializer,
			SerializationSettings settings)
		{
			this.serializer = serializer;

			this.settings = settings;
		}

		//TODO: implement in Heresy Databases and Repositories as partial
		/*
		/// <summary>
		/// Provide data to persistent data repository
		/// </summary>
		/// <param name="storage">Storage</param>
		public void VisitPersistentDataRepository(Dictionary<string, object> storage)
		{
			serializer.Load(storage, settings);
		}
        */
	}
}