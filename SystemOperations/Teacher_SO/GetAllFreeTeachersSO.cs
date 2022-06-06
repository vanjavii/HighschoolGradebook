using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllFreeTeachersSO : SystemOperationBase
    {
        Teacher t = new Teacher();
        public List<Teacher> Result { get; private set; }

        protected override void Execute()
        {
            //$"select * from teacher where IdClassHomeroomTeacher is null";
            Result = repository.GetAllCriteriaNull(t, "IdClassHomeroomTeacher").OfType<Teacher>().ToList();
        }
    }
}
