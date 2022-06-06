using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class AddTeacherOnNewSubjectSO : SystemOperationBase
    {
        private readonly Teacher t;
        private readonly int idSubject;

        public AddTeacherOnNewSubjectSO(Teacher t, int idSubject)
        {
            this.t = t;
            this.idSubject = idSubject;
        }

        protected override void Execute()
        {
            //insert into teacher (FirstName,LastName,BirthDate,Address,PhoneNumber,AcademicLevel,IdSubject) 
            repository.AddOneColIsNull(t, t.FirstName, t.LastName,t.BirthDate.ToString(), t.Address, t.PhoneNumber, t.AcademicLevel, idSubject);
        }
    }
}
