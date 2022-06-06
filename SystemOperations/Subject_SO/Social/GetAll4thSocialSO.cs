using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO.Social
{
    public class GetAll4thSocialSO : SystemOperationBase
    {
        public List<Subject> Result { get; private set; }
        Subject s = new Subject();

        protected override void Execute()
        {
            Result = repository.GetAllWhereStringCriteria(s, s.SubjY4SS).OfType<Subject>().ToList();
        }
    }
}
