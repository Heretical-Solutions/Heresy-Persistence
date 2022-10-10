using System;
using System.Collections.Generic;
using HereticalSolutions.Persistence.Serializers;
using HereticalSolutions.Persistence.Settings;

namespace HereticalSolutions.Persistence.Visitors
{
	public class VisitorBase : IVisitor
	{
		protected Dictionary<Type, object> concreteVisitors;

		public VisitorBase(
			Dictionary<Type, object> concreteVisitors)
		{
			this.concreteVisitors = concreteVisitors;
		}

		public void Visit<TVisitable>(TVisitable visitable)
		{
			if (!concreteVisitors.TryGetValue(typeof(TVisitable), out object concreteVisitor))
				throw new Exception($"[VisitorBase] NO CONCRETE VISITOR FOR VISITABLE TYPE {typeof(TVisitable).ToString()}");

			VisitConcrete(visitable, concreteVisitor);
		}

		protected virtual void VisitConcrete<TVisitable>(
			TVisitable visitable,
			object concreteVisitor)
		{
			((IConcreteVisitor<TVisitable>)concreteVisitor).Visit(visitable, this);
		}
	}
}