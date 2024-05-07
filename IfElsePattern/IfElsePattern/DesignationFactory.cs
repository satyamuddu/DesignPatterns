using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{
	public class DesignationFactory
	{

		public static List<Validation> getAllDesignationCriteria()
		{
			List<Validation> criterias = new List<Validation>();

			Validation assiantSalesAssociate = new DepartmentValidation(Department.SALES,
					new YearValidation(5,
							new QualificationValidation(Degree.HIGH_SCHOOL, new DefaultValidation(null))));
			assiantSalesAssociate.designation = Designation.ASSISTANT_SALES_ASSOCIATE;

			criterias.Add(assiantSalesAssociate);

			Validation salesAssociate1 = new DepartmentValidation(Department.SALES,
					new ExperienceValidation(0, 5,
							new QualificationValidation(Degree.BBA, new DefaultValidation(null))));

			salesAssociate1.designation = Designation.SALES_ASSOCIATE;
			criterias.Add(salesAssociate1);

			Validation salesAssociate2 = new DepartmentValidation(Department.SALES,
					new ExperienceValidation(5, 10,
						new QualificationValidation(Degree.HIGH_SCHOOL, new DefaultValidation(null))));
			salesAssociate2.designation = Designation.SALES_ASSOCIATE;
			criterias.Add(salesAssociate2);


			// Similarly we can create criteria objects other designations

			return criterias;
		}
	}
}
