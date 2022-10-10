using System;
using System.Collections.Generic;
using HereticalSolutions.Persistence.Serializers;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Visitors
{
	/// <summary>
	/// A visitor that retrieves data from visitees and saves it with serializer
	/// </summary>
	public class SerializationVisitor : VisitorBase
	{
		/// <summary>
		/// Serializer dependency
		/// </summary>
		private ISerializer serializer;

		/// <summary>
		/// Serialization settings dependency
		/// </summary>
		private SerializationSettings settings;

		public object DataAccessObject { get; set; }

		public SerializationVisitor(
			Dictionary<Type, object> concreteVisitors,
			ISerializer serializer,
			SerializationSettings settings)
			: base(concreteVisitors)
		{
			this.serializer = serializer;

			this.settings = settings;
		}

		protected override void VisitConcrete<TVisitable>(
			TVisitable visitable,
			object concreteVisitor)
		{
			base.VisitConcrete<TVisitable>(
				visitable,
				concreteVisitor);

			serializer.Save(
				DataAccessObject,
				settings);
		}
	}
}