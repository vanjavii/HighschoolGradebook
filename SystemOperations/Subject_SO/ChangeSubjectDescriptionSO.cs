using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO
{
    public class ChangeSubjectDescriptionSO : SystemOperationBase
    {
        public int Result { get; private set; }
        private readonly string description;
        private readonly int subjectId;
        Subject s = new Subject();

        public ChangeSubjectDescriptionSO(string description, int subjectId)
        {
            this.description = description;
            this.subjectId = subjectId;
        }
        protected override void Execute()
        {
            //$"update subject set description='{description}' where IdSubject={subjectId}";
            try
            {
                repository.Change(s, "description", description, "idsubject", subjectId);
                Result = 1;
            }
            catch (Exception)
            {
                Result = 0;
            }
        }
    }
}
