using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class GetAllConcludedMarksFromStudentSO : SystemOperationBase
    {
        
        private int idStudent;
        public List<Mark> Result { get; private set; }
        Mark m = new Mark();
        Class c = new Class();
        Teacher t = new Teacher();
        Subject s = new Subject();        

        public GetAllConcludedMarksFromStudentSO(int idStudent)
        {
            this.idStudent = idStudent;
        }

        protected override void Execute()
        {
            Result = repository.TableJoin4(m, c, t, s, "subjectname", "value", "idclass", "idteacher", "idsubject","idstudent",idStudent,"finalvalue").OfType<Mark>().ToList();
        }
    }
}
