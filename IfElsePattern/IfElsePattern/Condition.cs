using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePattern
{
    public abstract class Condition<T, U> : ICondition<T>
    {
        protected ICondition<U> subCondition;
        public Condition(ICondition<U> subCondition)
        {
            this.subCondition = subCondition;
        }
        public bool Validate(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
