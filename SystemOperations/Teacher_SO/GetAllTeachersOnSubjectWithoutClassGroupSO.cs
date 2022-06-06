using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllTeachersOnSubjectWithoutClassGroupSO : SystemOperationBase
    {
        private readonly int subjectId;
        public List<Teacher> Result { get; private set; }
        Teacher t = new Teacher();
        Subject s = new Subject();

        public GetAllTeachersOnSubjectWithoutClassGroupSO(int subjectId)
        {
            this.subjectId = subjectId;
        }

        protected override void Execute()
        {
            //$"select * from Teacher t join Subject s on t.IdSubject=s.IdSubject where s.IdSubject={subjectId} order by t.lastname asc";
            Result = repository.GetAllJoinWhereOrderByAsc(t, s, "idsubject", "idsubject", "idsubject", subjectId, "lastname").OfType<Teacher>().ToList();
        }
    }
}
