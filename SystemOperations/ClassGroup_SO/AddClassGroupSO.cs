using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class AddClassGroupSO : SystemOperationBase
    {
        private readonly ClassGroupDatabase cg;
        public int Result { get; private set; }

        public AddClassGroupSO(ClassGroupDatabase cg)
        {
            this.cg = cg;
        }
        protected override void Execute()
        {
            //insert into classgroup (idclassgroup,classgroupname,stream) values ({classGroup.IdClassGroup},'{classGroup.Name}',{classGroup.Stream})";
            Result = repository.AddToSelectedCols(cg, "idclassgroup", "classgroupname", "stream", cg.IdClassGroup, cg.Name, cg.Stream);
        }
    }
}
