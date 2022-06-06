using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class FindStudentSO : SystemOperationBase
    {
        public Student Result { get; private set; }
        Student s = new Student();
        ClassGroupDatabase cg = new ClassGroupDatabase();
        private int idStudent;

        public FindStudentSO(int idStudent)
        {
            this.idStudent = idStudent;
        }

        protected override void Execute()
        {
            //$"select * from Student s join ClassGroup c on s.IdClassGroup=c.IdClassGroup where s.IdStudent={idStudent}";
            Result = (Student)repository.FindJoinWhere(s, cg, "IdClassGroup", "IdClassGroup", "idstudent", idStudent);
        }
    }
}
