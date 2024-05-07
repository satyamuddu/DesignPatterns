// See https://aka.ms/new-console-template for more information
using IfElsePattern;

Console.WriteLine("Hello, World!");



///
///  COMPOSITE PATTERN
///

Employee emp = new Employee();
emp.qualification = Degree.HIGH_SCHOOL;
emp.yearsOfExperience = 5;
emp.department = Department.SALES;


List<Validation> list = DesignationFactory.getAllDesignationCriteria();

foreach (Validation validation in list)
{
	if (validation.validate(emp))
	{
		Console.WriteLine(validation.designation);
		break;
	}
}