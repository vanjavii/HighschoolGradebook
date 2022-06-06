using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO.Social
{
    public class GetAll3rdSocialSO : SystemOperationBase
    {
        public List<Subject> Result { get; private set; }
        Subject s = new Subject();

        protected override void Execute()
        {
            Result = repository.GetAllWhereStringCriteria(s, s.SubjY3SS).OfType<Subject>().ToList();
        }
    }
}
