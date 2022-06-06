using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO
{
    public class GetAllSubjectsSO : SystemOperationBase
    {
        public List<Subject> Result { get; private set; }

        protected override void Execute()
        {
            Result = repository.GetAllOrderBy(new Subject(),"subjectname").OfType<Subject>().ToList();
        }
    }
}
