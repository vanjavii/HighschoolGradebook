using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class PutHomeroomTeacherSO : SystemOperationBase
    {
        private readonly Teacher t;
        private readonly int cgId;

        public PutHomeroomTeacherSO(Teacher t, int cgId)
        {
            this.t = t;
            this.cgId = cgId;
        }
        protected override void Execute()
        {
            // command.CommandText = $"update Teacher set IdClassHomeroomTeacher={cgId} where IdTeacher={t.IdTeacher}";
            repository.ChangeSetIsInt(t, "IdClassHomeroomTeacher", cgId, "IdTeacher", t.IdTeacher);
        }
    }
}
