using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class GetConcludedMarkFromStudentOnSubjectSO : SystemOperationBase
    {
        private int idStudent;
        private readonly int idSubj;

        public Mark MarkResult { get; private set; }
        public int MarkValue { get; set; }

        Mark m = new Mark();
        Class c = new Class();
        Teacher t = new Teacher();
        Subject s = new Subject();

        public GetConcludedMarkFromStudentOnSubjectSO(int idSubj, int idStudent)
        {
            this.idStudent = idStudent;
            this.idSubj = idSubj;
        }

        protected override void Execute()
        {
            MarkResult =(Mark)repository.TableJoin4TripleWhere(m, c, t, s, "subjectname", "value", "idclass", "idteacher", "idsubject", "idstudent", idStudent, "idsubject", idSubj, "finalvalue");
            MarkValue = MarkResult.Value;          
        }
    }
}
