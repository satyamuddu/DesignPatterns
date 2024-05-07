using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	public abstract class Composite : IComponent
	{
		private IComponent[] children = new IComponent[9];
		private int total = 0;
		private int value;
		public Composite(int val)
		{
			value = val;
		}
		public void add(IComponent c)
		{
			children[total++] = c;
		}

		public void Traverse()
		{
			Console.WriteLine(value + "  ");
			for (int i = 0; i < total; i++)
			{
				// 4. Delegation and polymorphism
				children[i].Traverse();
			}
		}
	}
}
