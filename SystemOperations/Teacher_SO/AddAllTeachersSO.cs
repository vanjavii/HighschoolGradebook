using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.Teacher_SO
{
    public class AddAllTeachersSO : SystemOperationBase
    {
        private List<Teacher> teachers;
        private int subjectId;

        public AddAllTeachersSO(List<Teacher> teachers, int subjectId)
        {
            this.teachers = teachers;
            this.subjectId = subjectId;
        }

        protected override void Execute()
        {
            try
            {
                int usersAdded = 0;
                foreach (Teacher t in teachers)
                {
                    repository.AddOneColIsNull(t, t.FirstName, t.LastName, t.BirthDate.ToString(), t.Address, t.PhoneNumber, t.AcademicLevel, subjectId);
                    usersAdded++;
                }
                if (usersAdded == 0)
                {
                    throw new Exception("You haven't added any Teacher! (Exception u AddAllTeachersSO)!!!!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
