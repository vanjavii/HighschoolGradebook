using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClassGroup_SO
{
    public class GetStreamFromClassGroupSO : SystemOperationBase
    {
        ClassGroupDatabase cg = new ClassGroupDatabase();
        private readonly int idClassGroup;
        public bool Result { get; private set; }

        public GetStreamFromClassGroupSO(int idClassGroup)
        {
            this.idClassGroup = idClassGroup;
        }
        protected override void Execute()
        {
            //$"select stream from classgroup where idclassgroup={idClassGroup}";
            Result = repository.GetColumnWhereBool(cg, "stream", "idclassgroup", idClassGroup);
        }
    }
}
