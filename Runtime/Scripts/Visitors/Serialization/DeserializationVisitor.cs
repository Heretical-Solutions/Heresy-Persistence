using System;
using System.Collections.Generic;
using HereticalSolutions.Persistence.Serializers;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Visitors
{
	/// <summary>
	/// A visitor that loads data from serializer and provides it to the visitees
	/// </summary>
	public class DeserializationVisitor : VisitorBase
	{
		/// <summary>
		/// Serializer dependency
		/// </summary>
		protected ISerializer serializer;

		/// <summary>
		/// Serialization settings dependency
		/// </summary>
		protected SerializationSettings settings;

		public object DataAccessObject { get; set; }

		public DeserializationVisitor(
			Dictionary<Type, object> concreteVisitors,
			ISerializer serializer,
			SerializationSettings settings)
			: base (concreteVisitors)
		{
			this.serializer = serializer;

			this.settings = settings;
		}

		protected override void VisitConcrete<TVisitable>(
			TVisitable visitable,
			object concreteVisitor)
		{
			serializer.Load(
				DataAccessObject,
				settings);

			base.VisitConcrete<TVisitable>(
				visitable,
				concreteVisitor);
		}
	}
}