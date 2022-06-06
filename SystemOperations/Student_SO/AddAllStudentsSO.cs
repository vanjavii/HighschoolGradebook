using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class AddAllStudentsSO : SystemOperationBase
    {
        private readonly List<Student> students;
        private readonly int classId;

        public AddAllStudentsSO(List<Student> students, int classId)
        {
            this.students = students;
            this.classId = classId;
        }
        protected override void Execute()
        {
            try
            {
                foreach (Student s in students)
                {
                    s.ClassGroup.IdClassGroup = classId;
                    repository.Save(s);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
