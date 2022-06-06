using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class AddStudentSO : SystemOperationBase
    {
        private readonly Student s;
        public int Result { get; private set; }

        public AddStudentSO(Student s)
        {
            this.s = s;
        }
        protected override void Execute()
        {
            try
            {
                repository.Save(s);
                Result = 1;
            }
            catch
            {
                Result = 0;
            }
        }
    }
}
