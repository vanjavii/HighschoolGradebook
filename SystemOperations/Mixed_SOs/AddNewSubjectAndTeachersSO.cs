using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.Mixed_SOs
{
    public class AddNewSubjectAndTeachersSO : SystemOperationBase
    {
        private List<Teacher> teachers;
        private Subject subject;
        public int Result { get; private set; } = 1;

        public AddNewSubjectAndTeachersSO(List<Teacher> teachers, Subject subject)
        {
            this.teachers = teachers;
            this.subject = subject;
        }

        protected override void Execute()
        {
            try
            {
                int subjectId = repository.AddOutputInserted(subject);
                int usersAdded = 0;
                foreach (Teacher t in teachers)
                {
                    repository.AddOneColIsNull(t, t.FirstName, t.LastName, t.BirthDate.ToString("yyyyMMdd HH:mm:ss"), t.Address, t.PhoneNumber, t.AcademicLevel, subjectId);
                    usersAdded++;
                }
                if (usersAdded == 0)
                {
                    Result = 2;
                    throw new Exception("Teachers not added!");
                }
                //Result = 1;
            }
            catch (Exception)
            {
                Result = 0;
                throw;
            }
                          
        }
    }
}
