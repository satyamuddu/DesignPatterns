using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{

    public class QualificationValidation : Validation
    {

        public Degree qualification;
        //public Validation subValidationCriteria;

        public QualificationValidation(Degree qualification, Validation subValidationCriteria) : base(subValidationCriteria)
        {
            this.qualification = qualification;
            this.subValidationCriteria = subValidationCriteria;
        }

        public override bool validate(Employee emp)
        {
            return (emp.qualification == this.qualification)
                    && subValidationCriteria.validate(emp);
        }
    }
}
