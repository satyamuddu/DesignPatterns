using IfElsePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{

	public class DepartmentValidation : Validation
	{
		public Department department;
		public DepartmentValidation(Department department, Validation subValidationCriteria) : base(subValidationCriteria)
		{
			this.department = department;
		}
		public override bool validate(Employee emp)
		{
			return (emp.department == this.department)
					&& subValidationCriteria.validate(emp);
		}
	}
}
