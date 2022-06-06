using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO
{
    public class GetLatestSubjectDescriptionSO : SystemOperationBase
    {
        Subject s = new Subject();
        private int selectedSubject;

        public string Result { get; private set; }

        public GetLatestSubjectDescriptionSO(int selectedSubject)
        {
            this.selectedSubject = selectedSubject;
        }

        protected override void Execute()
        {
            Result = ((Subject)repository.FindByCriteria(s, "idsubject", selectedSubject)).Description;
        }
    }
}
