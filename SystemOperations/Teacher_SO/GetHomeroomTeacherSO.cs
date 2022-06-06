using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetHomeroomTeacherSO : SystemOperationBase
    {
        private readonly int selectedCg;
        public Teacher Result { get; private set; }
        Teacher t = new Teacher();

        public GetHomeroomTeacherSO(int selectedCg)
        {
            this.selectedCg = selectedCg;
        }
        protected override void Execute()
        {
            //$"select t.FirstName, t.LastName from Teacher t where t.IdClassHomeroomTeacher={selectedCG}";
            Result = (Teacher)repository.FindByCriteria(t, "IdClassHomeroomTeacher", selectedCg);
        }
    }
}
