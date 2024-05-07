using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class ConcreteHandler1<T> : Handler<T> where T : class, IType
	{
		public override void HandleRequest(T request)
		{
			if ((int)request.GetValue() >= 0 && (int)request.GetValue() < 10)
			{
				Console.WriteLine("{0} handled request {1}",
					this.GetType().Name, request.GetValue());
			}
			else if (successor != null)
			{
				successor.HandleRequest(request);
			}
		}
	}
}
