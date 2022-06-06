using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class RemoveTeacherSO : SystemOperationBase
    {
        private readonly int idTeacher;
        Teacher t = new Teacher();
        public int Result { get; private set; } = 1;

        public RemoveTeacherSO(int idTeacher)
        {
            this.idTeacher = idTeacher;
        }

        protected override void Execute()
        {
            try
            {
                //$"delete from teacher where Idteacher={idTeacher}";
                repository.DeleteByCriteria(t, "idteacher", idTeacher);
                //Result = 1;
            }
            catch (Exception)
            {
                Result = 2;
            }
        }
    }
}
