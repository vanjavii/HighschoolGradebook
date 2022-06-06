using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Class_SO
{
    public class AddClassSO : SystemOperationBase
    {
        public int Result { get; private set; }

        private readonly Class c;

        public AddClassSO(Class c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            Result = repository.AddToSelectedColsOutputInserted(c, "idClass", "DateAndTime", "IdTeacher", "IdClassGroup", c.DateAndTime, c.Teacher.IdTeacher, c.ClassGroup.IdClassGroup);
        }
    }
}
