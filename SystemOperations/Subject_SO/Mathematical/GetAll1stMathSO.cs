using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO.Mathematical
{
    public class GetAll1stMathSO : SystemOperationBase
    {
        public List<Subject> Result { get; private set; }
        Subject s = new Subject();

        protected override void Execute()
        {
            //isti predmeti kao drustveni 1. i 2. godina
            Result = repository.GetAllWhereStringCriteria(s, s.SubjY1SS).OfType<Subject>().ToList();
        }
    }
}
