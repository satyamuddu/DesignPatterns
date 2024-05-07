using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{

    // Define more implementation of Validation rules similarly.

    public class DefaultValidation : Validation
    {

        //public Validation subValidationCriteria;

        public DefaultValidation(Validation subValidationCriteria) : base(null)
        {
            this.subValidationCriteria = subValidationCriteria;
        }

        public override bool validate(Employee emp)
        {
            return true;
        }
    }
}
