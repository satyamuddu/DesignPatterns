using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class OrExpression : IExpression
	{
		private IExpression expr1;
		private IExpression expr2;

		public OrExpression(IExpression expr1, IExpression expr2)
		{
			this.expr1 = expr1;
			this.expr2 = expr2;
		}

		public bool Interpret(IContext context)
		{
			return expr1.Interpret(context) || expr2.Interpret(context);
		}
	}
}
