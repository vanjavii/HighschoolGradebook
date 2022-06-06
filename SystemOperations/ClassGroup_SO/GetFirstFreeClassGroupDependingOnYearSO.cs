using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class GetFirstFreeClassGroupDependingOnYearSO : SystemOperationBase
    {
        public int Result{ get; private set; }
        ClassGroupDatabase cg = new ClassGroupDatabase();        
        private int yearOfStudies;

        public GetFirstFreeClassGroupDependingOnYearSO(int yearOfStudies)
        {
            this.yearOfStudies = yearOfStudies;
        }

        protected override void Execute()
        {
            Result = repository.GetMax(cg, "idclassgroup", "idclassgroup", yearOfStudies);
        }
    }
}
