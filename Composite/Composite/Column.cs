using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	public class Column : Composite
	{

		public Column(int val) : base(val)
		{
		}

		public new void Traverse()
		{
			Console.WriteLine("Col");
			base.Traverse();
		}
	}
}
