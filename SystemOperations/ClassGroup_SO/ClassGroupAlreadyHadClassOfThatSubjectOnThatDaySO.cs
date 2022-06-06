using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class ClassGroupAlreadyHadClassOfThatSubjectOnThatDaySO : SystemOperationBase
    {
        Class c = new Class();
        Teacher t=new Teacher();
        private int idClassGroup;
        private int idSubject;
        public bool Result { get; private set; }

        public ClassGroupAlreadyHadClassOfThatSubjectOnThatDaySO(int idClassGroup, int idSubject)
        {
            this.idClassGroup = idClassGroup;
            this.idSubject = idSubject;
        }

        protected override void Execute()
        {
            //$"select count(*) from  Class c join Teacher t on (c.IdTeacher=t.IdTeacher) where t.IdSubject={idSubject} and c.IdClassGroup={idClassGroup} and datediff(day, c.DateAndTime, CURRENT_TIMESTAMP) = 0";
            Result = repository.GetCountJoin3Where(c, t, "idteacher", "idsubject", idSubject, "idclassgroup", idClassGroup, "dateandtime");

        }
    }
}
