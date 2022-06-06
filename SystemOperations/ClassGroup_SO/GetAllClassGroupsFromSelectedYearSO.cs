using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class GetAllClassGroupsFromSelectedYearSO : SystemOperationBase
    {
        private readonly int year;
        ClassGroupDatabase cg = new ClassGroupDatabase();
        public List<ClassGroupDatabase> Result { get; private set; }

        public GetAllClassGroupsFromSelectedYearSO(int year)
        {
            this.year = year;            
        }

        protected override void Execute()
        {
            //SELECT * FROM ClassGroup WHERE IdClassGroup LIKE '1%'
            Result = repository.GetAllWhereLike(cg, "idclassgroup", year).OfType<ClassGroupDatabase>().ToList();
        }
    }
}
