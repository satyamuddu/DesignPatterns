using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class ConcreteHandler3<T> : Handler<T> where T : class,IType
	{
		public override void HandleRequest(T request)
		{
			if ((int)request.GetValue() >= 20 && (int)request.GetValue() < 30)
			{
				Console.WriteLine("{0} handled request {1}",
					this.GetType().Name, (int)request.GetValue());
			}
			else if (successor != null)
			{
				successor.HandleRequest(request);
			}
		}
	}
}
