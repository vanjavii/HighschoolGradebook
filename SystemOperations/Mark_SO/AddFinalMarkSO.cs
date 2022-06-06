using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class AddFinalMarkSO : SystemOperationBase
    {
        public int Result { get; private set; }
        private readonly Mark m;

        public AddFinalMarkSO(Mark m)
        {
            this.m=m;
        }

        protected override void Execute()
        {
            Result = repository.AddReturnInt(m);
        }
    }
}
