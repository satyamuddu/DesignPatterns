using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class TerminalExpression : IExpression
	{
		private IContext terminalContext;

		public TerminalExpression(IContext terminalContext) {
			this.terminalContext = terminalContext;
		}
		public bool Interpret(IContext context)
		{
			string[] st = context.Data.Split(' ');
			for(int i=0; i<st.Length; i++)
			{
				string test = st[i];
				if (test.Equals(terminalContext.Data))
				{
					return true;
				}
			}
			return false;
		}
	}
}
