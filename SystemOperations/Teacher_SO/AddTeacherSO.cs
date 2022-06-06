using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class AddTeacherSO : SystemOperationBase
    {
        private readonly Teacher t;
        public int Result { get; private set; }

        public AddTeacherSO(Teacher t)
        {
            this.t = t;
        }

        private string Sequence => $"'{t.FirstName}','{t.LastName}','{t.BirthDate}','{t.Address}','{t.PhoneNumber}',{t.AcademicLevel},{t.Subject.IdSubject},null";

        protected override void Execute()
        {
            try
            {
                Result=repository.SaveColIsNull(t,Sequence);
                //repository.Save(t);
                //repository.SaveColIsNull(t,t.FirstName,t.LastName,t.BirthDate.ToString("yyyyMMdd HH:mm:ss"),t.Address,t.PhoneNumber,t.AcademicLevel,t.Subject.IdSubject);
                //Result = 1;
            }
            catch (Exception ex)
            {
                Result = 0;
                //throw;
            }
        }
    }
}
