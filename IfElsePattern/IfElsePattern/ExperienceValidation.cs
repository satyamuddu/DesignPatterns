using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{
    public class ExperienceValidation : Validation
    {

        public int minExp;
        public int maxExp;

        public ExperienceValidation(int minExp, int maxExp, Validation subValidationCriteria) : base(subValidationCriteria)
        {
            this.minExp = minExp;
            this.maxExp = maxExp;
        }

        public override bool validate(Employee emp)
        {
            return (emp.yearsOfExperience >= minExp && emp.yearsOfExperience < maxExp)
                    && subValidationCriteria.validate(emp);
        }
    }

}
