using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class AddAllMarksSO : SystemOperationBase
    {
        private readonly BindingList<Mark> marks;
        private readonly int idClass;

        public AddAllMarksSO(BindingList<Mark> marks, int idClass)
        {
            this.marks = marks;
            this.idClass = idClass;
        }
        protected override void Execute()
        {
            foreach(Mark m in marks)
            {
                m.Class.IdClass = idClass;
                SystemOperationBase so = new AddMarkSO(m);
                so.ExecuteTemplate();
            }
        }
    }
}
