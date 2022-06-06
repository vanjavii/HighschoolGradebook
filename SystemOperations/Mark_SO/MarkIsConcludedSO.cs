using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class MarkIsConcludedSO : SystemOperationBase
    {
        public bool Result { get; private set; }
        Mark m = new Mark();
        Class c = new Class();
        Teacher t = new Teacher();
        Subject s = new Subject();
        private int idSubject;
        private int idStudent;

        public MarkIsConcludedSO(int idSubject, int idStudent)
        {
            this.idSubject = idSubject;
            this.idStudent = idStudent;
        }

        protected override void Execute()
        {
            //$"select count(*) from mark m join Class c on (m.IdClass = c.IdClass) join teacher t on (c.IdTeacher = t.IdTeacher) join subject s on (t.IdSubject = s.IdSubject) where m.IdStudent = {idStudent} and s.IdSubject ={idSubject} and m.FinalValue is not null";
            Result = repository.TableJoin4IsNotNull(m, c, t, s, "idclass", "idteacher", "idsubject","idstudent",idStudent,idSubject,"finalvalue");
        }
    }
}
