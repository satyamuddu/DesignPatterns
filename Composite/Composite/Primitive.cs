using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	public class Primitive : IComponent
	{
		private int value;
        public Primitive(int val)
        {
			value = val;
        }
        public void Traverse()
		{
            Console.WriteLine(	value + "  ");
        }
	}
}
