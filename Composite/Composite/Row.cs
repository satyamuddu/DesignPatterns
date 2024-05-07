using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	public class Row : Composite
	{

		public Row(int val) : base(val) { }

		public new void Traverse()
		{
			Console.WriteLine("Row");
			base.Traverse();
		}
	}
}
