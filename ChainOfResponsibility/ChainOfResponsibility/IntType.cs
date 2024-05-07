using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	internal class IntType : IType
	{
		int value;
		public IntType(int value)
		{
			this.value = value;
		}

		public object GetValue()
		{
			return value;
		}
	}
}
