using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO.Mathematical
{
    public class GetAll2ndMathSO : SystemOperationBase
    {
        public List<Subject> Result { get; private set; }
        Subject s = new Subject();

        protected override void Execute()
        {
            Result = repository.GetAllWhereStringCriteria(s, s.SubjY2SM).OfType<Subject>().ToList();
        }
    }
}
