using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public abstract class Handler<T>
	{
		protected Handler<T> successor;
		public void SetSuccessor(Handler<T> successor)
		{
			this.successor = successor;
		}
		public abstract void HandleRequest(T request);
	}
}
