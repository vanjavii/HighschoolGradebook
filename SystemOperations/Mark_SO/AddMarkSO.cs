using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class AddMarkSO : SystemOperationBase
    {
        private readonly Mark m;

        public AddMarkSO(Mark m)
        {            
            this.m = m;
        }

        public int Result { get; private set; }

        protected override void Execute()
        {
            //$"insert into mark values ({mark.Student.IdStudent},{mark.Class.IdClass},{mark.Value},{(int)mark.ExaminationType},'{mark.DateOfExamination}',null)";
            Result = repository.AddToSelColsReturnInt(m,m.Student.IdStudent,m.Class.IdClass,m.Value,(int)m.ExaminationType,m.DateOfExamination);
        }
    }
}
