using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{
	public abstract class Validation
	{
		public Designation designation;
		public Validation subValidationCriteria;
		public Validation(Validation subValidationCriteria)
		{
			this.subValidationCriteria = subValidationCriteria;
		}
		public abstract bool validate(Employee emp);
	}
}
