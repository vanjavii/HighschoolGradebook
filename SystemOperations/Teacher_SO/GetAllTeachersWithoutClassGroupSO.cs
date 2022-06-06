using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllTeachersWithoutClassGroupSO : SystemOperationBase
    {
        Teacher t = new Teacher();
        Subject s = new Subject();

        public List<Teacher> Result { get; private set; }       

        protected override void Execute()
        {
            //select * from Teacher t join Subject s on t.IdSubject=s.IdSubject order by t.LastName asc";
            Result = repository.GetAllJoinOrderBy(t, s, "idsubject", "lastname").OfType<Teacher>().ToList();
        }
    }
}
