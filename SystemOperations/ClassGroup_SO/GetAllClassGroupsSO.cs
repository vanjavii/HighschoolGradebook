using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class GetAllClassGroupsSO : SystemOperationBase
    {
        public List<ClassGroupDatabase> Result { get; private set; }

        protected override void Execute()
        {
            //Result = broker.GetAllClassGroups();
            Result = repository.GetAll(new ClassGroupDatabase()).OfType<ClassGroupDatabase>().ToList();
        }
    }
}
