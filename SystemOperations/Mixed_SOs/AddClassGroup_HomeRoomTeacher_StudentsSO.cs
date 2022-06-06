using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.Mixed_SOs
{
    public class AddClassGroup_HomeRoomTeacher_StudentsSO : SystemOperationBase
    {
        private ClassGroupDatabase cg;
        private Teacher homeRoomTeacher;
        private List<Student> students;

        public AddClassGroup_HomeRoomTeacher_StudentsSO(ClassGroupDatabase cg, Teacher homeRoomTeacher, List<Student> students)
        {
            this.cg = cg;
            this.homeRoomTeacher = homeRoomTeacher;
            this.students = students;
        }

        protected override void Execute()
        {
            try
            {
                // AddClassGroup releted
                repository.AddToSelectedCols(cg, "idclassgroup", "classgroupname", "stream", cg.IdClassGroup, cg.Name, cg.Stream);
                // PutHomeroomTeacher related
                repository.ChangeSetIsInt(homeRoomTeacher, "IdClassHomeroomTeacher", cg.IdClassGroup, "IdTeacher", homeRoomTeacher.IdTeacher);
                // Save all Students
                foreach (Student s in students)
                {
                    s.ClassGroup = new ClassGroupDatabase
                    {
                        IdClassGroup = cg.IdClassGroup
                    };
                    //repository.SaveAllColl(s,s.FirstName,s.LastName,s.BirthDate.ToString("yyyyMMdd HH:mm:ss"),s.Address,s.PhoneNumber,s.ClassGroup.IdClassGroup);
                    repository.Save(s);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
