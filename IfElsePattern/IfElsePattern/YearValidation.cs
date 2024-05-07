using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{
    public class YearValidation : Validation
    {

        public int yearsOfExperience;
        //public Validation subValidationCriteria;

        public YearValidation(int yearsOfExperience, Validation subValidationCriteria) : base(subValidationCriteria)
        {
            this.yearsOfExperience = yearsOfExperience;
            this.subValidationCriteria = subValidationCriteria;
        }

        public override bool validate(Employee emp)
        {
            return (emp.yearsOfExperience == this.yearsOfExperience)
                    && subValidationCriteria.validate(emp);
        }
    }


}
