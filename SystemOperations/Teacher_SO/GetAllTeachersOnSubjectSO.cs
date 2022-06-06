using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllTeachersOnSubjectSO : SystemOperationBase
    {
        private readonly int idSubject;
        Teacher t = new Teacher();
        Subject s = new Subject();
        public List<Teacher> Result { get; private set; }
        public GetAllTeachersOnSubjectSO(int idSubject)
        {
            this.idSubject = idSubject;
        }

        protected override void Execute()
        {
            Result = repository.GetAllJoinWhereOrderByAsc(t, s, "idsubject", "idsubject", "idsubject", idSubject, "lastname").OfType<Teacher>().ToList();
        }
    }
}
