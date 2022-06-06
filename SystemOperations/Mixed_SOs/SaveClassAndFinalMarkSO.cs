using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.Mixed_SOs
{
    public class SaveClassAndFinalMarkSO : SystemOperationBase
    {
        private Class c;
        private Mark mark;
        public int Success{ get; private set; }

        public SaveClassAndFinalMarkSO(Class c, Mark mark)
        {
            this.c = c;
            this.mark = mark;
        }

        protected override void Execute()
        {
            try
            {
                // AddClass
                int ClassId = repository.AddToSelectedColsOutputInserted(c, "idClass", "DateAndTime", "IdTeacher", "IdClassGroup", c.DateAndTime, c.Teacher.IdTeacher, c.ClassGroup.IdClassGroup);
                mark.Class = new Class
                {
                    IdClass = ClassId
                };
                // Add final mark
                //repository.AddReturnInt(mark);
                repository.AddToSelColsReturnIntLastColNotNull(mark, mark.Student.IdStudent, mark.Class.IdClass, mark.Value, (int)mark.ExaminationType, mark.DateOfExamination);
                Success = 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
