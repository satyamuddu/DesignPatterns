using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	internal class ConcreteVisitor2 : IVisitor
	{
		public void VisitConcreteElementA(ConcreteElementA concreteElementA)
		{
			Console.WriteLine("{0} visited by {1}",
				concreteElementA.GetType().Name, this.GetType().Name);
		}

		public void VisitConcreteElementB(ConcreteElementB concreteElementB)
		{
			Console.WriteLine("{0} visited by {1}",
				concreteElementB.GetType().Name, this.GetType().Name);
		}
	}
}
