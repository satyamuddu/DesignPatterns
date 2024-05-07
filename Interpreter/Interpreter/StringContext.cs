using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	public class StringContext : IContext
	{
		private string name;

		public StringContext(string name) {
			this.name = name;
		}
		public string Data => name;
	}
}
