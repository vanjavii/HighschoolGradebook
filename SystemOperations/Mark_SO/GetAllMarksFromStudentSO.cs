using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class GetAllMarksFromStudentSO : SystemOperationBase
    {
        public List<Mark> Result { get; private set; }
        Mark m = new Mark();
        Class c = new Class();
        Teacher t = new Teacher();
        Subject s = new Subject();
        private int idStudent;

        public GetAllMarksFromStudentSO(int idStudent)
        {
            this.idStudent = idStudent;
        }

        protected override void Execute()
        {
            //select * from mark m join Class c on (m.IdClass=c.IdClass) join teacher t on (c.IdTeacher=t.IdTeacher) join subject s on (t.IdSubject=s.IdSubject) where m.IdStudent={idStudent} and m.finalvalue is null";
            Result = repository.GetAllColIsNull4IDOWhere(m,c,t,s,"idclass", "idteacher", "idsubject", "idstudent", idStudent, "finalvalue").OfType<Mark>().ToList();
        }
    }
}
