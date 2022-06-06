using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class RemoveStudentSO : SystemOperationBase
    {
        public int Result { get; private set; }
        Student s = new Student();
        private readonly int selectedId;

        public RemoveStudentSO(int selectedId)
        {
            this.selectedId = selectedId;
        }

        protected override void Execute()
        {
            //$"delete from student where IdStudent={idStudent}";
            try
            {
                repository.DeleteByCriteria(s, "idstudent", selectedId);
                Result = 1;
            }
            catch (Exception)
            {
                Result = 0;
            }
        }
    }
}
