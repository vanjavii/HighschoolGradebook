using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mixed_SOs
{
    public class SaveClassAndAssignedMarksSO : SystemOperationBase
    {
        private readonly Class sc;
        private readonly BindingList<Mark> marks;
        public int Result_classId { get; private set; }
        public BindingList<Mark> Result_marks { get; private set; }
        public int Success { get; set; }
        Class c = new Class();

        public SaveClassAndAssignedMarksSO(Class schoolClass, BindingList<Mark> marks)
        {
            this.sc = schoolClass;
            this.marks = marks;
        }

        protected override void Execute()
        {            
            try
            {
                
                Result_classId= repository.AddToSelectedColsOutputInserted(sc, "idClass", "DateAndTime", "IdTeacher", "IdClassGroup", sc.DateAndTime, sc.Teacher.IdTeacher, sc.ClassGroup.IdClassGroup);
                Class help = (Class)repository.FindByCriteria(c, "idclass", Result_classId);
                Success = 1;
                if (marks.Count!=0)
                {
                    foreach (Mark m in marks)
                    {
                        m.Class = new Class
                        {
                            IdClass = Result_classId,
                            DateAndTime = help.DateAndTime,
                            Teacher = help.Teacher,
                            ClassGroup = new ClassGroupDatabase
                            {
                                IdClassGroup=help.ClassGroup.IdClassGroup
                            }
                        };
                        int check = repository.AddToSelColsReturnInt(m, m.Student.IdStudent, m.Class.IdClass, m.Value, (int)m.ExaminationType, m.DateOfExamination);
                    }
                    Success = 2; 
                }                
            }
            catch (Exception)
            {
                Success = 0;
                throw;
            }
        }
    }
}
